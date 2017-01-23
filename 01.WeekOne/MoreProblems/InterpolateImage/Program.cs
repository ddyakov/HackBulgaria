using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InterpolateImage
{
    class Program
    {
        public static void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
        {
            Bitmap newBitmap = new Bitmap(newSize.Width, newSize.Height);

            float factorX = (float)(newBitmap.Width-1) / (bitmap.Width-1);
            float factorY = (float)(newBitmap.Height-1) / (bitmap.Height-1);

            for (int i = 0; i < newBitmap.Width; i++)
            {
                for (int j = 0; j < newBitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel((int)Math.Round((float)(i/factorX)),
                        (int)Math.Round((float)j/factorY));
                    newBitmap.SetPixel(i, j, pixel);
                }
            }

            newBitmap.Save(savePath);
        }

        static void Main()
        {
            Bitmap inputImage = (Bitmap)Image.FromFile("snimka.bmp");
            Size size = new Size(500, 500);

            ResampleImage(inputImage, size, "resized.bmp");
        }
    }
}
