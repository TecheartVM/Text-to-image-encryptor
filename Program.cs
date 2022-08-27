using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Encryptor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void TextToImage(String text, String imgPath, String newPath)
        {
            Bitmap img = new Bitmap(imgPath);
            char[] chars = text.ToCharArray();
            int x = 0, y = 0;
            foreach(char c in chars)
            {
                Color newColor = Encrypt(c, img.GetPixel(x, y));
                img.SetPixel(x, y, newColor);
                if (x < img.Width) x++;
                else
                {
                    if (y >= img.Height) break;
                    x = 0;
                    y++;
                }
            }
            img.SetPixel(x, y, Encrypt((char)0, img.GetPixel(x, y)));
            if(newPath == imgPath)
            {
                newPath += "_";
            }
            img.Save(newPath, ImageFormat.Bmp);
        }

        public static String ImageToText(String imgPath)
        {
            String result = "";
            Bitmap img = new Bitmap(imgPath);
            for(int y = 0;  y < img.Height; y++)
            {
                for (int x = 0; x <= img.Width; x++)
                {
                    if (x < img.Width)
                    {
                        char c = Decrypt(img.GetPixel(x, y));
                        if ((char)c == (char)0) return result;
                        result += c;
                    }
                    else
                    {
                        x = 0;
                        break;
                    }
                }
            }

            return result;
        }

        static Color Encrypt(char ch, Color c)
        {
            int i = c.ToArgb();
            byte j = Encoding.ASCII.GetBytes(ch.ToString())[0];
            int n = i & 0xF80000;       //clear last 3 bits
            n |= (j & 0xE0) << 11;   //add char first 3 bits to last 3 bits in color code
            n |= i & (0x3F << 10);
            n |= (j & 0x18) << 5;    //add char 00011000 bits to color code
            n |= i & (0x1F << 3);
            n |= j & 0x7;

            Color result = Color.FromArgb(255, Color.FromArgb(n));

            return result;
        }

        static char Decrypt(Color c)
        {
            int result = 0;
            int cv = c.ToArgb();
            result |= (cv & 0x70000) >> 11;
            result |= (cv & 0x300) >> 5;
            result |= (cv & 0x7);

            return (char)result;
        }
    }
}
