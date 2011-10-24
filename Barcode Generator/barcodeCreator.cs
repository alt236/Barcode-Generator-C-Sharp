using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Imaging;
using MessagingToolkit.Barcode.Multi;
using MessagingToolkit.Barcode;
using MessagingToolkit.Barcode.Common;

namespace BarcodeGenerator
{
    class barcodeCreator
    {
        private MultiFormatReader barcodeReader;
        private MultiFormatWriter barcodeWriter;

        public barcodeCreator()
        {
        barcodeReader = new MultiFormatReader();
        barcodeWriter = new MultiFormatWriter();
        }

        public Bitmap createBarcode(String barcodeText, BarcodeFormat barcodeFormat, int width, int height)
        {

            if (!string.IsNullOrEmpty(barcodeText))
            {
                try
                {
                  ByteMatrix bt = barcodeWriter.Encode(barcodeText, barcodeFormat, width, height);
                  return ConvertByteMatrixToImage(bt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }




        private unsafe Bitmap ConvertByteMatrixToImage(ByteMatrix bm)
        {
            Bitmap image = CreateGrayscaleImage(bm.Width, bm.Height);
            BitmapData sourceData;

            sourceData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
            int width = sourceData.Width;
            int height = sourceData.Height;
            int srcOffset = sourceData.Stride - width;
            byte* src = (byte*)sourceData.Scan0.ToPointer();
            for (int y = 0; y < height; y++)
            {
                // for each pixel
                for (int x = 0; x < width; x++, src++)
                {
                    *src = (byte)bm.Array[y][x];
                }
                src += srcOffset;
            }

            image.UnlockBits(sourceData);
            return image;
        }

        private static Bitmap CreateGrayscaleImage(int width, int height)
        {
            // create new image
            Bitmap image = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            // set palette to grayscale
            // get palette
            ColorPalette cp = image.Palette;
            // init palette
            for (int i = 0; i < 256; i++)
            {
                cp.Entries[i] = Color.FromArgb(i, i, i);
            }
            // set palette back
            image.Palette = cp;
            // return new image
            return image;
        }
    }
}
