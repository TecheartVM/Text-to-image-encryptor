using System;
using System.Drawing;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        private String currentPath = "c:\\";
        private String dialogFilterImages = "Image Files(*.JPG)|*.JPG";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dlgImagePath.Filter = dialogFilterImages;
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            DialogResult dialog = dlgImagePath.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                currentPath = dlgImagePath.FileName;
                showImage(currentPath);
                lblImagePath.Text = currentPath;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            String curText = txtMainIO.Text;
            if(curText != null && curText.Length > 0)
            {
                DialogResult dialog = dlgPickFolder.ShowDialog();
                if(dialog == DialogResult.OK)
                {
                    Program.TextToImage(curText, currentPath, dlgPickFolder.SelectedPath + "\\output.jpg");
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            String result = Program.ImageToText(currentPath);
            if (result != null && result.Length > 0)
            {
                txtMainIO.Text = result;
            }
        }

        private void lblImagePath_Click(object sender, EventArgs e)
        {
            
        }

        private void showImage(String filePath)
        {
            Bitmap img = new Bitmap(filePath);
            imgCurrrentImage.Image = (Image)img;
        }
    }
}
