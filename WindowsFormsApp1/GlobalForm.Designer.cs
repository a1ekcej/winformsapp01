namespace WindowsFormsApp1
{
    partial class GlobalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalForm));
            this.addUnit = new System.Windows.Forms.Button();
            this.remoteUnit = new System.Windows.Forms.Button();
            this.saveDB = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listViewElemDB = new System.Windows.Forms.ListView();
            this.column_Status = new System.Windows.Forms.ColumnHeader();
            this.column_FIO = new System.Windows.Forms.ColumnHeader();
            this.Column_Home = new System.Windows.Forms.ColumnHeader();
            this.column_Cash = new System.Windows.Forms.ColumnHeader();
            this.column_telnumb1 = new System.Windows.Forms.ColumnHeader();
            this.column_telnumb2 = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TXTloginUser = new System.Windows.Forms.Label();
            this.textFIO = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUnit
            // 
            this.addUnit.BackColor = System.Drawing.Color.SkyBlue;
            this.addUnit.FlatAppearance.BorderSize = 3;
            this.addUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUnit.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addUnit.Location = new System.Drawing.Point(28, 35);
            this.addUnit.Name = "addUnit";
            this.addUnit.Size = new System.Drawing.Size(156, 30);
            this.addUnit.TabIndex = 0;
            this.addUnit.Text = "Новые данные";
            this.addUnit.UseVisualStyleBackColor = false;
            this.addUnit.Click += new System.EventHandler(this.addUnit_Click);
            // 
            // remoteUnit
            // 
            this.remoteUnit.BackColor = System.Drawing.Color.SkyBlue;
            this.remoteUnit.FlatAppearance.BorderSize = 3;
            this.remoteUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.remoteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remoteUnit.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.remoteUnit.Location = new System.Drawing.Point(28, 71);
            this.remoteUnit.Name = "remoteUnit";
            this.remoteUnit.Size = new System.Drawing.Size(156, 30);
            this.remoteUnit.TabIndex = 1;
            this.remoteUnit.Text = "Удалить";
            this.remoteUnit.UseVisualStyleBackColor = false;
            // 
            // saveDB
            // 
            this.saveDB.BackColor = System.Drawing.Color.SkyBlue;
            this.saveDB.FlatAppearance.BorderSize = 3;
            this.saveDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.saveDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDB.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.saveDB.Location = new System.Drawing.Point(28, 107);
            this.saveDB.Name = "saveDB";
            this.saveDB.Size = new System.Drawing.Size(156, 30);
            this.saveDB.TabIndex = 2;
            this.saveDB.Text = "Сохранить";
            this.saveDB.UseVisualStyleBackColor = false;
            // 
            // exitApp
            // 
            this.exitApp.BackColor = System.Drawing.Color.SkyBlue;
            this.exitApp.FlatAppearance.BorderSize = 3;
            this.exitApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApp.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exitApp.Location = new System.Drawing.Point(28, 143);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(156, 30);
            this.exitApp.TabIndex = 2;
            this.exitApp.Text = "Выход";
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Иванов";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "8(900) -111-11-11";
            this.textBox2.Size = new System.Drawing.Size(152, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "as*****g@mail.ru";
            this.textBox3.Size = new System.Drawing.Size(147, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Контактный телефон №1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Электронная почта";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(222, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Иван";
            this.textBox4.Size = new System.Drawing.Size(183, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(430, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Петрович";
            this.textBox5.Size = new System.Drawing.Size(183, 23);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(294, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "*Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(489, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "*Отчество";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 306);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox4.Location = new System.Drawing.Point(6, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 200);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Контакты";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Контактный телефон №2";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(6, 96);
            this.textBox13.Name = "textBox13";
            this.textBox13.PlaceholderText = "8(900) -111-11-11";
            this.textBox13.Size = new System.Drawing.Size(152, 23);
            this.textBox13.TabIndex = 4;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(213, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 200);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные по аренде";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Залог";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(6, 156);
            this.textBox12.Name = "textBox12";
            this.textBox12.PlaceholderText = "10000";
            this.textBox12.Size = new System.Drawing.Size(168, 23);
            this.textBox12.TabIndex = 4;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 96);
            this.textBox9.Name = "textBox9";
            this.textBox9.PlaceholderText = "10000";
            this.textBox9.Size = new System.Drawing.Size(168, 23);
            this.textBox9.TabIndex = 4;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "*Стоимость аренды (руб/мес)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "*Дата заселения";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(6, 37);
            this.textBox11.Name = "textBox11";
            this.textBox11.PlaceholderText = "09.09.2020";
            this.textBox11.Size = new System.Drawing.Size(98, 23);
            this.textBox11.TabIndex = 4;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(420, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Паспортные данные";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.textBox10);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Location = new System.Drawing.Point(6, 66);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 122);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Прописка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "*Адресс (улица/дом/квартира)";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(6, 93);
            this.textBox10.Name = "textBox10";
            this.textBox10.PlaceholderText = "ул. Ивановская, 36";
            this.textBox10.Size = new System.Drawing.Size(159, 23);
            this.textBox10.TabIndex = 4;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "*Населенный пункт";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "г. Иваново";
            this.textBox8.Size = new System.Drawing.Size(159, 23);
            this.textBox8.TabIndex = 4;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(59, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "999999";
            this.textBox7.Size = new System.Drawing.Size(91, 23);
            this.textBox7.TabIndex = 4;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "*Серия и номер паспорта";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "9999";
            this.textBox6.Size = new System.Drawing.Size(47, 23);
            this.textBox6.TabIndex = 4;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewElemDB
            // 
            this.listViewElemDB.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewElemDB.AllowColumnReorder = true;
            this.listViewElemDB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewElemDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Status,
            this.column_FIO,
            this.Column_Home,
            this.column_Cash,
            this.column_telnumb1,
            this.column_telnumb2});
            this.listViewElemDB.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewElemDB.FullRowSelect = true;
            this.listViewElemDB.GridLines = true;
            this.listViewElemDB.HideSelection = false;
            this.listViewElemDB.Location = new System.Drawing.Point(16, 376);
            this.listViewElemDB.Name = "listViewElemDB";
            this.listViewElemDB.Size = new System.Drawing.Size(628, 198);
            this.listViewElemDB.TabIndex = 9;
            this.listViewElemDB.UseCompatibleStateImageBehavior = false;
            this.listViewElemDB.View = System.Windows.Forms.View.Details;
            // 
            // column_Status
            // 
            this.column_Status.Text = "Статус";
            this.column_Status.Width = 80;
            // 
            // column_FIO
            // 
            this.column_FIO.Name = "column_FIO";
            this.column_FIO.Tag = "1";
            this.column_FIO.Text = "ФИО";
            this.column_FIO.Width = 150;
            // 
            // Column_Home
            // 
            this.Column_Home.Name = "Column_Home";
            this.Column_Home.Text = "Арендует";
            this.Column_Home.Width = 150;
            // 
            // column_Cash
            // 
            this.column_Cash.Name = "column_Cash";
            this.column_Cash.Text = "Платит";
            this.column_Cash.Width = 100;
            // 
            // column_telnumb1
            // 
            this.column_telnumb1.Name = "column_telnumb1";
            this.column_telnumb1.Text = "Телефон №1";
            this.column_telnumb1.Width = 112;
            // 
            // column_telnumb2
            // 
            this.column_telnumb2.Name = "column_telnumb2";
            this.column_telnumb2.Text = "Телефон №2";
            this.column_telnumb2.Width = 112;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(16, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(628, 58);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Выберите объект:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "г. Воронеж, Владимира Невского 19",
            "г. Воронеж, 60 Армии 29А",
            "г. Воронеж, Курчатова 36А",
            "г. Воронеж, Олимпийский 11"});
            this.comboBox1.Location = new System.Drawing.Point(150, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(471, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.exitApp);
            this.groupBox7.Controls.Add(this.addUnit);
            this.groupBox7.Controls.Add(this.remoteUnit);
            this.groupBox7.Controls.Add(this.saveDB);
            this.groupBox7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(655, 376);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(210, 196);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.TXTloginUser);
            this.groupBox8.Controls.Add(this.textFIO);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox8.Location = new System.Drawing.Point(655, 64);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(210, 137);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(75, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "users";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(5, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "login:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTloginUser
            // 
            this.TXTloginUser.BackColor = System.Drawing.Color.White;
            this.TXTloginUser.Location = new System.Drawing.Point(75, 45);
            this.TXTloginUser.Name = "TXTloginUser";
            this.TXTloginUser.Size = new System.Drawing.Size(130, 16);
            this.TXTloginUser.TabIndex = 8;
            this.TXTloginUser.Text = "users";
            this.TXTloginUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFIO
            // 
            this.textFIO.AutoSize = true;
            this.textFIO.Location = new System.Drawing.Point(48, 73);
            this.textFIO.Name = "textFIO";
            this.textFIO.Size = new System.Drawing.Size(0, 16);
            this.textFIO.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(49, 73);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 16);
            this.label18.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(101, 19);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(5, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "ФИО:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(5, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Вы вошли как:";
            // 
            // GlobalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 587);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.listViewElemDB);
            this.Controls.Add(this.groupBox1);
            this.Name = "GlobalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUnit;
        private System.Windows.Forms.Button remoteUnit;
        private System.Windows.Forms.Button saveDB;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox12;
     
        private System.Windows.Forms.ListView listViewElemDB;
        private System.Windows.Forms.ColumnHeader Column_Home;
        private System.Windows.Forms.ColumnHeader column_Cash;
        private System.Windows.Forms.ColumnHeader column_telnumb1;
        public System.Windows.Forms.ColumnHeader column_FIO;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader column_telnumb2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label textFIO;
        private System.Windows.Forms.Label TXTloginUser;
        private System.Windows.Forms.ColumnHeader column_Status;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
    }
}

