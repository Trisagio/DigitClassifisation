using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

using Accord.Math;

namespace DigitClassification
{
    public partial class Form1 : Form
    {
        /*#######################################################*/
        //                       Initialization
        /*#######################################################*/

        private DataSet _dataSet = new DataSet();
        private BinaryMatrix _currentBinaryMatrix = BinaryMatrix.Empty();

        private const int
            BINARYZE_THRESHOLD = 127;

        private int preditionCount = 1,
            trainingCount = 1,
            preditionTrueCount = 0;

        string[] distFunctions = new string[]
        {
            "Евклидово расстояние",
            "Манхеттенское расстояние",
            "Расстояние Хэмминга",
            "Расстояние Рассела",
            "Расстояние Сёренсена"
        };

        Func<double[], double[], double> distFunc = Distance.Euclidean;

        private int[] preditionTrueCounter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            preditionNumberCounter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private string predicted_value = "",
            labelValue = null;

        public Form1()
        {
            InitializeComponent();
            ControlButtonClick();

            cDistanceBox.Text = "Евклидово расстояние";
            nTrainingSet.Value = preditionCount;
            nTestSet.Value = trainingCount;

            #if DEBUG
            TopMost = true;
            #endif
        }

        // ==== GUI =======================================================================>

        /*#######################################################*/
        //                       Controls
        /*#######################################################*/

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ControlButtonClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (nNext.Value > 1) nNext.Value -= 1;
                ControlButtonClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (nNext.Value < 10000) nNext.Value += 1;
                ControlButtonClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        /*#######################################################*/
        //                       Training
        /*#######################################################*/

        private void btnTrain_Click(object sender, EventArgs e)
        {
            try
            {
                btnClearDataSet.Enabled = true;
                btnPredict.Enabled = true;
                btTEST.Enabled = true;

                CheckN(nClass.Value, 0, 9);
                _currentBinaryMatrix.Flatten(vector => _dataSet.Add(DataPoint.Create(vector, nClass.Value.ToString())));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void btTRAINING_Click(object sender, EventArgs e)
        {
            try
            {
                btnClearDataSet.Enabled = true; 
                btnPredict.Enabled = true;
                btTEST.Enabled = true;
                _dataSet.Clear();
                byte[] pixels = new byte[784];

                FileStream ifsPixels = new FileStream(".\\..\\..\\Data\\train-images.idx3-ubyte", FileMode.Open);
                FileStream ifsLabels = new FileStream(".\\..\\..\\Data\\train-labels.idx1-ubyte", FileMode.Open);

                BinaryReader brImages = new BinaryReader(ifsPixels);
                BinaryReader brLabels = new BinaryReader(ifsLabels);

                int ultraImageMagic = brImages.ReadInt32();
                ultraImageMagic = ReverseBytes(ultraImageMagic);

                int imageCount = brImages.ReadInt32();
                imageCount = ReverseBytes(imageCount);

                int numRows = brImages.ReadInt32();
                numRows = ReverseBytes(numRows);

                int numCols = brImages.ReadInt32();
                numCols = ReverseBytes(numCols);

                int ultraLabelMagic = brLabels.ReadInt32();
                ultraLabelMagic = ReverseBytes(ultraLabelMagic);

                int numLabels = brLabels.ReadInt32();
                numLabels = ReverseBytes(numLabels);

                CheckN(nTrainingSet.Value, 1, 60000);

                trainingCount = (int)nTrainingSet.Value;

                for (int di = 0; di < trainingCount; di++)
                {

                    labelValue = brLabels.ReadByte().ToString();

                    for (int i = 0; i < 784; i++)
                    {
                        byte b = brImages.ReadByte();
                        pixels[i] = b;
                    }

                    _currentBinaryMatrix = WorkingViaImage(DataToBitmap(pixels));
                    _currentBinaryMatrix.Flatten(vector => _dataSet.Add(DataPoint.Create(vector, labelValue)));
                }

                ifsPixels.Close(); brImages.Close();
                ifsLabels.Close(); brLabels.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void btnClearDataSet_Click(object sender, EventArgs e)
        {
            btnClearDataSet.Enabled = false;
            btnPredict.Enabled = false;
            btTEST.Enabled = false;
            _dataSet.Clear();
            preditionCount = 0;
            preditionTrueCount = 0;
        }

        /*#######################################################*/
        //                       Recognition
        /*#######################################################*/

        private void btTEST_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                FileStream ifsPixels = new FileStream(".\\..\\..\\Data\\t10k-images.idx3-ubyte", FileMode.Open);
                FileStream ifsLabels = new FileStream(".\\..\\..\\Data\\t10k-labels.idx1-ubyte", FileMode.Open);

                BinaryReader brImages = new BinaryReader(ifsPixels);
                BinaryReader brLabels = new BinaryReader(ifsLabels);

                int ultraImageMagic = brImages.ReadInt32();
                ultraImageMagic = ReverseBytes(ultraImageMagic);

                int imageCount = brImages.ReadInt32();
                imageCount = ReverseBytes(imageCount);

                int numRows = brImages.ReadInt32();
                numRows = ReverseBytes(numRows);

                int numCols = brImages.ReadInt32();
                numCols = ReverseBytes(numCols);

                int ultraLabelMagic = brLabels.ReadInt32();
                ultraLabelMagic = ReverseBytes(ultraLabelMagic);

                int numLabels = brLabels.ReadInt32();
                numLabels = ReverseBytes(numLabels);

                string labelValue = null;
                byte[] pixels = new byte[784];
                ChangeDistFunc();

                ClearStatistics();

                CheckN(nTestSet.Value, 1, 10000);

                preditionCount = (int)nTestSet.Value;
                preditionTrueCount = 0;
                for (int i = 0; i < 10; i++)
                {
                    preditionTrueCounter[i] = 0;
                    preditionNumberCounter[i] = 0;
                }

                for (int di = 0; di < preditionCount; di++)
                {
                    labelValue = brLabels.ReadByte().ToString();

                    for (int i = 0; i < 784; i++)
                    {
                        byte b = brImages.ReadByte();
                        pixels[i] = b;
                    }

                    _currentBinaryMatrix = WorkingViaImage(DataToBitmap(pixels));
                    _currentBinaryMatrix.Flatten(vector => predicted_value = $"{_dataSet.Predict(vector, distFunc)}");

                    switch (labelValue)
                    {
                        case "0": preditionNumberCounter[0]++; break;
                        case "1": preditionNumberCounter[1]++; break;
                        case "2": preditionNumberCounter[2]++; break;
                        case "3": preditionNumberCounter[3]++; break;
                        case "4": preditionNumberCounter[4]++; break;
                        case "5": preditionNumberCounter[5]++; break;
                        case "6": preditionNumberCounter[6]++; break;
                        case "7": preditionNumberCounter[7]++; break;
                        case "8": preditionNumberCounter[8]++; break;
                        case "9": preditionNumberCounter[9]++; break;
                    }

                    if (predicted_value == labelValue)
                    {
                        switch (predicted_value)
                        {
                            case "0":
                                preditionTrueCounter[0]++;
                                label0.Text = "0 (" +
                                    ((int)((double)preditionTrueCounter[0] /
                                    (double)preditionNumberCounter[0] * 100))
                                    .ToString() + ")%";
                                break;
                            case "1":
                                preditionTrueCounter[1]++;
                                label1.Text = "1 (" +
                                    ((int)((double)preditionTrueCounter[1] /
                                    (double)preditionNumberCounter[1] * 100))
                                    .ToString() + ")%";
                                break;
                            case "2":
                                preditionTrueCounter[2]++;
                                label2.Text = "2 (" +
                                    ((int)((double)preditionTrueCounter[2] /
                                    (double)preditionNumberCounter[2] * 100))
                                    .ToString() + ")%";
                                break;
                            case "3":
                                preditionTrueCounter[3]++;
                                label3.Text = "3 (" +
                                    ((int)((double)preditionTrueCounter[3] /
                                    (double)preditionNumberCounter[3] * 100))
                                    .ToString() + ")%";
                                break;
                            case "4":
                                preditionTrueCounter[4]++;
                                label4.Text = "4 (" +
                                    ((int)((double)preditionTrueCounter[4] /
                                    (double)preditionNumberCounter[4] * 100))
                                    .ToString() + ")%";
                                break;
                            case "5":
                                preditionTrueCounter[5]++;
                                label5.Text = "5 (" +
                                    ((int)((double)preditionTrueCounter[5] /
                                    (double)preditionNumberCounter[5] * 100))
                                    .ToString() + ")%";
                                break;
                            case "6":
                                preditionTrueCounter[6]++;
                                label6.Text = "6 (" +
                                    ((int)((double)preditionTrueCounter[6] /
                                    (double)preditionNumberCounter[6] * 100))
                                    .ToString() + ")%";
                                break;
                            case "7":
                                preditionTrueCounter[7]++;
                                label7.Text = "7 (" +
                                    ((int)((double)preditionTrueCounter[7] /
                                    (double)preditionNumberCounter[7] * 100))
                                    .ToString() + ")%";
                                break;
                            case "8":
                                preditionTrueCounter[8]++;
                                label8.Text = "8 (" +
                                    ((int)((double)preditionTrueCounter[8] /
                                    (double)preditionNumberCounter[8] * 100))
                                    .ToString() + ")%";
                                break;
                            case "9":
                                preditionTrueCounter[9]++;
                                label9.Text = "9 (" +
                                    ((int)((double)preditionTrueCounter[9] /
                                    (double)preditionNumberCounter[9] * 100))
                                    .ToString() + ")%";
                                break;
                        }

                        preditionTrueCount++;
                    }
                }

                ifsPixels.Close(); brImages.Close();
                ifsLabels.Close(); brLabels.Close();

                lblCounter.Text = "Из " + preditionCount;
                lblTrue.Text = $"Всего: {Math.Round(((double)preditionTrueCount / (double)preditionCount * 100), 1).ToString()}%";

                TimeSpan ts = stopWatch.Elapsed;
                stopWatch.Stop();
            
                lblTime.Text = String.Format("Время: {0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10.0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                FileStream ifsPixels = new FileStream(".\\..\\..\\Data\\t10k-images.idx3-ubyte", FileMode.Open);
                FileStream ifsLabels = new FileStream(".\\..\\..\\Data\\t10k-labels.idx1-ubyte", FileMode.Open);

                BinaryReader brImages = new BinaryReader(ifsPixels);
                BinaryReader brLabels = new BinaryReader(ifsLabels);

                int ultraImageMagic = brImages.ReadInt32();
                ultraImageMagic = ReverseBytes(ultraImageMagic);

                int imageCount = brImages.ReadInt32();
                imageCount = ReverseBytes(imageCount);

                int numRows = brImages.ReadInt32();
                numRows = ReverseBytes(numRows);

                int numCols = brImages.ReadInt32();
                numCols = ReverseBytes(numCols);

                int ultraLabelMagic = brLabels.ReadInt32();
                ultraLabelMagic = ReverseBytes(ultraLabelMagic);

                int numLabels = brLabels.ReadInt32();
                numLabels = ReverseBytes(numLabels);

                string labelValue = null;
                byte[] pixels = new byte[784];
                ChangeDistFunc();

                CheckN(nNext.Value, 1, 10000);

                for (int di = 0; di < nNext.Value; di++) labelValue = brLabels.ReadByte().ToString();

                _currentBinaryMatrix.Flatten(vector => predicted_value = $"{_dataSet.Predict(vector, distFunc)}");
                lblLabel.Text = "Результат: " + predicted_value;

                switch (labelValue)
                {
                    case "0": preditionNumberCounter[0]++; break;
                    case "1": preditionNumberCounter[1]++; break;
                    case "2": preditionNumberCounter[2]++; break;
                    case "3": preditionNumberCounter[3]++; break;
                    case "4": preditionNumberCounter[4]++; break;
                    case "5": preditionNumberCounter[5]++; break;
                    case "6": preditionNumberCounter[6]++; break;
                    case "7": preditionNumberCounter[7]++; break;
                    case "8": preditionNumberCounter[8]++; break;
                    case "9": preditionNumberCounter[9]++; break;
                }

                if (predicted_value == labelValue)
                {
                    switch (predicted_value)
                    {
                        case "0":
                            preditionTrueCounter[0]++;
                            label0.Text = "0 (" +
                                ((int)((double)preditionTrueCounter[0] /
                                (double)preditionNumberCounter[0] * 100))
                                .ToString() + ")%";
                            break;
                        case "1":
                            preditionTrueCounter[1]++;
                            label1.Text = "1 (" +
                                ((int)((double)preditionTrueCounter[1] /
                                (double)preditionNumberCounter[1] * 100))
                                .ToString() + ")%";
                            break;
                        case "2":
                            preditionTrueCounter[2]++;
                            label2.Text = "2 (" +
                                ((int)((double)preditionTrueCounter[2] /
                                (double)preditionNumberCounter[2] * 100))
                                .ToString() + ")%";
                            break;
                        case "3":
                            preditionTrueCounter[3]++;
                            label3.Text = "3 (" +
                                ((int)((double)preditionTrueCounter[3] /
                                (double)preditionNumberCounter[3] * 100))
                                .ToString() + ")%";
                            break;
                        case "4":
                            preditionTrueCounter[4]++;
                            label4.Text = "4 (" +
                                ((int)((double)preditionTrueCounter[4] /
                                (double)preditionNumberCounter[4] * 100))
                                .ToString() + ")%";
                            break;
                        case "5":
                            preditionTrueCounter[5]++;
                            label5.Text = "5 (" +
                                ((int)((double)preditionTrueCounter[5] /
                                (double)preditionNumberCounter[5] * 100))
                                .ToString() + ")%";
                            break;
                        case "6":
                            preditionTrueCounter[6]++;
                            label6.Text = "6 (" +
                                ((int)((double)preditionTrueCounter[6] /
                                (double)preditionNumberCounter[6] * 100))
                                .ToString() + ")%";
                            break;
                        case "7":
                            preditionTrueCounter[7]++;
                            label7.Text = "7 (" +
                                ((int)((double)preditionTrueCounter[7] /
                                (double)preditionNumberCounter[7] * 100))
                                .ToString() + ")%";
                            break;
                        case "8":
                            preditionTrueCounter[8]++;
                            label8.Text = "8 (" +
                                ((int)((double)preditionTrueCounter[8] /
                                (double)preditionNumberCounter[8] * 100))
                                .ToString() + ")%";
                            break;
                        case "9":
                            preditionTrueCounter[9]++;
                            label9.Text = "9 (" +
                                ((int)((double)preditionTrueCounter[9] /
                                (double)preditionNumberCounter[9] * 100))
                                .ToString() + ")%";
                            break;
                    }

                    preditionTrueCount++;
                }

                ifsPixels.Close(); brImages.Close();
                ifsLabels.Close(); brLabels.Close();

                preditionCount += 1;
                lblCounter.Text = "Из " + preditionCount;
                lblTrue.Text = $"Всего: {Math.Round(((double)preditionTrueCount / (double)preditionCount * 100), 1).ToString()}%";

                TimeSpan ts = stopWatch.Elapsed;
                stopWatch.Stop();

                lblTime.Text = String.Format("Время: {0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10.0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        /*#######################################################*/
        //                       Statistics
        /*#######################################################*/

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            preditionTrueCount = 0;
            for (int i = 0; i < 10; i++)
            {
                preditionTrueCounter[i] = 0;
                preditionNumberCounter[i] = 0;
            }

            predicted_value = "";

            labelValue = null;

            ClearStatistics();
        }

        // ==== Functions =======================================================================>

        private static int ReverseBytes(int v)
        {
            byte[] intAsBytes = BitConverter.GetBytes(v);
            Array.Reverse(intAsBytes);

            return BitConverter.ToInt32(intAsBytes, 0);
        }

        private decimal CheckN(decimal n, int lowerTreshold, int upperTreshold)
        {
            if (n > upperTreshold) n = upperTreshold;
            else if (n < lowerTreshold) n = lowerTreshold;

            return n;
        }

        private BinaryMatrix WorkingViaImage(Bitmap im)
        {
            BinaryMatrix binaryMatrix = BinaryMatrix.Create(
                new ImageProcessing(im)
                .Binarize(BINARYZE_THRESHOLD)
                .Invert()
                .CropBlob()
                .Image,
                 0.5f);

            return binaryMatrix;
        }

        private Func<double[], double[], double> ChangeDistFunc()
        {
            for (int i = 0; i < 5; i++)
            {
                if (cDistanceBox.Text == distFunctions[i])
                {
                    switch (i)
                    {
                        case 0: distFunc = Distance.Euclidean; break;
                        case 1: distFunc = Distance.Kulczynski; break;
                        case 2: distFunc = Distance.Hamming; break;
                        case 3: distFunc = Distance.RusselRao; break;
                        case 4: distFunc = Distance.Dice; break;
                        default: distFunc = Distance.Euclidean; break;
                    }

                }
            }

            return distFunc;
        }

        private void ClearStatistics()
        {
            lblCounter.Text = "Из 0";
            lblTrue.Text = "Всего: 0%";
            lblTime.Text = "Время: 00:00:00:00";

            label0.Text = "0 (0)%";
            label1.Text = "1 (0)%";
            label2.Text = "2 (0)%";
            label3.Text = "3 (0)%";
            label4.Text = "4 (0)%";
            label5.Text = "5 (0)%";
            label6.Text = "6 (0)%";
            label7.Text = "7 (0)%";
            label8.Text = "8 (0)%";
            label9.Text = "9 (0)%";
        }

        private void ControlButtonClick()
        {
            FileStream ifsPixels = new FileStream(".\\..\\..\\data\\t10k-images.idx3-ubyte", FileMode.Open);
            FileStream ifsLabels = new FileStream(".\\..\\..\\data\\t10k-labels.idx1-ubyte", FileMode.Open);

            BinaryReader brImages = new BinaryReader(ifsPixels);
            BinaryReader brLabels = new BinaryReader(ifsLabels);

            int ultraImageMagic = brImages.ReadInt32();
            ultraImageMagic = ReverseBytes(ultraImageMagic);

            int imageCount = brImages.ReadInt32();
            imageCount = ReverseBytes(imageCount);

            int numRows = brImages.ReadInt32();
            numRows = ReverseBytes(numRows);

            int numCols = brImages.ReadInt32();
            numCols = ReverseBytes(numCols);

            int ultraLabelMagic = brLabels.ReadInt32();
            ultraLabelMagic = ReverseBytes(ultraLabelMagic);

            int numLabels = brLabels.ReadInt32();
            numLabels = ReverseBytes(numLabels);

            byte[] pixels = new byte[784];
            string labelValue = null;

            for (int di = 0; di < nNext.Value; di++)
            {
                labelValue = brLabels.ReadByte().ToString();

                for (int i = 0; i < 784; i++)
                {
                    byte b = brImages.ReadByte();
                    pixels[i] = b;
                }
            }

            lblClass.Text = $"Цифра: {labelValue}";
            nClass.Value = Convert.ToDecimal(labelValue);

            Bitmap im = DataToBitmap(pixels);
            _currentBinaryMatrix = WorkingViaImage(im);
            picPreview.Image = im;

            // im.Save($"D:\\Users\\Downloads\\image{(int)numImage}.bmp");
            // System.IO.File.WriteAllText($"D:\\Users\\Downloads\\BinarizedMatrixOf{labelValue}.txt", _currentBinaryMatrix.ToString());

            ifsLabels.Close(); ifsPixels.Close();
            brLabels.Close(); brImages.Close();
        }

        private int CalculateStatistics(string labelValue, string predicted_value, int[] preditionNumberCounter, int[] preditionTrueCounter, int preditionTrueCount)
        {
            switch (labelValue)
            {
                case "0": preditionNumberCounter[0]++; break;
                case "1": preditionNumberCounter[1]++; break;
                case "2": preditionNumberCounter[2]++; break;
                case "3": preditionNumberCounter[3]++; break;
                case "4": preditionNumberCounter[4]++; break;
                case "5": preditionNumberCounter[5]++; break;
                case "6": preditionNumberCounter[6]++; break;
                case "7": preditionNumberCounter[7]++; break;
                case "8": preditionNumberCounter[8]++; break;
                case "9": preditionNumberCounter[9]++; break;
            }

            if (predicted_value == labelValue)
            {
                switch (predicted_value)
                {
                    case "0": preditionTrueCounter[0]++; break;
                    case "1": preditionTrueCounter[1]++; break;
                    case "2": preditionTrueCounter[2]++; break;
                    case "3": preditionTrueCounter[3]++; break;
                    case "4": preditionTrueCounter[4]++; break;
                    case "5": preditionTrueCounter[5]++; break;
                    case "6": preditionTrueCounter[6]++; break;
                    case "7": preditionTrueCounter[7]++; break;
                    case "8": preditionTrueCounter[8]++; break;
                    case "9": preditionTrueCounter[9]++; break;
                }

                preditionTrueCount++;
            }

            return (preditionTrueCount);
        }

        private Bitmap DataToBitmap(byte[] data)
        {
            Bitmap bmp = new Bitmap(28, 28, PixelFormat.Format8bppIndexed);
            // BlobCounter() can uses the following formats:
            // Format8bppIndexed
            // Format24bppRgb
            // Format32bppRgb

            BitmapData bmpData = bmp.LockBits(
                                 new Rectangle(0, 0, bmp.Width, bmp.Height),
                                 ImageLockMode.WriteOnly, bmp.PixelFormat);
            Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
            bmp.UnlockBits(bmpData);

            return bmp;
        }
    }
}