using System;

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
            this.addObject = new System.Windows.Forms.Button();
            this.remoteUnit = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.listViewElemDB = new System.Windows.Forms.ListView();
            this.column_Status = new System.Windows.Forms.ColumnHeader();
            this.column_FIO = new System.Windows.Forms.ColumnHeader();
            this.Column_Home = new System.Windows.Forms.ColumnHeader();
            this.column_Cash = new System.Windows.Forms.ColumnHeader();
            this.column_telnumb1 = new System.Windows.Forms.ColumnHeader();
            this.column_telnumb2 = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxObjects = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.addTenant = new System.Windows.Forms.Button();
            this.gbLog_In = new System.Windows.Forms.GroupBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textFIO = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbObjectsothersValues = new System.Windows.Forms.GroupBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxRoomNum = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.gbObjectsValue = new System.Windows.Forms.GroupBox();
            this.textBoxApartamentNum = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxHouseNum = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPhone2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone1 = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPleadge = new System.Windows.Forms.TextBox();
            this.tbRent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLeaseDate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbpaspNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpaspSeries = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbObjectArenda = new System.Windows.Forms.TextBox();
            this.tbfirstName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbthirdName = new System.Windows.Forms.TextBox();
            this.tblastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbLog_In.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbObjectsothersValues.SuspendLayout();
            this.gbObjectsValue.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addObject
            // 
            this.addObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addObject.BackColor = System.Drawing.Color.SkyBlue;
            this.addObject.FlatAppearance.BorderSize = 3;
            this.addObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addObject.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addObject.Location = new System.Drawing.Point(10, 72);
            this.addObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(291, 50);
            this.addObject.TabIndex = 0;
            this.addObject.Text = "Добавить объект";
            this.addObject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addObject.UseVisualStyleBackColor = false;
            this.addObject.Click += new System.EventHandler(this.addUnit_Click);
            // 
            // remoteUnit
            // 
            this.remoteUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteUnit.BackColor = System.Drawing.Color.SkyBlue;
            this.remoteUnit.FlatAppearance.BorderSize = 3;
            this.remoteUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.remoteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remoteUnit.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.remoteUnit.Location = new System.Drawing.Point(10, 213);
            this.remoteUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remoteUnit.Name = "remoteUnit";
            this.remoteUnit.Size = new System.Drawing.Size(291, 50);
            this.remoteUnit.TabIndex = 1;
            this.remoteUnit.Text = "Удалить";
            this.remoteUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.remoteUnit.UseVisualStyleBackColor = false;
            // 
            // exitApp
            // 
            this.exitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitApp.BackColor = System.Drawing.Color.SkyBlue;
            this.exitApp.FlatAppearance.BorderSize = 3;
            this.exitApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApp.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exitApp.Location = new System.Drawing.Point(10, 275);
            this.exitApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(291, 50);
            this.exitApp.TabIndex = 2;
            this.exitApp.Text = "Выход";
            this.exitApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
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
            this.listViewElemDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewElemDB.FullRowSelect = true;
            this.listViewElemDB.GridLines = true;
            this.listViewElemDB.HideSelection = false;
            this.listViewElemDB.Location = new System.Drawing.Point(17, 647);
            this.listViewElemDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewElemDB.Name = "listViewElemDB";
            this.listViewElemDB.Size = new System.Drawing.Size(1297, 364);
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
            this.groupBox5.Controls.Add(this.comboBoxObjects);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(17, 8);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(939, 67);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Выберите объект:";
            // 
            // comboBoxObjects
            // 
            this.comboBoxObjects.FormattingEnabled = true;
            this.comboBoxObjects.Location = new System.Drawing.Point(214, 18);
            this.comboBoxObjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxObjects.Name = "comboBoxObjects";
            this.comboBoxObjects.Size = new System.Drawing.Size(715, 33);
            this.comboBoxObjects.TabIndex = 0;
            this.comboBoxObjects.SelectionChangeCommitted += new System.EventHandler(this.comboBoxObjects_SelectionChangeCommitted);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox7.Controls.Add(this.addTenant);
            this.groupBox7.Controls.Add(this.exitApp);
            this.groupBox7.Controls.Add(this.addObject);
            this.groupBox7.Controls.Add(this.remoteUnit);
            this.groupBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(1004, 290);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox7.Size = new System.Drawing.Size(311, 335);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            // 
            // addTenant
            // 
            this.addTenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTenant.BackColor = System.Drawing.Color.SkyBlue;
            this.addTenant.FlatAppearance.BorderSize = 3;
            this.addTenant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTenant.Font = new System.Drawing.Font("Noto Serif Cond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addTenant.Location = new System.Drawing.Point(10, 145);
            this.addTenant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTenant.Name = "addTenant";
            this.addTenant.Size = new System.Drawing.Size(291, 50);
            this.addTenant.TabIndex = 3;
            this.addTenant.Text = "Добавить жильца";
            this.addTenant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTenant.UseVisualStyleBackColor = false;
            this.addTenant.Click += new System.EventHandler(this.addTenant_Click);
            // 
            // gbLog_In
            // 
            this.gbLog_In.BackColor = System.Drawing.Color.Transparent;
            this.gbLog_In.Controls.Add(this.textBoxRole);
            this.gbLog_In.Controls.Add(this.textBoxLogin);
            this.gbLog_In.Controls.Add(this.label19);
            this.gbLog_In.Controls.Add(this.textFIO);
            this.gbLog_In.Controls.Add(this.label18);
            this.gbLog_In.Controls.Add(this.label17);
            this.gbLog_In.Controls.Add(this.label16);
            this.gbLog_In.Controls.Add(this.label14);
            this.gbLog_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLog_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbLog_In.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbLog_In.Location = new System.Drawing.Point(1004, 55);
            this.gbLog_In.Name = "gbLog_In";
            this.gbLog_In.Size = new System.Drawing.Size(311, 228);
            this.gbLog_In.TabIndex = 12;
            this.gbLog_In.TabStop = false;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(103, 135);
            this.textBoxRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.PlaceholderText = "role";
            this.textBoxRole.Size = new System.Drawing.Size(184, 30);
            this.textBoxRole.TabIndex = 11;
            this.textBoxRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(103, 68);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PlaceholderText = "login";
            this.textBoxLogin.Size = new System.Drawing.Size(184, 30);
            this.textBoxLogin.TabIndex = 10;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(7, 142);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 27);
            this.label19.TabIndex = 9;
            this.label19.Text = "role:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFIO
            // 
            this.textFIO.AutoSize = true;
            this.textFIO.Location = new System.Drawing.Point(69, 122);
            this.textFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textFIO.Name = "textFIO";
            this.textFIO.Size = new System.Drawing.Size(0, 25);
            this.textFIO.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(70, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 25);
            this.label18.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(144, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 25);
            this.label17.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(7, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 27);
            this.label16.TabIndex = 5;
            this.label16.Text = "login:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(7, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 22);
            this.label14.TabIndex = 5;
            this.label14.Text = "Вы вошли как:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(17, 87);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(939, 550);
            this.tabControl.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.gbObjectsothersValues);
            this.tabPage1.Controls.Add(this.gbObjectsValue);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(931, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Объекты";
            // 
            // gbObjectsothersValues
            // 
            this.gbObjectsothersValues.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbObjectsothersValues.Controls.Add(this.textBoxOwner);
            this.gbObjectsothersValues.Controls.Add(this.label24);
            this.gbObjectsothersValues.Controls.Add(this.textBoxFloor);
            this.gbObjectsothersValues.Controls.Add(this.label25);
            this.gbObjectsothersValues.Controls.Add(this.textBoxRoomNum);
            this.gbObjectsothersValues.Controls.Add(this.label26);
            this.gbObjectsothersValues.Controls.Add(this.textBoxArea);
            this.gbObjectsothersValues.Controls.Add(this.label27);
            this.gbObjectsothersValues.Location = new System.Drawing.Point(451, 22);
            this.gbObjectsothersValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbObjectsothersValues.Name = "gbObjectsothersValues";
            this.gbObjectsothersValues.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbObjectsothersValues.Size = new System.Drawing.Size(464, 467);
            this.gbObjectsothersValues.TabIndex = 27;
            this.gbObjectsothersValues.TabStop = false;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(236, 322);
            this.textBoxOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.PlaceholderText = "Иванов";
            this.textBoxOwner.Size = new System.Drawing.Size(183, 31);
            this.textBoxOwner.TabIndex = 8;
            this.textBoxOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(11, 327);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 24);
            this.label24.TabIndex = 27;
            this.label24.Text = "Собственник";
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(236, 230);
            this.textBoxFloor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(183, 31);
            this.textBoxFloor.TabIndex = 7;
            this.textBoxFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(11, 235);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 24);
            this.label25.TabIndex = 25;
            this.label25.Text = "Этаж";
            // 
            // textBoxRoomNum
            // 
            this.textBoxRoomNum.Location = new System.Drawing.Point(236, 137);
            this.textBoxRoomNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRoomNum.Name = "textBoxRoomNum";
            this.textBoxRoomNum.Size = new System.Drawing.Size(183, 31);
            this.textBoxRoomNum.TabIndex = 6;
            this.textBoxRoomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(11, 142);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(175, 24);
            this.label26.TabIndex = 23;
            this.label26.Text = "Количество комнат";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(236, 47);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(183, 31);
            this.textBoxArea.TabIndex = 5;
            this.textBoxArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(11, 52);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 24);
            this.label27.TabIndex = 21;
            this.label27.Text = "Площадь";
            // 
            // gbObjectsValue
            // 
            this.gbObjectsValue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbObjectsValue.Controls.Add(this.textBoxApartamentNum);
            this.gbObjectsValue.Controls.Add(this.label22);
            this.gbObjectsValue.Controls.Add(this.textBoxHouseNum);
            this.gbObjectsValue.Controls.Add(this.label21);
            this.gbObjectsValue.Controls.Add(this.textBoxStreet);
            this.gbObjectsValue.Controls.Add(this.label20);
            this.gbObjectsValue.Controls.Add(this.textBoxCity);
            this.gbObjectsValue.Controls.Add(this.label23);
            this.gbObjectsValue.Location = new System.Drawing.Point(11, 22);
            this.gbObjectsValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbObjectsValue.Name = "gbObjectsValue";
            this.gbObjectsValue.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbObjectsValue.Size = new System.Drawing.Size(431, 467);
            this.gbObjectsValue.TabIndex = 26;
            this.gbObjectsValue.TabStop = false;
            // 
            // textBoxApartamentNum
            // 
            this.textBoxApartamentNum.Location = new System.Drawing.Point(159, 322);
            this.textBoxApartamentNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxApartamentNum.Name = "textBoxApartamentNum";
            this.textBoxApartamentNum.Size = new System.Drawing.Size(260, 31);
            this.textBoxApartamentNum.TabIndex = 4;
            this.textBoxApartamentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(11, 327);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 24);
            this.label22.TabIndex = 27;
            this.label22.Text = "*Квартира";
            // 
            // textBoxHouseNum
            // 
            this.textBoxHouseNum.Location = new System.Drawing.Point(159, 230);
            this.textBoxHouseNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHouseNum.Name = "textBoxHouseNum";
            this.textBoxHouseNum.Size = new System.Drawing.Size(260, 31);
            this.textBoxHouseNum.TabIndex = 3;
            this.textBoxHouseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(11, 235);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 24);
            this.label21.TabIndex = 25;
            this.label21.Text = "*Дом";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(159, 137);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.PlaceholderText = "Бульвар Победы";
            this.textBoxStreet.Size = new System.Drawing.Size(260, 31);
            this.textBoxStreet.TabIndex = 2;
            this.textBoxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(11, 142);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 24);
            this.label20.TabIndex = 23;
            this.label20.Text = "*Улица";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(159, 47);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.PlaceholderText = "Воронеж";
            this.textBoxCity.Size = new System.Drawing.Size(260, 31);
            this.textBoxCity.TabIndex = 1;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(11, 52);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 24);
            this.label23.TabIndex = 21;
            this.label23.Text = "*Город";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(931, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Арендаторы";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tbPhone2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbPhone1);
            this.groupBox4.Controls.Add(this.tbEmail);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox4.Location = new System.Drawing.Point(10, 163);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(287, 333);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Контакты";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Контактный телефон №2";
            // 
            // tbPhone2
            // 
            this.tbPhone2.Location = new System.Drawing.Point(9, 160);
            this.tbPhone2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone2.Name = "tbPhone2";
            this.tbPhone2.PlaceholderText = "8(900) -111-11-11";
            this.tbPhone2.Size = new System.Drawing.Size(215, 30);
            this.tbPhone2.TabIndex = 5;
            this.tbPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Контактный телефон №1";
            // 
            // tbPhone1
            // 
            this.tbPhone1.Location = new System.Drawing.Point(9, 62);
            this.tbPhone1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone1.Name = "tbPhone1";
            this.tbPhone1.PlaceholderText = "8(900) -111-11-11";
            this.tbPhone1.Size = new System.Drawing.Size(215, 30);
            this.tbPhone1.TabIndex = 4;
            this.tbPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(9, 260);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "as*****g@mail.ru";
            this.tbEmail.Size = new System.Drawing.Size(208, 30);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Электронная почта";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbPleadge);
            this.groupBox3.Controls.Add(this.tbRent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbLeaseDate);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(320, 163);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(287, 333);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные по аренде";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Залог";
            // 
            // tbPleadge
            // 
            this.tbPleadge.Location = new System.Drawing.Point(9, 260);
            this.tbPleadge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPleadge.Name = "tbPleadge";
            this.tbPleadge.PlaceholderText = "10000";
            this.tbPleadge.Size = new System.Drawing.Size(238, 30);
            this.tbPleadge.TabIndex = 9;
            this.tbPleadge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRent
            // 
            this.tbRent.Location = new System.Drawing.Point(9, 160);
            this.tbRent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRent.Name = "tbRent";
            this.tbRent.PlaceholderText = "10000";
            this.tbRent.Size = new System.Drawing.Size(238, 30);
            this.tbRent.TabIndex = 8;
            this.tbRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "*Стоимость аренды (руб/мес)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "*Дата заселения";
            // 
            // tbLeaseDate
            // 
            this.tbLeaseDate.Location = new System.Drawing.Point(9, 62);
            this.tbLeaseDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLeaseDate.Name = "tbLeaseDate";
            this.tbLeaseDate.PlaceholderText = "09.09.2020";
            this.tbLeaseDate.Size = new System.Drawing.Size(138, 30);
            this.tbLeaseDate.TabIndex = 7;
            this.tbLeaseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.tbpaspNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbpaspSeries);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(627, 163);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(287, 333);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Паспортные данные";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.tbaddress);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tbCity);
            this.groupBox6.Location = new System.Drawing.Point(9, 110);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(267, 203);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Прописка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(9, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "*Адресс (улица/дом/квартира)";
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(9, 155);
            this.tbaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.PlaceholderText = "ул. Ивановская, 36";
            this.tbaddress.Size = new System.Drawing.Size(225, 30);
            this.tbaddress.TabIndex = 13;
            this.tbaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "*Населенный пункт";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(9, 62);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCity.Name = "tbCity";
            this.tbCity.PlaceholderText = "г. Иваново";
            this.tbCity.Size = new System.Drawing.Size(225, 30);
            this.tbCity.TabIndex = 12;
            this.tbCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbpaspNum
            // 
            this.tbpaspNum.Location = new System.Drawing.Point(84, 62);
            this.tbpaspNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpaspNum.Name = "tbpaspNum";
            this.tbpaspNum.PlaceholderText = "999999";
            this.tbpaspNum.Size = new System.Drawing.Size(128, 30);
            this.tbpaspNum.TabIndex = 11;
            this.tbpaspNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Noto Serif Cond", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "*Серия и номер паспорта";
            // 
            // tbpaspSeries
            // 
            this.tbpaspSeries.Location = new System.Drawing.Point(9, 62);
            this.tbpaspSeries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpaspSeries.Name = "tbpaspSeries";
            this.tbpaspSeries.PlaceholderText = "9999";
            this.tbpaspSeries.Size = new System.Drawing.Size(65, 30);
            this.tbpaspSeries.TabIndex = 10;
            this.tbpaspSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbObjectArenda);
            this.groupBox1.Controls.Add(this.tbfirstName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbthirdName);
            this.groupBox1.Controls.Add(this.tblastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(-1, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(927, 508);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(733, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "*Отчество";
            // 
            // tbObjectArenda
            // 
            this.tbObjectArenda.Location = new System.Drawing.Point(83, 103);
            this.tbObjectArenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbObjectArenda.Name = "tbObjectArenda";
            this.tbObjectArenda.PlaceholderText = "объект аренды";
            this.tbObjectArenda.ReadOnly = true;
            this.tbObjectArenda.Size = new System.Drawing.Size(810, 31);
            this.tbObjectArenda.TabIndex = 19;
            this.tbObjectArenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbfirstName
            // 
            this.tbfirstName.Location = new System.Drawing.Point(9, 57);
            this.tbfirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbfirstName.Name = "tbfirstName";
            this.tbfirstName.PlaceholderText = "Иванов";
            this.tbfirstName.Size = new System.Drawing.Size(260, 31);
            this.tbfirstName.TabIndex = 1;
            this.tbfirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(9, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "Объект:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(431, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "*Имя";
            // 
            // tbthirdName
            // 
            this.tbthirdName.Location = new System.Drawing.Point(649, 58);
            this.tbthirdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbthirdName.Name = "tbthirdName";
            this.tbthirdName.PlaceholderText = "Петрович";
            this.tbthirdName.Size = new System.Drawing.Size(243, 31);
            this.tbthirdName.TabIndex = 3;
            this.tbthirdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblastName
            // 
            this.tblastName.Location = new System.Drawing.Point(329, 57);
            this.tblastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblastName.Name = "tblastName";
            this.tblastName.PlaceholderText = "Иван";
            this.tblastName.Size = new System.Drawing.Size(260, 31);
            this.tblastName.TabIndex = 2;
            this.tblastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Serif Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(93, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "*Фамилия";
            // 
            // GlobalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 1018);
            this.Controls.Add(this.gbLog_In);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.listViewElemDB);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GlobalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GlobalForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.gbLog_In.ResumeLayout(false);
            this.gbLog_In.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbObjectsothersValues.ResumeLayout(false);
            this.gbObjectsothersValues.PerformLayout();
            this.gbObjectsValue.ResumeLayout(false);
            this.gbObjectsValue.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button addObject;
        private System.Windows.Forms.Button remoteUnit;
        private System.Windows.Forms.Button exitApp;
     
        private System.Windows.Forms.ListView listViewElemDB;
        private System.Windows.Forms.ColumnHeader Column_Home;
        private System.Windows.Forms.ColumnHeader column_Cash;
        private System.Windows.Forms.ColumnHeader column_telnumb1;
        public System.Windows.Forms.ColumnHeader column_FIO;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxObjects;
        private System.Windows.Forms.ColumnHeader column_telnumb2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox gbLog_In;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label textFIO;
        private System.Windows.Forms.ColumnHeader column_Status;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addTenant;
        private System.Windows.Forms.GroupBox gbObjectsothersValues;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxRoomNum;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label27;
        
        private System.Windows.Forms.TextBox textBoxApartamentNum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPhone2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPleadge;
        private System.Windows.Forms.TextBox tbRent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLeaseDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbpaspNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbpaspSeries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbObjectArenda;
        private System.Windows.Forms.TextBox tbfirstName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbthirdName;
        private System.Windows.Forms.TextBox tblastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHouseNum;
        private System.Windows.Forms.GroupBox gbObjectsValue;
    }
}

