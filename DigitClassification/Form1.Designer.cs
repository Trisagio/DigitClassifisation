
namespace DigitClassification
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTextDistFunc = new System.Windows.Forms.Label();
            this.cDistanceBox = new System.Windows.Forms.ComboBox();
            this.nTestSet = new System.Windows.Forms.NumericUpDown();
            this.nTrainingSet = new System.Windows.Forms.NumericUpDown();
            this.lblTextTest = new System.Windows.Forms.Label();
            this.lblTextTraining = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btTRAINING = new System.Windows.Forms.Button();
            this.btnClearDataSet = new System.Windows.Forms.Button();
            this.lblTextNewClass = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.nClass = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btTEST = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.nNext = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.lbltext1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTestSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTrainingSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClass)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNext)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.nNext);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(594, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTextDistFunc);
            this.groupBox5.Controls.Add(this.cDistanceBox);
            this.groupBox5.Controls.Add(this.nTestSet);
            this.groupBox5.Controls.Add(this.nTrainingSet);
            this.groupBox5.Controls.Add(this.lblTextTest);
            this.groupBox5.Controls.Add(this.lblTextTraining);
            this.groupBox5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(0, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(546, 104);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметры";
            // 
            // lblTextDistFunc
            // 
            this.lblTextDistFunc.AutoSize = true;
            this.lblTextDistFunc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextDistFunc.Location = new System.Drawing.Point(317, 27);
            this.lblTextDistFunc.Name = "lblTextDistFunc";
            this.lblTextDistFunc.Size = new System.Drawing.Size(180, 22);
            this.lblTextDistFunc.TabIndex = 14;
            this.lblTextDistFunc.Text = "Используемая метрика:";
            // 
            // cDistanceBox
            // 
            this.cDistanceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDistanceBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cDistanceBox.FormattingEnabled = true;
            this.cDistanceBox.Items.AddRange(new object[] {
            "Евклидово расстояние",
            "Манхеттенское расстояние",
            "Расстояние Хэмминга",
            "Расстояние Рассела",
            "Расстояние Сёренсена"});
            this.cDistanceBox.Location = new System.Drawing.Point(321, 54);
            this.cDistanceBox.Name = "cDistanceBox";
            this.cDistanceBox.Size = new System.Drawing.Size(218, 30);
            this.cDistanceBox.TabIndex = 13;
            // 
            // nTestSet
            // 
            this.nTestSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTestSet.Location = new System.Drawing.Point(232, 64);
            this.nTestSet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nTestSet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTestSet.Name = "nTestSet";
            this.nTestSet.Size = new System.Drawing.Size(79, 22);
            this.nTestSet.TabIndex = 12;
            this.nTestSet.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nTrainingSet
            // 
            this.nTrainingSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTrainingSet.Location = new System.Drawing.Point(232, 32);
            this.nTrainingSet.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nTrainingSet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTrainingSet.Name = "nTrainingSet";
            this.nTrainingSet.Size = new System.Drawing.Size(79, 22);
            this.nTrainingSet.TabIndex = 11;
            this.nTrainingSet.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblTextTest
            // 
            this.lblTextTest.AutoSize = true;
            this.lblTextTest.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextTest.Location = new System.Drawing.Point(7, 62);
            this.lblTextTest.Name = "lblTextTest";
            this.lblTextTest.Size = new System.Drawing.Size(207, 22);
            this.lblTextTest.TabIndex = 9;
            this.lblTextTest.Text = "Кол-во цифр тест. выборки:";
            // 
            // lblTextTraining
            // 
            this.lblTextTraining.AutoSize = true;
            this.lblTextTraining.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextTraining.Location = new System.Drawing.Point(7, 29);
            this.lblTextTraining.Name = "lblTextTraining";
            this.lblTextTraining.Size = new System.Drawing.Size(209, 22);
            this.lblTextTraining.TabIndex = 8;
            this.lblTextTraining.Text = "Кол-во цифр обуч. выборки:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btTRAINING);
            this.groupBox3.Controls.Add(this.btnClearDataSet);
            this.groupBox3.Controls.Add(this.lblTextNewClass);
            this.groupBox3.Controls.Add(this.btnTrain);
            this.groupBox3.Controls.Add(this.nClass);
            this.groupBox3.Location = new System.Drawing.Point(368, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(233, 268);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обучение";
            // 
            // btTRAINING
            // 
            this.btTRAINING.BackColor = System.Drawing.SystemColors.Control;
            this.btTRAINING.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTRAINING.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTRAINING.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTRAINING.Location = new System.Drawing.Point(9, 94);
            this.btTRAINING.Name = "btTRAINING";
            this.btTRAINING.Size = new System.Drawing.Size(169, 56);
            this.btTRAINING.TabIndex = 8;
            this.btTRAINING.Text = "Провести кластеризацию";
            this.btTRAINING.UseVisualStyleBackColor = false;
            this.btTRAINING.Click += new System.EventHandler(this.btTRAINING_Click);
            // 
            // btnClearDataSet
            // 
            this.btnClearDataSet.Enabled = false;
            this.btnClearDataSet.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearDataSet.Location = new System.Drawing.Point(183, 25);
            this.btnClearDataSet.Name = "btnClearDataSet";
            this.btnClearDataSet.Size = new System.Drawing.Size(38, 211);
            this.btnClearDataSet.TabIndex = 10;
            this.btnClearDataSet.Text = "О\r\nЧ\r\nИ\r\nС\r\nТ\r\nК\r\nА";
            this.btnClearDataSet.UseVisualStyleBackColor = true;
            this.btnClearDataSet.Click += new System.EventHandler(this.btnClearDataSet_Click);
            // 
            // lblTextNewClass
            // 
            this.lblTextNewClass.AutoSize = true;
            this.lblTextNewClass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextNewClass.Location = new System.Drawing.Point(5, 25);
            this.lblTextNewClass.Name = "lblTextNewClass";
            this.lblTextNewClass.Size = new System.Drawing.Size(59, 22);
            this.lblTextNewClass.TabIndex = 8;
            this.lblTextNewClass.Text = "Число:";
            // 
            // btnTrain
            // 
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrain.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrain.Location = new System.Drawing.Point(9, 53);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(168, 36);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Добавить в набор";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // nClass
            // 
            this.nClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nClass.Location = new System.Drawing.Point(69, 27);
            this.nClass.Margin = new System.Windows.Forms.Padding(2);
            this.nClass.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nClass.Name = "nClass";
            this.nClass.Size = new System.Drawing.Size(109, 22);
            this.nClass.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPredict);
            this.groupBox6.Controls.Add(this.btTEST);
            this.groupBox6.Controls.Add(this.lblLabel);
            this.groupBox6.Controls.Add(this.lblClass);
            this.groupBox6.Location = new System.Drawing.Point(237, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(135, 176);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Распознавание";
            // 
            // btnPredict
            // 
            this.btnPredict.Enabled = false;
            this.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPredict.Location = new System.Drawing.Point(5, 25);
            this.btnPredict.Margin = new System.Windows.Forms.Padding(2);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(124, 29);
            this.btnPredict.TabIndex = 5;
            this.btnPredict.Text = "Распознать";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btTEST
            // 
            this.btTEST.BackColor = System.Drawing.Color.DarkGreen;
            this.btTEST.Enabled = false;
            this.btTEST.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTEST.ForeColor = System.Drawing.SystemColors.Window;
            this.btTEST.Location = new System.Drawing.Point(4, 100);
            this.btTEST.Name = "btTEST";
            this.btTEST.Size = new System.Drawing.Size(122, 50);
            this.btTEST.TabIndex = 9;
            this.btTEST.Text = "ТЕСТ";
            this.btTEST.UseVisualStyleBackColor = false;
            this.btTEST.Click += new System.EventHandler(this.btTEST_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLabel.Location = new System.Drawing.Point(5, 53);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(86, 22);
            this.lblLabel.TabIndex = 4;
            this.lblLabel.Text = "Результат:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClass.Location = new System.Drawing.Point(5, 75);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(65, 22);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "Цифра:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picPreview);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(99, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(138, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изображение";
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.White;
            this.picPreview.Location = new System.Drawing.Point(5, 22);
            this.picPreview.Margin = new System.Windows.Forms.Padding(2);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(128, 128);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(6, 86);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 27);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.Location = new System.Drawing.Point(6, 53);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 27);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Перейти";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // nNext
            // 
            this.nNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nNext.Location = new System.Drawing.Point(6, 25);
            this.nNext.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nNext.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNext.Name = "nNext";
            this.nNext.Size = new System.Drawing.Size(87, 22);
            this.nNext.TabIndex = 1;
            this.nNext.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(6, 119);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 27);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Дальше";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(6, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 54);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "СБРОС";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTime);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label0);
            this.groupBox4.Controls.Add(this.lblCounter);
            this.groupBox4.Controls.Add(this.lblTrue);
            this.groupBox4.Controls.Add(this.lbltext1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 110);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Статистика";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(415, 75);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(173, 26);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Время: 00:00:00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(490, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "9 (0)%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(396, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "8 (0)%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(301, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "7 (0)%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(206, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "6 (0)%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(114, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "5 (0)%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(490, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "4 (0)%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(396, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "3 (0)%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(301, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "2 (0)%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "1 (0)%";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label0.Location = new System.Drawing.Point(114, 24);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(58, 23);
            this.label0.TabIndex = 18;
            this.label0.Text = "0 (0)%";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(113, 75);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(51, 26);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "Из 0";
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Location = new System.Drawing.Point(241, 75);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(96, 26);
            this.lblTrue.TabIndex = 5;
            this.lblTrue.Text = "Всего: 0%";
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.Location = new System.Drawing.Point(6, 24);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(97, 26);
            this.lbltext1.TabIndex = 7;
            this.lbltext1.Text = "Точность:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 352);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recognizer 9000";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTestSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTrainingSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClass)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNext)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.NumericUpDown nClass;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nNext;
        private System.Windows.Forms.Button btTRAINING;
        private System.Windows.Forms.Button btTEST;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbltext1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTextTraining;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nTestSet;
        private System.Windows.Forms.NumericUpDown nTrainingSet;
        private System.Windows.Forms.Label lblTextTest;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTextNewClass;
        private System.Windows.Forms.Button btnClearDataSet;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTextDistFunc;
        private System.Windows.Forms.ComboBox cDistanceBox;
    }
}

