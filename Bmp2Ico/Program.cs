using System;
using System.Drawing;
using System.IO;

namespace Bmp2Ico
{
    internal class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        extern static bool DestroyIcon(IntPtr handle);

        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string filepath = args[0];

                Bitmap bmp = new Bitmap(filepath);
                IntPtr hicon = bmp.GetHicon();

                Icon icon = Icon.FromHandle(hicon);

                FileStream fileStream = new FileStream(Path.ChangeExtension(filepath, ".ico"), FileMode.OpenOrCreate);
                icon.Save(fileStream);

                fileStream.Close();
                DestroyIcon(hicon);

                fileStream.Close();
                fileStream.Dispose();
            }
        }
    }
}
