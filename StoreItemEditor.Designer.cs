namespace CollegeParkAutoParts21
{
    partial class StoreItemEditor
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
            this.ofdPictureFile = new System.Windows.Forms.OpenFileDialog();
            this.lblPictureFile = new System.Windows.Forms.Label();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateAutoPart = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxPartImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxYears = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdPictureFile
            // 
            this.ofdPictureFile.FileName = "ofdPictureFile";
            // 
            // lblPictureFile
            // 
            this.lblPictureFile.AutoSize = true;
            this.lblPictureFile.Location = new System.Drawing.Point(783, 28);
            this.lblPictureFile.Name = "lblPictureFile";
            this.lblPictureFile.Size = new System.Drawing.Size(16, 25);
            this.lblPictureFile.TabIndex = 71;
            this.lblPictureFile.Text = ".";
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(596, 23);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(172, 34);
            this.btnSelectPicture.TabIndex = 70;
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
            this.txtPartName.TabIndex = 82;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(34, 270);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(98, 25);
            this.lblPartName.TabIndex = 81;
            this.lblPartName.Text = "Part Na&me:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(565, 25);
            this.label7.TabIndex = 89;
            this.label7.Text = "_______________________________________________________________________________";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(423, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 34);
            this.btnClose.TabIndex = 90;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateAutoPart
            // 
            this.btnUpdateAutoPart.Location = new System.Drawing.Point(155, 515);
            this.btnUpdateAutoPart.Name = "btnUpdateAutoPart";
            this.btnUpdateAutoPart.Size = new System.Drawing.Size(247, 34);
            this.btnUpdateAutoPart.TabIndex = 85;
            this.btnUpdateAutoPart.Text = "Ud&date Auto-Part";
            this.btnUpdateAutoPart.UseVisualStyleBackColor = true;
            this.btnUpdateAutoPart.Click += new System.EventHandler(this.btnUpdateAutoPart_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(482, 433);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(91, 31);
            this.txtUnitPrice.TabIndex = 84;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 83;
            this.label6.Text = "&Unit Price:";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(155, 25);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(130, 31);
            this.txtPartNumber.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "&Part #:";
            // 
            // pbxPartImage
            // 
            this.pbxPartImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPartImage.Location = new System.Drawing.Point(596, 73);
            this.pbxPartImage.Name = "pbxPartImage";
            this.pbxPartImage.Size = new System.Drawing.Size(767, 718);
            this.pbxPartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPartImage.TabIndex = 80;
            this.pbxPartImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Ca&tegory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "M&odel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "&Make:";
            // 
            // cbxYears
            // 
            this.cbxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYears.FormattingEnabled = true;
            this.cbxYears.Location = new System.Drawing.Point(155, 73);
            this.cbxYears.Name = "cbxYears";
            this.cbxYears.Size = new System.Drawing.Size(130, 33);
            this.cbxYears.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "&Year:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(298, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 34);
            this.btnFind.TabIndex = 91;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(155, 122);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(419, 31);
            this.txtMake.TabIndex = 92;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(154, 171);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(419, 31);
            this.txtModel.TabIndex = 93;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(154, 220);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(419, 31);
            this.txtCategory.TabIndex = 94;
            // 
            // StoreItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 814);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblPictureFile);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateAutoPart);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxPartImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxYears);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "StoreItemEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Park Auto-Parts: Store Item Editor";
            this.Load += new System.EventHandler(this.StoreItemEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog ofdPictureFile;
        private Label lblPictureFile;
        private Button btnSelectPicture;
        private TextBox txtPartName;
        private Label lblPartName;
        private Label label7;
        private Button btnClose;
        private Button btnUpdateAutoPart;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtPartNumber;
        private Label label5;
        private PictureBox pbxPartImage;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbxYears;
        private Label label1;
        private Button btnFind;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtCategory;
    }
}