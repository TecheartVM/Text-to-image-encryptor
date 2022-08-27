namespace Encryptor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMainIO = new System.Windows.Forms.TextBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.imgCurrrentImage = new System.Windows.Forms.PictureBox();
            this.dlgImagePath = new System.Windows.Forms.OpenFileDialog();
            this.dlgPickFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainIO
            // 
            this.txtMainIO.Location = new System.Drawing.Point(12, 133);
            this.txtMainIO.Multiline = true;
            this.txtMainIO.Name = "txtMainIO";
            this.txtMainIO.Size = new System.Drawing.Size(451, 158);
            this.txtMainIO.TabIndex = 0;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(12, 12);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(94, 31);
            this.btnSelectImg.TabIndex = 1;
            this.btnSelectImg.Text = "Select Image";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 49);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 31);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(12, 86);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 31);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblImagePath.Location = new System.Drawing.Point(112, 21);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(240, 13);
            this.lblImagePath.TabIndex = 4;
            this.lblImagePath.Text = "None";
            this.lblImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblImagePath.Click += new System.EventHandler(this.lblImagePath_Click);
            // 
            // imgCurrrentImage
            // 
            this.imgCurrrentImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imgCurrrentImage.Location = new System.Drawing.Point(358, 12);
            this.imgCurrrentImage.Name = "imgCurrrentImage";
            this.imgCurrrentImage.Size = new System.Drawing.Size(105, 105);
            this.imgCurrrentImage.TabIndex = 5;
            this.imgCurrrentImage.TabStop = false;
            // 
            // dlgImagePath
            // 
            this.dlgImagePath.FileName = "init.jpg";
            this.dlgImagePath.InitialDirectory = "c:\\\\";
            this.dlgImagePath.Title = "Select Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 303);
            this.Controls.Add(this.imgCurrrentImage);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.txtMainIO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrrentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainIO;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.PictureBox imgCurrrentImage;
        private System.Windows.Forms.OpenFileDialog dlgImagePath;
        private System.Windows.Forms.FolderBrowserDialog dlgPickFolder;
    }
}

