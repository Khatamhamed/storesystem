namespace Pharmacy_store
{
    partial class Pharmacy2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacy2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TapControl = new System.Windows.Forms.TabControl();
            this.MListTP = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MAddTP = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBN = new System.Windows.Forms.Button();
            this.QuantityNum = new System.Windows.Forms.NumericUpDown();
            this.StorageTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.MFindTP = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.MUpdateTP = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantityNum2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceTB2 = new System.Windows.Forms.TextBox();
            this.NameTB2 = new System.Windows.Forms.TextBox();
            this.StorageTB2 = new System.Windows.Forms.TextBox();
            this.UpdateBN = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.MDeleteTP = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteBN = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.FindTB = new System.Windows.Forms.TextBox();
            this.FindBN = new System.Windows.Forms.Button();
            this.updateTB = new System.Windows.Forms.TextBox();
            this.SearchBN = new System.Windows.Forms.Button();
            this.DeleteTB = new System.Windows.Forms.TextBox();
            this.SearchDBN = new System.Windows.Forms.Button();
            this.LogiutBN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TapControl.SuspendLayout();
            this.MListTP.SuspendLayout();
            this.MAddTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNum)).BeginInit();
            this.MFindTP.SuspendLayout();
            this.MUpdateTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNum2)).BeginInit();
            this.MDeleteTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pharmacy_store.Properties.Resources.IMG_2344;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log in as Khetam";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Largepic");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Smallpic");
            // 
            // TapControl
            // 
            this.TapControl.Controls.Add(this.MListTP);
            this.TapControl.Controls.Add(this.MAddTP);
            this.TapControl.Controls.Add(this.MFindTP);
            this.TapControl.Controls.Add(this.MUpdateTP);
            this.TapControl.Controls.Add(this.MDeleteTP);
            this.TapControl.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TapControl.Location = new System.Drawing.Point(12, 140);
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(1159, 511);
            this.TapControl.TabIndex = 7;
            this.TapControl.Tag = "";
            // 
            // MListTP
            // 
            this.MListTP.Controls.Add(this.listView1);
            this.MListTP.Location = new System.Drawing.Point(4, 46);
            this.MListTP.Name = "MListTP";
            this.MListTP.Padding = new System.Windows.Forms.Padding(3);
            this.MListTP.Size = new System.Drawing.Size(1151, 461);
            this.MListTP.TabIndex = 0;
            this.MListTP.Text = "Medicine List";
            this.MListTP.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(67, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(818, 378);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MAddTP
            // 
            this.MAddTP.Controls.Add(this.label5);
            this.MAddTP.Controls.Add(this.label4);
            this.MAddTP.Controls.Add(this.label3);
            this.MAddTP.Controls.Add(this.label2);
            this.MAddTP.Controls.Add(this.AddBN);
            this.MAddTP.Controls.Add(this.QuantityNum);
            this.MAddTP.Controls.Add(this.StorageTB);
            this.MAddTP.Controls.Add(this.PriceTB);
            this.MAddTP.Controls.Add(this.NameTB);
            this.MAddTP.Location = new System.Drawing.Point(4, 46);
            this.MAddTP.Name = "MAddTP";
            this.MAddTP.Padding = new System.Windows.Forms.Padding(3);
            this.MAddTP.Size = new System.Drawing.Size(1151, 461);
            this.MAddTP.TabIndex = 4;
            this.MAddTP.Text = "Add Medicine";
            this.MAddTP.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Storage Place:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medicine Name:";
            // 
            // AddBN
            // 
            this.AddBN.Location = new System.Drawing.Point(491, 341);
            this.AddBN.Name = "AddBN";
            this.AddBN.Size = new System.Drawing.Size(97, 40);
            this.AddBN.TabIndex = 4;
            this.AddBN.Text = "ADD";
            this.AddBN.UseVisualStyleBackColor = true;
            this.AddBN.Click += new System.EventHandler(this.AddBN_Click);
            // 
            // QuantityNum
            // 
            this.QuantityNum.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityNum.Location = new System.Drawing.Point(385, 175);
            this.QuantityNum.Name = "QuantityNum";
            this.QuantityNum.Size = new System.Drawing.Size(296, 38);
            this.QuantityNum.TabIndex = 3;
            // 
            // StorageTB
            // 
            this.StorageTB.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageTB.Location = new System.Drawing.Point(385, 105);
            this.StorageTB.Name = "StorageTB";
            this.StorageTB.Size = new System.Drawing.Size(296, 38);
            this.StorageTB.TabIndex = 2;
            // 
            // PriceTB
            // 
            this.PriceTB.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTB.Location = new System.Drawing.Point(385, 245);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(296, 38);
            this.PriceTB.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(385, 42);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(296, 38);
            this.NameTB.TabIndex = 0;
            // 
            // MFindTP
            // 
            this.MFindTP.Controls.Add(this.FindBN);
            this.MFindTP.Controls.Add(this.FindTB);
            this.MFindTP.Controls.Add(this.listView4);
            this.MFindTP.Location = new System.Drawing.Point(4, 46);
            this.MFindTP.Name = "MFindTP";
            this.MFindTP.Padding = new System.Windows.Forms.Padding(3);
            this.MFindTP.Size = new System.Drawing.Size(1151, 461);
            this.MFindTP.TabIndex = 1;
            this.MFindTP.Text = "Find Medicine";
            this.MFindTP.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(28, 113);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1067, 311);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // MUpdateTP
            // 
            this.MUpdateTP.Controls.Add(this.SearchBN);
            this.MUpdateTP.Controls.Add(this.updateTB);
            this.MUpdateTP.Controls.Add(this.label10);
            this.MUpdateTP.Controls.Add(this.label9);
            this.MUpdateTP.Controls.Add(this.label8);
            this.MUpdateTP.Controls.Add(this.label7);
            this.MUpdateTP.Controls.Add(this.QuantityNum2);
            this.MUpdateTP.Controls.Add(this.label6);
            this.MUpdateTP.Controls.Add(this.PriceTB2);
            this.MUpdateTP.Controls.Add(this.NameTB2);
            this.MUpdateTP.Controls.Add(this.StorageTB2);
            this.MUpdateTP.Controls.Add(this.UpdateBN);
            this.MUpdateTP.Controls.Add(this.listView2);
            this.MUpdateTP.Location = new System.Drawing.Point(4, 46);
            this.MUpdateTP.Name = "MUpdateTP";
            this.MUpdateTP.Padding = new System.Windows.Forms.Padding(3);
            this.MUpdateTP.Size = new System.Drawing.Size(1151, 461);
            this.MUpdateTP.TabIndex = 2;
            this.MUpdateTP.Text = "Update Medicine Information";
            this.MUpdateTP.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(372, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Search by the name of medicine then updat it\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(630, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Storage Place:";
            // 
            // QuantityNum2
            // 
            this.QuantityNum2.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityNum2.Location = new System.Drawing.Point(733, 305);
            this.QuantityNum2.Name = "QuantityNum2";
            this.QuantityNum2.Size = new System.Drawing.Size(240, 29);
            this.QuantityNum2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Medicin Name:";
            // 
            // PriceTB2
            // 
            this.PriceTB2.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTB2.Location = new System.Drawing.Point(733, 366);
            this.PriceTB2.Name = "PriceTB2";
            this.PriceTB2.Size = new System.Drawing.Size(240, 29);
            this.PriceTB2.TabIndex = 6;
            // 
            // NameTB2
            // 
            this.NameTB2.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB2.Location = new System.Drawing.Point(260, 304);
            this.NameTB2.Name = "NameTB2";
            this.NameTB2.Size = new System.Drawing.Size(240, 29);
            this.NameTB2.TabIndex = 5;
            // 
            // StorageTB2
            // 
            this.StorageTB2.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageTB2.Location = new System.Drawing.Point(260, 366);
            this.StorageTB2.Name = "StorageTB2";
            this.StorageTB2.Size = new System.Drawing.Size(240, 29);
            this.StorageTB2.TabIndex = 4;
            // 
            // UpdateBN
            // 
            this.UpdateBN.Location = new System.Drawing.Point(514, 417);
            this.UpdateBN.Name = "UpdateBN";
            this.UpdateBN.Size = new System.Drawing.Size(127, 38);
            this.UpdateBN.TabIndex = 3;
            this.UpdateBN.Text = "Update";
            this.UpdateBN.UseVisualStyleBackColor = true;
            this.UpdateBN.Click += new System.EventHandler(this.UpdateBN_Click);
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.imageList2;
            this.listView2.Location = new System.Drawing.Point(159, 119);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(843, 154);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // MDeleteTP
            // 
            this.MDeleteTP.Controls.Add(this.SearchDBN);
            this.MDeleteTP.Controls.Add(this.DeleteTB);
            this.MDeleteTP.Controls.Add(this.label11);
            this.MDeleteTP.Controls.Add(this.DeleteBN);
            this.MDeleteTP.Controls.Add(this.listView3);
            this.MDeleteTP.Location = new System.Drawing.Point(4, 46);
            this.MDeleteTP.Name = "MDeleteTP";
            this.MDeleteTP.Padding = new System.Windows.Forms.Padding(3);
            this.MDeleteTP.Size = new System.Drawing.Size(1151, 461);
            this.MDeleteTP.TabIndex = 3;
            this.MDeleteTP.Text = "Delete The Medicine";
            this.MDeleteTP.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(373, 42);
            this.label11.TabIndex = 5;
            this.label11.Text = "Search by the name of medicine then delete it\r\n\r\n";
            // 
            // DeleteBN
            // 
            this.DeleteBN.Location = new System.Drawing.Point(500, 384);
            this.DeleteBN.Name = "DeleteBN";
            this.DeleteBN.Size = new System.Drawing.Size(108, 38);
            this.DeleteBN.TabIndex = 4;
            this.DeleteBN.Text = "Delete";
            this.DeleteBN.UseVisualStyleBackColor = true;
            this.DeleteBN.Click += new System.EventHandler(this.DeleteBN_Click);
            // 
            // listView3
            // 
            this.listView3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.LargeImageList = this.imageList2;
            this.listView3.Location = new System.Drawing.Point(145, 154);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(843, 201);
            this.listView3.SmallImageList = this.imageList1;
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // FindTB
            // 
            this.FindTB.Font = new System.Drawing.Font("Dubai", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindTB.Location = new System.Drawing.Point(360, 23);
            this.FindTB.Name = "FindTB";
            this.FindTB.Size = new System.Drawing.Size(373, 35);
            this.FindTB.TabIndex = 1;
            // 
            // FindBN
            // 
            this.FindBN.Location = new System.Drawing.Point(497, 64);
            this.FindBN.Name = "FindBN";
            this.FindBN.Size = new System.Drawing.Size(100, 43);
            this.FindBN.TabIndex = 2;
            this.FindBN.Text = "Find";
            this.FindBN.UseVisualStyleBackColor = true;
            this.FindBN.Click += new System.EventHandler(this.FindBN_Click);
            // 
            // updateTB
            // 
            this.updateTB.Font = new System.Drawing.Font("Andalus", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTB.Location = new System.Drawing.Point(344, 53);
            this.updateTB.Name = "updateTB";
            this.updateTB.Size = new System.Drawing.Size(287, 32);
            this.updateTB.TabIndex = 14;
            // 
            // SearchBN
            // 
            this.SearchBN.Location = new System.Drawing.Point(663, 53);
            this.SearchBN.Name = "SearchBN";
            this.SearchBN.Size = new System.Drawing.Size(95, 32);
            this.SearchBN.TabIndex = 15;
            this.SearchBN.Text = "Search";
            this.SearchBN.UseVisualStyleBackColor = true;
            this.SearchBN.Click += new System.EventHandler(this.SearchBN_Click);
            // 
            // DeleteTB
            // 
            this.DeleteTB.Font = new System.Drawing.Font("Dubai", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTB.Location = new System.Drawing.Point(374, 64);
            this.DeleteTB.Name = "DeleteTB";
            this.DeleteTB.Size = new System.Drawing.Size(267, 35);
            this.DeleteTB.TabIndex = 6;
            // 
            // SearchDBN
            // 
            this.SearchDBN.Location = new System.Drawing.Point(668, 67);
            this.SearchDBN.Name = "SearchDBN";
            this.SearchDBN.Size = new System.Drawing.Size(89, 32);
            this.SearchDBN.TabIndex = 7;
            this.SearchDBN.Text = "Search";
            this.SearchDBN.UseVisualStyleBackColor = true;
            this.SearchDBN.Click += new System.EventHandler(this.SearchDBN_Click);
            // 
            // LogiutBN
            // 
            this.LogiutBN.Location = new System.Drawing.Point(1001, 33);
            this.LogiutBN.Name = "LogiutBN";
            this.LogiutBN.Size = new System.Drawing.Size(121, 43);
            this.LogiutBN.TabIndex = 2;
            this.LogiutBN.Text = "Log out";
            this.LogiutBN.UseVisualStyleBackColor = true;
            this.LogiutBN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pharmacy2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy_store.Properties.Resources.IMG_2340;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 663);
            this.Controls.Add(this.LogiutBN);
            this.Controls.Add(this.TapControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pharmacy2";
            this.Text = "Pharmacy Store";
            this.Load += new System.EventHandler(this.Pharmacy2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TapControl.ResumeLayout(false);
            this.MListTP.ResumeLayout(false);
            this.MAddTP.ResumeLayout(false);
            this.MAddTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNum)).EndInit();
            this.MFindTP.ResumeLayout(false);
            this.MFindTP.PerformLayout();
            this.MUpdateTP.ResumeLayout(false);
            this.MUpdateTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNum2)).EndInit();
            this.MDeleteTP.ResumeLayout(false);
            this.MDeleteTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TabControl TapControl;
        private System.Windows.Forms.TabPage MListTP;
        private System.Windows.Forms.TabPage MFindTP;
        private System.Windows.Forms.TabPage MUpdateTP;
        private System.Windows.Forms.TabPage MDeleteTP;
        private System.Windows.Forms.TabPage MAddTP;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBN;
        private System.Windows.Forms.NumericUpDown QuantityNum;
        private System.Windows.Forms.TextBox StorageTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button UpdateBN;
        private System.Windows.Forms.TextBox PriceTB2;
        private System.Windows.Forms.TextBox NameTB2;
        private System.Windows.Forms.TextBox StorageTB2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown QuantityNum2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteBN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Button FindBN;
        private System.Windows.Forms.TextBox FindTB;
        private System.Windows.Forms.Button SearchBN;
        private System.Windows.Forms.TextBox updateTB;
        private System.Windows.Forms.TextBox DeleteTB;
        private System.Windows.Forms.Button SearchDBN;
        private System.Windows.Forms.Button LogiutBN;
    }
}