namespace CollegeParkAutoParts21
{
    partial class StoreItemNew
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
            this.lblPictureFile = new System.Windows.Forms.Label();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveAutoPart = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxPartImage = new System.Windows.Forms.PictureBox();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewModel = new System.Windows.Forms.Button();
            this.cbxModels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewMake = new System.Windows.Forms.Button();
            this.cbxMakes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxYears = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdPictureFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPictureFile
            // 
            this.lblPictureFile.AutoSize = true;
            this.lblPictureFile.Location = new System.Drawing.Point(783, 28);
            this.lblPictureFile.Name = "lblPictureFile";
            this.lblPictureFile.Size = new System.Drawing.Size(16, 25);
            this.lblPictureFile.TabIndex = 48;
            this.lblPictureFile.Text = ".";
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(596, 23);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(172, 34);
            this.btnSelectPicture.TabIndex = 47;
            this.btnSelectPicture.Text = "&Select Picture...";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(154, 270);
            this.txtPartName.Multiline = true;
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPartName.Size = new System.Drawing.Size(419, 136);
            this.txtPartName.TabIndex = 59;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(34, 270);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(98, 25);
            this.lblPartName.TabIndex = 58;
            this.lblPartName.Text = "Part Na&me:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(565, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "_______________________________________________________________________________";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(423, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 34);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveAutoPart
            // 
            this.btnSaveAutoPart.Location = new System.Drawing.Point(155, 515);
            this.btnSaveAutoPart.Name = "btnSaveAutoPart";
            this.btnSaveAutoPart.Size = new System.Drawing.Size(247, 34);
            this.btnSaveAutoPart.TabIndex = 62;
            this.btnSaveAutoPart.Text = "Sa&ve Auto-Part";
            this.btnSaveAutoPart.UseVisualStyleBackColor = true;
            this.btnSaveAutoPart.Click += new System.EventHandler(this.btnSaveAutoPart_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(482, 433);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(91, 31);
            this.txtUnitPrice.TabIndex = 61;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "&Unit Price:";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(155, 25);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(130, 31);
            this.txtPartNumber.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "&Part #:";
            // 
            // pbxPartImage
            // 
            this.pbxPartImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPartImage.Location = new System.Drawing.Point(596, 73);
            this.pbxPartImage.Name = "pbxPartImage";
            this.pbxPartImage.Size = new System.Drawing.Size(767, 718);
            this.pbxPartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPartImage.TabIndex = 57;
            this.pbxPartImage.TabStop = false;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(416, 219);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(157, 34);
            this.btnNewCategory.TabIndex = 65;
            this.btnNewCategory.Text = "New Cat&egory...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // cbxCategories
            // 
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(155, 220);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(255, 33);
            this.cbxCategories.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Ca&tegory:";
            // 
            // btnNewModel
            // 
            this.btnNewModel.Location = new System.Drawing.Point(416, 170);
            this.btnNewModel.Name = "btnNewModel";
            this.btnNewModel.Size = new System.Drawing.Size(157, 34);
            this.btnNewModel.TabIndex = 64;
            this.btnNewModel.Text = "New Mo&del...";
            this.btnNewModel.UseVisualStyleBackColor = true;
            this.btnNewModel.Click += new System.EventHandler(this.btnNewModel_Click);
            // 
            // cbxModels
            // 
            this.cbxModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModels.FormattingEnabled = true;
            this.cbxModels.Location = new System.Drawing.Point(155, 171);
            this.cbxModels.Name = "cbxModels";
            this.cbxModels.Size = new System.Drawing.Size(255, 33);
            this.cbxModels.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "M&odel:";
            // 
            // btnNewMake
            // 
            this.btnNewMake.Location = new System.Drawing.Point(416, 121);
            this.btnNewMake.Name = "btnNewMake";
            this.btnNewMake.Size = new System.Drawing.Size(157, 34);
            this.btnNewMake.TabIndex = 63;
            this.btnNewMake.Text = "New M&ake...";
            this.btnNewMake.UseVisualStyleBackColor = true;
            this.btnNewMake.Click += new System.EventHandler(this.btnNewMake_Click);
            // 
            // cbxMakes
            // 
            this.cbxMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMakes.FormattingEnabled = true;
            this.cbxMakes.Location = new System.Drawing.Point(155, 122);
            this.cbxMakes.Name = "cbxMakes";
            this.cbxMakes.Size = new System.Drawing.Size(255, 33);
            this.cbxMakes.Sorted = true;
            this.cbxMakes.TabIndex = 52;
            this.cbxMakes.SelectedIndexChanged += new System.EventHandler(this.cbxMakes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "&Make:";
            // 
            // cbxYears
            // 
            this.cbxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYears.FormattingEnabled = true;
            this.cbxYears.Location = new System.Drawing.Point(155, 73);
            this.cbxYears.Name = "cbxYears";
            this.cbxYears.Size = new System.Drawing.Size(130, 33);
            this.cbxYears.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "&Year:";
            // 
            // ofdPictureFile
            // 
            this.ofdPictureFile.FileName = "ofdPictureFile";
            // 
            // StoreItemNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 814);
            this.Controls.Add(this.lblPictureFile);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveAutoPart);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxPartImage);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewModel);
            this.Controls.Add(this.cbxModels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNewMake);
            this.Controls.Add(this.cbxMakes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxYears);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "StoreItemNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Park Auto-Parts - New Store Item";
            this.Load += new System.EventHandler(this.StoreItemNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPictureFile;
        private Button btnSelectPicture;
        private TextBox txtPartName;
        private Label lblPartName;
        private Label label7;
        private Button btnClose;
        private Button btnSaveAutoPart;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtPartNumber;
        private Label label5;
        private PictureBox pbxPartImage;
        private Button btnNewCategory;
        private ComboBox cbxCategories;
        private Label label4;
        private Button btnNewModel;
        private ComboBox cbxModels;
        private Label label3;
        private Button btnNewMake;
        private ComboBox cbxMakes;
        private Label label2;
        private ComboBox cbxYears;
        private Label label1;
        private OpenFileDialog ofdPictureFile;
    }
}