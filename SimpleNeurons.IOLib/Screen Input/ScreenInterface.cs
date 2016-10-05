using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SimpleNeurons.IOLib
{
    public static class ScreenInterface
    {
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        private static extern int BitBlt(IntPtr hDc, int x, int y, int nWidth, int nHeight, IntPtr hSrcDc, int xSrc, int ySrc, int dwRop);

        private static readonly Bitmap ScreenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public static Color GetColorAt(Point location)
        {
            using (Graphics gDest = Graphics.FromImage(ScreenPixel))
            {
                using (Graphics gSrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDc = gSrc.GetHdc();
                    IntPtr hDc = gDest.GetHdc();
                    int retval = BitBlt(hDc, 0, 0, 1, 1, hSrcDc, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gDest.ReleaseHdc();
                    gSrc.ReleaseHdc();
                }
            }

            return ScreenPixel.GetPixel(0, 0);
        }
    }
}
