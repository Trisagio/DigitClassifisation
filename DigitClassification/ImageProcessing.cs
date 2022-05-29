using System;
using System.Drawing;
using System.Drawing.Drawing2D;

using Accord.Imaging;
using Accord.Imaging.Filters;

namespace DigitClassification
{
    internal class ImageProcessing
    {
        private Bitmap _image;
        public Bitmap Image { get => _image; }

        public ImageProcessing(Bitmap image)
            => _image = image;

        internal Rectangle DetectBlob()
        {
            // Blob-analysis method
            BlobCounter bc = new BlobCounter();
            bc.ProcessImage(_image);

            int x = int.MaxValue, y = int.MaxValue,
            width = 0, height = 0;
            var blobs = bc.GetObjectsRectangles();

            foreach(var rect in blobs)
            {
                if (rect.X < x) x = rect.X;
                if (rect.Y < y) y = rect.Y;
                if (rect.X + rect.Width > width)
                    width = rect.X + rect.Width;
                if (rect.Y + rect.Height > height)
                    height = rect.Y + rect.Height;
            }
            width = width - x;
            height = height - y;

            return new Rectangle(x, y, width, height);
        }

        internal ImageProcessing CropBlob()
        {
            var rectangle = DetectBlob();

            Crop filter = new Crop(rectangle);
            _image = filter.Apply(_image);

            return this;
        }

        internal ImageProcessing Invert()
        {
            Invert invertFilter = new Invert();
            invertFilter.ApplyInPlace(_image);

            return this;
        }

        internal ImageProcessing Binarize(int threshold)
        {
            Threshold filter = new Threshold(threshold);
            filter.ApplyInPlace(_image);

            return this;
        }
    }
}