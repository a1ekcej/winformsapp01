namespace WindowsFormsApp1
{
    partial class AutorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.signInbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paswdfield = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInbtn
            // 
            this.signInbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.signInbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signInbtn.FlatAppearance.BorderSize = 3;
            this.signInbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.signInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInbtn.Font = new System.Drawing.Font("Noto Serif Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signInbtn.Location = new System.Drawing.Point(167, 367);
            this.signInbtn.Margin = new System.Windows.Forms.Padding(15);
            this.signInbtn.Name = "signInbtn";
            this.signInbtn.Size = new System.Drawing.Size(215, 50);
            this.signInbtn.TabIndex = 3;
            this.signInbtn.Text = "Войти";
            this.signInbtn.UseVisualStyleBackColor = false;
            this.signInbtn.Click += new System.EventHandler(this.signInbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.paswdfield);
            this.groupBox1.Controls.Add(this.loginfield);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.registerbtn);
            this.groupBox1.Controls.Add(this.signInbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 502);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // paswdfield
            // 
            this.paswdfield.Font = new System.Drawing.Font("Source Serif Pro", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paswdfield.Location = new System.Drawing.Point(167, 205);
            this.paswdfield.Multiline = true;
            this.paswdfield.Name = "paswdfield";
            this.paswdfield.PasswordChar = '*';
            this.paswdfield.PlaceholderText = "password";
            this.paswdfield.Size = new System.Drawing.Size(215, 64);
            this.paswdfield.TabIndex = 2;
            this.paswdfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginfield
            // 
            this.loginfield.Font = new System.Drawing.Font("Source Serif Pro", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginfield.Location = new System.Drawing.Point(167, 106);
            this.loginfield.Multiline = true;
            this.loginfield.Name = "loginfield";
            this.loginfield.PlaceholderText = "alexej";
            this.loginfield.Size = new System.Drawing.Size(215, 64);
            this.loginfield.TabIndex = 1;
            this.loginfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerbtn.FlatAppearance.BorderSize = 3;
            this.registerbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("Noto Serif Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerbtn.Location = new System.Drawing.Point(167, 434);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(15);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(215, 50);
            this.registerbtn.TabIndex = 4;
            this.registerbtn.Text = "Регистрирация";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // AutorizationForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";         
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button signInbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox paswdfield;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}