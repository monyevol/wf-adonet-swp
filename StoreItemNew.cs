using System.Data;
using System.Data.SqlClient;
using CollegeParkAutoParts21.Models;

namespace CollegeParkAutoParts21
{
    public partial class StoreItemNew : Form
    {
        public StoreItemNew()
        {
            InitializeComponent();
        }

        /* This function is used to reset the form.
         * It can be called when necessary. */
        private void InitializeAutoParts()
        {
            // When this function is called, we want to reset all windows controls on the form.
            cbxYears.Items.Clear();
            cbxMakes.Items.Clear();
            cbxModels.Items.Clear();
            cbxCategories.Items.Clear();
            txtPartName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;

            cbxYears.Text = "";
            cbxMakes.Text = "";
            cbxModels.Text = "";
            cbxCategories.Text = "";
            txtPartName.Text = "";
            txtUnitPrice.Text = "0.00";

            /* Show the years in the Years combo box.
             * We will consider the cars made in the last 20 years. */
            for (int year = DateTime.Today.Year + 1; year >= DateTime.Today.Year - 20; year--)
                cbxYears.Items.Add(year);

            /* Normally, we will specify to the user what number to put in the part number.
             * As an option, we will provide a default random number for the auto-part.*/
            Random rndNumber = new();

            txtPartNumber.Text = rndNumber.Next(100000, 999999).ToString();

            // Prepare a data set object for the parts
            DataSet dsParts = new DataSet("PartsSet");

            // Establish a connection to the database
            using (SqlConnection scCollegeParkAutoParts =
                new SqlConnection("Data Source=(local);" +
                                  "Database=CollegeParkAutoParts2;" +
                                  "Integrated Security=SSPI;"))
            {
                /* Although the main table of our database contains many parts, when the 
                 * New Store Item form opens, we will populate the Makes combo box with 
                 * all the names of vehicles manufacturers that currently exist in the 
                 * database. We will also populate the Categories combo box with the 
                 * Categories that the user might have created (assuming the user had 
                 * already created a few records). 
                 * As a result, for this operation, from the AutoParts table, we will 
                 * need just the Make, the Model, and the Category fields. */
                SqlCommand cmdParts =
                    new SqlCommand("SELECT Make, " +
                                   "       Model, " +
                                   "       Category " +
                                   "FROM   AutoParts;", scCollegeParkAutoParts);
                cmdParts.CommandType = CommandType.Text;

                scCollegeParkAutoParts.Open();

                // Create a data adapter that will get the values from the table
                SqlDataAdapter sdaParts = new SqlDataAdapter(cmdParts);
                // Store those values in the data set
                sdaParts.Fill(dsParts);

                // Create an auto part object
                AutoPart? StoreItem = null;
                // Create an empty list of auto parts
                List<AutoPart> lstAutoParts = new List<AutoPart>();

                // Check each record from the (only) table in the data set
                foreach (DataRow row in dsParts.Tables[0].Rows)
                {
                    StoreItem = new();
                    StoreItem.PartNumber = 0;
                    StoreItem.CarYear = 1000;
                    StoreItem.Make = row[0].ToString();
                    StoreItem.Model = row[1].ToString();
                    StoreItem.Category = row[2].ToString();
                    StoreItem.PartName = string.Empty;
                    StoreItem.PartImage = string.Empty;
                    StoreItem.UnitPrice = 0.00;
                    // Once the record is ready, store it in the collection variable
                    lstAutoParts.Add(StoreItem);
                }

                // To avoid duplicate values in the combo boxes, 
                // we will use collection classes
                List<string> lstMakes = new List<string>();
                List<string> lstCategories = new List<string>();

                // Check the list of makes
                foreach (AutoPart part in lstAutoParts)
                {
                    // If the list doesn't yet contain the make, add it
                    if (!lstMakes.Contains(part.Make!))
                        lstMakes.Add(part.Make!);
                }

                // Once we have the list of makes, 
                // put them in the Make combo box
                foreach (string strMake in lstMakes)
                    cbxMakes.Items.Add(strMake);

                foreach (AutoPart part in lstAutoParts)
                {
                    if (!lstCategories.Contains(part.Category!))
                        lstCategories.Add(part.Category!);
                }

                foreach (string strCategory in lstCategories)
                    cbxCategories.Items.Add(strCategory);
            }

            lblPictureFile.Text = "Generic.png";
            Width               = pbxPartImage.Right + 40;
            Height              = pbxPartImage.Bottom + 75;
            pbxPartImage.Image  = Image.FromFile(@"E:\College Park Auto-Parts\Generic.png");
        }

        private void StoreItemNew_Load(object sender, EventArgs e)
        {
            InitializeAutoParts();
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

            lblPictureFile.Text    = fiFilePath.Name;
            Width                  = pbxPartImage.Right + 40;
            Height                 = pbxPartImage.Bottom + 75;
        }

        private void cbxMakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModels.Items.Clear();
            DataSet dsParts = new("PartsSet");

            using (SqlConnection scCollegeParkAutoParts =
                new SqlConnection("Data Source=(local);" +
                                  "Database=CollegeParkAutoParts2;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdParts = new SqlCommand("SELECT CarYear, " +
                                                     "       Make, " +
                                                     "       Model " +
                                                     "FROM   AutoParts;", scCollegeParkAutoParts);

                scCollegeParkAutoParts.Open();

                SqlDataAdapter sdaParts = new SqlDataAdapter(cmdParts);

                sdaParts.Fill(dsParts);

                AutoPart? StoreItem = null;
                List<AutoPart> lstAutoParts = new();

                foreach (DataRow row in dsParts.Tables[0].Rows)
                {
                    StoreItem = new AutoPart();
                    StoreItem.PartNumber = 0;
                    StoreItem.CarYear = int.Parse(row[0].ToString()!);
                    StoreItem.Make = row[1].ToString();
                    StoreItem.Model = row[2].ToString();
                    StoreItem.Category = string.Empty;
                    StoreItem.PartName = string.Empty;
                    StoreItem.PartImage = string.Empty;
                    StoreItem.UnitPrice = 0;
                    lstAutoParts.Add(StoreItem);
                }

                List<string> lstModels = new List<string>();

                foreach (AutoPart part in lstAutoParts)
                {
                    if ((part.CarYear == int.Parse(cbxYears.Text)) &&
                        (part.Make == cbxMakes.Text))
                    {
                        if (!lstModels.Contains(part.Model!))
                            lstModels.Add(part.Model!);
                    }
                }

                foreach (string strModel in lstModels)
                    cbxModels.Items.Add(strModel);
            }
        }

        private void btnNewMake_Click(object sender, EventArgs e)
        {
            MakeEditor editor = new MakeEditor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtMake.Text.Length > 0)
                {
                    string strMake = editor.txtMake.Text;

                    // Make sure the category is not yet in the list
                    if (cbxMakes.Items.Contains(strMake))
                    {
                        MessageBox.Show(strMake + " is already in the list.",
                                    "College Park Auto-Parts",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Since this is a new category, add it to the combox box
                        cbxMakes.Items.Add(strMake);
                    }

                    cbxMakes.Text = strMake;
                }
            }
        }

        private void btnNewModel_Click(object sender, EventArgs e)
        {
            ModelEditor editor = new ModelEditor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtModel.Text.Length > 0)
                {
                    string strModel = editor.txtModel.Text;

                    // Make sure the category is not yet in the list
                    if (cbxModels.Items.Contains(strModel))
                    {
                        MessageBox.Show(strModel + " is already in the list.",
                                    "College Park Auto-Parts",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Since this is a new category, add it to the combox box
                        cbxModels.Items.Add(strModel);
                    }

                    cbxModels.Text = strModel;
                }
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            CategoryEditor editor = new CategoryEditor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtCategory.Text.Length > 0)
                {
                    string strCategory = editor.txtCategory.Text;

                    // Make sure the category is not yet in the list
                    if (cbxCategories.Items.Contains(strCategory))
                    {
                        MessageBox.Show(strCategory + " is already in the list.",
                                    "College Park Auto-Parts",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Since this is a new category, add it to the combo box
                        cbxCategories.Items.Add(strCategory);
                    }

                    cbxCategories.Text = strCategory;
                }
            }
        }

        private void btnSaveAutoPart_Click(object sender, EventArgs e)
        {
            double unitPrice = 0.00;

            if(string.IsNullOrEmpty(txtPartNumber.Text))
            {
                MessageBox.Show("You must enter the part number of the store item.",
                                "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(string.IsNullOrEmpty(txtPartName.Text) )
            {
                MessageBox.Show("You must enter the name of the store item.",
                                "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(string.IsNullOrEmpty(txtUnitPrice.Text) )
            {
                MessageBox.Show("You must enter the unit price of the part.",
                            "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                unitPrice = double.Parse(txtUnitPrice.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Unit Price.",
                            "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (SqlConnection cnnNewPart =
                   new SqlConnection("Data Source=(local);" +
                                     "Database=CollegeParkAutoParts2;" +
                                     "Integrated Security=SSPI;"))
            {
                SqlCommand cmdAutoPart =
                    new SqlCommand("INSERT INTO AutoParts(" +
                                   "PartNumber, CarYear, Make, Model, Category, " +
                                   "PartName, PartImage, UnitPrice) VALUES(" + txtPartNumber.Text + ", " +
                                   cbxYears.Text + ", N'" + cbxMakes.Text + "', N'" +
                                   cbxModels.Text + "', N'" + cbxCategories.Text + "', N'" +
                                   txtPartName.Text + "', N'" + lblPictureFile.Text + "', " + unitPrice + ");",
                                   cnnNewPart);

                cnnNewPart.Open();
                cmdAutoPart.ExecuteNonQuery();

            InitializeAutoParts();

                MessageBox.Show("The new part has been added.", "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
