using System.Data;
using System.Data.SqlClient;

namespace CollegeParkAutoParts21
{
    public partial class StoreItemDelete : Form
    {
        public StoreItemDelete()
        {
            InitializeComponent();
        }

        private void InitializeAutoPart()
        {
            txtYear.Text        = string.Empty;
            txtMake.Text        = string.Empty;
            txtModel.Text       = string.Empty;
            txtCategory.Text    = string.Empty;
            txtPartName.Text    = string.Empty;
            txtUnitPrice.Text   = string.Empty;
            txtPartNumber.Text  = string.Empty;

            lblPictureFile.Text = "Generic.png";
            pbxPartImage.Image  = Image.FromFile(@"E:\College Park Auto-Parts\Generic.png");

            Width               = pbxPartImage.Right  + 40;
            Height              = pbxPartImage.Bottom + 75;
        }

        private void StoreItemDelete_Load(object sender, EventArgs e)
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
            DataSet dsParts    = new("AutoPartsSet");

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
                    if (drPart[0].ToString()!.Equals(txtPartNumber.Text))
                    {
                        foundAutoPart = true;

                        txtYear.Text        = drPart[1].ToString();
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

            Width = pbxPartImage.Right + 40;
            Height = pbxPartImage.Bottom + 75;
        }

        private void btnDeleteAutoPart_Click(object sender, EventArgs e)
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
                    new SqlCommand("DELETE FROM AutoParts " +
                                   "WHERE PartNumber = " + txtPartNumber.Text + ";",
                                   cnnNewPart);

                cnnNewPart.Open();
                cmdAutoPart.ExecuteNonQuery();

                InitializeAutoPart();

                MessageBox.Show("The part has been deleted from the database.", "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
