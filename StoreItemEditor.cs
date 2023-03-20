using System.Data;
using System.Data.SqlClient;

namespace CollegeParkAutoParts21
{
    public partial class StoreItemEditor : Form
    {
        public StoreItemEditor()
        {
            InitializeComponent();
        }

        private void InitializeAutoPart()
        {
            txtMake.Text       = string.Empty;
            txtModel.Text      = string.Empty;
            txtCategory.Text   = string.Empty;
            txtPartName.Text   = string.Empty;
            txtUnitPrice.Text  = string.Empty;
            txtPartNumber.Text = string.Empty;

            for (int year = DateTime.Today.Year + 1; year >= DateTime.Today.Year - 20; year--)
                cbxYears.Items.Add(year);

            lblPictureFile.Text = "Generic.png";
            pbxPartImage.Image  = Image.FromFile(@"E:\College Park Auto-Parts\Generic.png");

            Width  = pbxPartImage.Right  + 40;
            Height = pbxPartImage.Bottom + 75;
        }

        private void StoreItemEditor_Load(object sender, EventArgs e)
        {
            InitializeAutoPart();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartNumber.Text))
            {
                MessageBox.Show("You must enter a (valid) number for an auto-part.",
                                "College Park Auto-Parts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool foundAutoPart = false;

            DataSet dsParts = new("AutoPartsSet");

            using (SqlConnection scCollegeParkAutoParts =
                new SqlConnection("Data Source=(local);" +
                                  "Database=CollegeParkAutoParts2;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdParts = new SqlCommand("SELECT PartNumber, " +
                                                     "       CarYear,    " +
                                                     "       Make,       " +
                                                     "       Model,      " +
                                                     "       Category,   " +
                                                     "       PartName,   " +
                                                     "       PartImage,  " +
                                                     "       UnitPrice   " +
                                                     "FROM   AutoParts;", scCollegeParkAutoParts);

                scCollegeParkAutoParts.Open();

                SqlDataAdapter sdaParts = new SqlDataAdapter(cmdParts);

                sdaParts.Fill(dsParts);

                foreach (DataRow drPart in dsParts.Tables[0].Rows)
                {
                    if(drPart[0].ToString()!.Equals(txtPartNumber.Text))
                    {
                        foundAutoPart = true;
                        
                        cbxYears.Text       = drPart[1].ToString();
                        txtMake.Text        = drPart[2].ToString();
                        txtModel.Text       = drPart[3].ToString();
                        txtCategory.Text    = drPart[4].ToString();
                        txtPartName.Text    = drPart[5].ToString();
                        lblPictureFile.Text = drPart[6].ToString();
                        pbxPartImage.Image  = Image.FromFile(@"E:\College Park Auto-Parts\" + drPart[6].ToString());
                        txtUnitPrice.Text   = double.Parse(drPart[7].ToString()!).ToString("F");
                        
                        Width               = pbxPartImage.Right  + 40;
                        Height              = pbxPartImage.Bottom + 75;
                    }
                }
            }

            if (foundAutoPart == false)
            {
                MessageBox.Show("There is no auto-part with that number in our records.",
                                "College Park Auto-Parts", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblPictureFile.Text = @"E:\College Park Auto-Parts\Generic.png";
                pbxPartImage.Image  = Image.FromFile(@"E:\College Park Auto-Parts\Generic.png");
            }

            Width  = pbxPartImage.Right  + 40;
            Height = pbxPartImage.Bottom + 75;
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            FileInfo fiFilePath;

            if (ofdPictureFile.ShowDialog() == DialogResult.OK)
            {
                fiFilePath         = new(ofdPictureFile.FileName);
                pbxPartImage.Image = Image.FromFile(ofdPictureFile.FileName);
            }
            else
            {
                fiFilePath         = new(@"E:\College Park Auto-Parts\Generic.png");
                pbxPartImage.Image = Image.FromFile(@"E:\College Park Auto-Parts\Generic.png");
            }

            lblPictureFile.Text = fiFilePath.Name;
            Width               = pbxPartImage.Right  + 40;
            Height              = pbxPartImage.Bottom + 75;
        }

        private void btnUpdateAutoPart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartNumber.Text))
            {
                MessageBox.Show("You must enter the part number of the store item.",
                                "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection cnnNewPart =
                   new SqlConnection("Data Source=(local);" +
                                     "Database=CollegeParkAutoParts2;" +
                                     "Integrated Security=SSPI;"))
            {
                SqlCommand cmdAutoPart =
                    new SqlCommand("UPDATE AutoParts SET CarYear   =   " + cbxYears.Text        + "  WHERE PartNumber = " + txtPartNumber.Text + ";" +
                                   "UPDATE AutoParts SET Make      = N'" + txtMake.Text         + "' WHERE PartNumber = " + txtPartNumber.Text + ";" +
                                   "UPDATE AutoParts SET Model     = N'" + txtModel.Text        + "' WHERE PartNumber = " + txtPartNumber.Text + ";" +
                                   "UPDATE AutoParts SET Category  = N'" + txtCategory.Text     + "' WHERE PartNumber = " + txtPartNumber.Text + ";" +
                                   "UPDATE AutoParts SET PartName  = N'" + txtPartName.Text     + "' WHERE PartNumber = " + txtPartNumber.Text + ";" +
                                   "UPDATE AutoParts SET PartImage = N'" + lblPictureFile.Text  + "' WHERE PartNumber = " + txtPartNumber.Text + ";" +
                                   "UPDATE AutoParts SET UnitPrice =   " + txtUnitPrice.Text    + "  WHERE PartNumber = " + txtPartNumber.Text + ";",
                                   cnnNewPart);

                cnnNewPart.Open();
                cmdAutoPart.ExecuteNonQuery();
                
                InitializeAutoPart();

                MessageBox.Show("The information about the auto part has been updated in the database.",
                                "College Park Auto-Parts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
