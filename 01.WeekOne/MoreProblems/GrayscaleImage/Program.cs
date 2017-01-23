using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrayscaleImage
{
    class Program
    {
        public static void GreyScaleImage(Bitmap bitmap, string savePath)
        {
            Bitmap newBitmap = (Bitmap)bitmap.Clone();

            for (int i = 0; i < newBitmap.Width; i++)
            {
                for (int j = 0; j < newBitmap.Height; j++)
                {
                    Color pixel = newBitmap.GetPixel(i, j);
                    int scale = (int)(0.33 * pixel.R + 0.33 * pixel.G + 0.33 * pixel.B);
                    pixel = Color.FromArgb(scale, scale, scale);
                    newBitmap.SetPixel(i, j, pixel);
                }
            }

            newBitmap.Save(savePath);
        }

        static void Main()
        {
            Bitmap img = (Bitmap)Image.FromFile("snimka.bmp");
            
            GreyScaleImage(img, "gray.bmp");
        }
    }
}
