namespace CollegeParkAutoParts21
{
    partial class CollegeParkAutoParts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeParkAutoParts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colSelectedSubTotal = new System.Windows.Forms.ColumnHeader();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.pbxPartImage = new System.Windows.Forms.PictureBox();
            this.tvwAutoParts = new System.Windows.Forms.TreeView();
            this.AutoPartsImages = new System.Windows.Forms.ImageList(this.components);
            this.lvwAvailableParts = new System.Windows.Forms.ListView();
            this.colAvailablePartNumber = new System.Windows.Forms.ColumnHeader();
            this.colAvailablePartName = new System.Windows.Forms.ColumnHeader();
            this.colAvailableUnitPrice = new System.Windows.Forms.ColumnHeader();
            this.colSelectedQuantity = new System.Windows.Forms.ColumnHeader();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwSelectedParts = new System.Windows.Forms.ListView();
            this.colSelectedPartNumber = new System.Windows.Forms.ColumnHeader();
            this.colSelectedPartName = new System.Windows.Forms.ColumnHeader();
            this.colSelectedUnitPrice = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.gbxAvailableParts = new System.Windows.Forms.GroupBox();
            this.gbxPartIdentification = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteAutoPart = new System.Windows.Forms.Button();
            this.btnUpdateAutoPart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSelectedPartsTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewAutoPart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxAvailableParts.SuspendLayout();
            this.gbxPartIdentification.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(34, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2100, 5);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // colSelectedSubTotal
            // 
            this.colSelectedSubTotal.Text = "Sub-Total";
            this.colSelectedSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSelectedSubTotal.Width = 90;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(881, 70);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(90, 31);
            this.txtSubTotal.TabIndex = 9;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(133, 70);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(597, 31);
            this.txtPartName.TabIndex = 6;
            // 
            // pbxPartImage
            // 
            this.pbxPartImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPartImage.Location = new System.Drawing.Point(1367, 110);
            this.pbxPartImage.Name = "pbxPartImage";
            this.pbxPartImage.Size = new System.Drawing.Size(767, 766);
            this.pbxPartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPartImage.TabIndex = 19;
            this.pbxPartImage.TabStop = false;
            // 
            // tvwAutoParts
            // 
            this.tvwAutoParts.ImageIndex = 0;
            this.tvwAutoParts.ImageList = this.AutoPartsImages;
            this.tvwAutoParts.Location = new System.Drawing.Point(21, 40);
            this.tvwAutoParts.Name = "tvwAutoParts";
            this.tvwAutoParts.SelectedImageIndex = 0;
            this.tvwAutoParts.Size = new System.Drawing.Size(257, 662);
            this.tvwAutoParts.TabIndex = 0;
            this.tvwAutoParts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwAutoParts_NodeMouseClick);
            // 
            // AutoPartsImages
            // 
            this.AutoPartsImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.AutoPartsImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AutoPartsImages.ImageStream")));
            this.AutoPartsImages.TransparentColor = System.Drawing.Color.Transparent;
            this.AutoPartsImages.Images.SetKeyName(0, "HOUSE.ICO");
            this.AutoPartsImages.Images.SetKeyName(1, "BOOKS.ICO");
            this.AutoPartsImages.Images.SetKeyName(2, "BOOK10.ICO");
            this.AutoPartsImages.Images.SetKeyName(3, "BOOK9.ICO");
            this.AutoPartsImages.Images.SetKeyName(4, "Plus2.ico");
            this.AutoPartsImages.Images.SetKeyName(5, "MINUS.ICO");
            this.AutoPartsImages.Images.SetKeyName(6, "CLIP1.ICO");
            this.AutoPartsImages.Images.SetKeyName(7, "CLIP2.ICO");
            this.AutoPartsImages.Images.SetKeyName(8, "RULERS.ICO");
            this.AutoPartsImages.Images.SetKeyName(9, "RULERS2.ICO");
            this.AutoPartsImages.Images.SetKeyName(10, "GRAPHUP.ICO");
            this.AutoPartsImages.Images.SetKeyName(11, "GRPHDOWN.ICO");
            this.AutoPartsImages.Images.SetKeyName(12, "TOOL1.ICO");
            this.AutoPartsImages.Images.SetKeyName(13, "TOOL2.ICO");
            // 
            // lvwAvailableParts
            // 
            this.lvwAvailableParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAvailablePartNumber,
            this.colAvailablePartName,
            this.colAvailableUnitPrice});
            this.lvwAvailableParts.FullRowSelect = true;
            this.lvwAvailableParts.GridLines = true;
            this.lvwAvailableParts.Location = new System.Drawing.Point(20, 40);
            this.lvwAvailableParts.Name = "lvwAvailableParts";
            this.lvwAvailableParts.Size = new System.Drawing.Size(951, 235);
            this.lvwAvailableParts.TabIndex = 0;
            this.lvwAvailableParts.UseCompatibleStateImageBehavior = false;
            this.lvwAvailableParts.View = System.Windows.Forms.View.Details;
            this.lvwAvailableParts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwAvailableParts_ItemSelectionChanged);
            this.lvwAvailableParts.DoubleClick += new System.EventHandler(this.lvwAvailableParts_DoubleClick);
            // 
            // colAvailablePartNumber
            // 
            this.colAvailablePartNumber.Text = "Part #";
            this.colAvailablePartNumber.Width = 80;
            // 
            // colAvailablePartName
            // 
            this.colAvailablePartName.Text = "Part Name/Description";
            this.colAvailablePartName.Width = 650;
            // 
            // colAvailableUnitPrice
            // 
            this.colAvailableUnitPrice.Text = "Unit Price";
            this.colAvailableUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colAvailableUnitPrice.Width = 100;
            // 
            // colSelectedQuantity
            // 
            this.colSelectedQuantity.Text = "Qty";
            this.colSelectedQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSelectedQuantity.Width = 50;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(20, 70);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(107, 31);
            this.txtPartNumber.TabIndex = 5;
            this.txtPartNumber.Leave += new System.EventHandler(this.txtPartNumber_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(881, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sub-Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Part Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Part #";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwSelectedParts);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtPartName);
            this.groupBox1.Controls.Add(this.txtPartNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(347, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 425);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Parts";
            // 
            // lvwSelectedParts
            // 
            this.lvwSelectedParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSelectedPartNumber,
            this.colSelectedPartName,
            this.colSelectedUnitPrice,
            this.colSelectedQuantity,
            this.colSelectedSubTotal});
            this.lvwSelectedParts.FullRowSelect = true;
            this.lvwSelectedParts.GridLines = true;
            this.lvwSelectedParts.Location = new System.Drawing.Point(20, 167);
            this.lvwSelectedParts.Name = "lvwSelectedParts";
            this.lvwSelectedParts.Size = new System.Drawing.Size(951, 233);
            this.lvwSelectedParts.TabIndex = 11;
            this.lvwSelectedParts.UseCompatibleStateImageBehavior = false;
            this.lvwSelectedParts.View = System.Windows.Forms.View.Details;
            this.lvwSelectedParts.DoubleClick += new System.EventHandler(this.lvwSelectedParts_DoubleClick);
            // 
            // colSelectedPartNumber
            // 
            this.colSelectedPartNumber.Text = "Part #";
            this.colSelectedPartNumber.Width = 80;
            // 
            // colSelectedPartName
            // 
            this.colSelectedPartName.Text = "Part Name/Description";
            this.colSelectedPartName.Width = 600;
            // 
            // colSelectedUnitPrice
            // 
            this.colSelectedUnitPrice.Text = "Unit Price";
            this.colSelectedUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSelectedUnitPrice.Width = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(951, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add/Select";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(832, 70);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(43, 31);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.Leave += new System.EventHandler(this.txtUnitPrice_Leave);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(736, 70);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(90, 31);
            this.txtUnitPrice.TabIndex = 7;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnitPrice.Leave += new System.EventHandler(this.txtUnitPrice_Leave);
            // 
            // gbxAvailableParts
            // 
            this.gbxAvailableParts.Controls.Add(this.lvwAvailableParts);
            this.gbxAvailableParts.Location = new System.Drawing.Point(347, 100);
            this.gbxAvailableParts.Name = "gbxAvailableParts";
            this.gbxAvailableParts.Size = new System.Drawing.Size(998, 296);
            this.gbxAvailableParts.TabIndex = 17;
            this.gbxAvailableParts.TabStop = false;
            this.gbxAvailableParts.Text = "Available Parts";
            // 
            // gbxPartIdentification
            // 
            this.gbxPartIdentification.Controls.Add(this.tvwAutoParts);
            this.gbxPartIdentification.Location = new System.Drawing.Point(31, 100);
            this.gbxPartIdentification.Name = "gbxPartIdentification";
            this.gbxPartIdentification.Size = new System.Drawing.Size(300, 727);
            this.gbxPartIdentification.TabIndex = 16;
            this.gbxPartIdentification.TabStop = false;
            this.gbxPartIdentification.Text = "Part Identification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(594, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "College Park Auto-Parts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnDeleteAutoPart);
            this.groupBox2.Controls.Add(this.btnUpdateAutoPart);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.txtOrderTotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTaxAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTaxRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSelectedPartsTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnNewAutoPart);
            this.groupBox2.Location = new System.Drawing.Point(31, 842);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1314, 158);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(789, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "%";
            // 
            // btnDeleteAutoPart
            // 
            this.btnDeleteAutoPart.Location = new System.Drawing.Point(1092, 43);
            this.btnDeleteAutoPart.Name = "btnDeleteAutoPart";
            this.btnDeleteAutoPart.Size = new System.Drawing.Size(195, 43);
            this.btnDeleteAutoPart.TabIndex = 11;
            this.btnDeleteAutoPart.Text = "Delete Auto-Part ...";
            this.btnDeleteAutoPart.UseVisualStyleBackColor = true;
            this.btnDeleteAutoPart.Click += new System.EventHandler(this.btnDeleteAutoPart_Click);
            // 
            // btnUpdateAutoPart
            // 
            this.btnUpdateAutoPart.Location = new System.Drawing.Point(21, 96);
            this.btnUpdateAutoPart.Name = "btnUpdateAutoPart";
            this.btnUpdateAutoPart.Size = new System.Drawing.Size(239, 43);
            this.btnUpdateAutoPart.TabIndex = 10;
            this.btnUpdateAutoPart.Text = "Update Auto-Part ...";
            this.btnUpdateAutoPart.UseVisualStyleBackColor = true;
            this.btnUpdateAutoPart.Click += new System.EventHandler(this.btnUpdateAutoPart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1092, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(948, 74);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(108, 31);
            this.txtOrderTotal.TabIndex = 8;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(838, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Order Total:";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(709, 93);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(108, 31);
            this.txtTaxAmount.TabIndex = 6;
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tax Amount:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(709, 47);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(74, 31);
            this.txtTaxRate.TabIndex = 4;
            this.txtTaxRate.Text = "7.75";
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tax Rate:";
            // 
            // txtSelectedPartsTotal
            // 
            this.txtSelectedPartsTotal.Location = new System.Drawing.Point(463, 77);
            this.txtSelectedPartsTotal.Name = "txtSelectedPartsTotal";
            this.txtSelectedPartsTotal.Size = new System.Drawing.Size(108, 31);
            this.txtSelectedPartsTotal.TabIndex = 2;
            this.txtSelectedPartsTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Selected Parts Total:";
            // 
            // btnNewAutoPart
            // 
            this.btnNewAutoPart.Location = new System.Drawing.Point(21, 43);
            this.btnNewAutoPart.Name = "btnNewAutoPart";
            this.btnNewAutoPart.Size = new System.Drawing.Size(239, 43);
            this.btnNewAutoPart.TabIndex = 0;
            this.btnNewAutoPart.Text = "New Au&to Part ...";
            this.btnNewAutoPart.UseVisualStyleBackColor = true;
            this.btnNewAutoPart.Click += new System.EventHandler(this.btnNewAutoPart_Click);
            // 
            // CollegeParkAutoParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2168, 1029);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxPartImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAvailableParts);
            this.Controls.Add(this.gbxPartIdentification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "CollegeParkAutoParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Park Auto-Parts: Store Inventory";
            this.Load += new System.EventHandler(this.CollegeParkAutoParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAvailableParts.ResumeLayout(false);
            this.gbxPartIdentification.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ColumnHeader colSelectedSubTotal;
        private TextBox txtSubTotal;
        private TextBox txtPartName;
        private PictureBox pbxPartImage;
        private TreeView tvwAutoParts;
        private ImageList AutoPartsImages;
        private ListView lvwAvailableParts;
        private ColumnHeader colAvailablePartNumber;
        private ColumnHeader colAvailablePartName;
        private ColumnHeader colAvailableUnitPrice;
        private ColumnHeader colSelectedQuantity;
        private TextBox txtPartNumber;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private ListView lvwSelectedParts;
        private ColumnHeader colSelectedPartNumber;
        private ColumnHeader colSelectedPartName;
        private ColumnHeader colSelectedUnitPrice;
        private Button btnAdd;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private GroupBox gbxAvailableParts;
        private GroupBox gbxPartIdentification;
        private Label label1;
        private GroupBox groupBox2;
        private Label label11;
        private Button btnDeleteAutoPart;
        private Button btnUpdateAutoPart;
        private Button btnClose;
        private TextBox txtOrderTotal;
        private Label label10;
        private TextBox txtTaxAmount;
        private Label label9;
        private TextBox txtTaxRate;
        private Label label8;
        private TextBox txtSelectedPartsTotal;
        private Label label7;
        private Button btnNewAutoPart;
    }
}