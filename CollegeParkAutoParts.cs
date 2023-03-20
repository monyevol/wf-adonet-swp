using System.Data;
using System.Data.SqlClient;
using CollegeParkAutoParts21.Models;

namespace CollegeParkAutoParts21
{
    public partial class CollegeParkAutoParts : Form
    {
        public CollegeParkAutoParts()
        {
            InitializeComponent();
        }

        // This function is used to reset the form
        void InitializeAutoParts()
        {
            // When the form must be reset, removes all nodes from the tree view
            tvwAutoParts.Nodes.Clear();
            // Create the root node of the tree view
            TreeNode nodRoot = tvwAutoParts.Nodes.Add("College Park Auto-Parts",
                                                      "College Park Auto-Parts", 0, 1);
            /* Add the cars years to the tree view.
             * Our application will deal only with the cars in the last 21 years. */
            for (int years = DateTime.Today.Year + 1; years >= DateTime.Today.Year - 20; years--)
                nodRoot.Nodes.Add(years.ToString(), years.ToString(), 2, 3);

            // Select the root node
            tvwAutoParts.SelectedNode = nodRoot;
            // Expand the root node
            tvwAutoParts.ExpandAll();

            // Create an empty data set
            DataSet dsParts = new DataSet("PartsSet");

            // Create a connection to the database
            using (SqlConnection scCollegeParkAutoParts =
                new SqlConnection("Data Source=(local);" +
                                  "Database=CollegeParkAutoParts2;" +
                                  "Integrated Security=SSPI;"))
            {
                // Use a command to specify what action we want to take
                SqlCommand cmdParts =
                new SqlCommand("SELECT CarYear, " +
                               "       Make, " +
                               "       Model, " +
                               "       Category " +
                               "FROM AutoParts;", scCollegeParkAutoParts);

                scCollegeParkAutoParts.Open();

                SqlDataAdapter sdaParts = new(cmdParts);

                sdaParts.Fill(dsParts);

                AutoPart? StoreItem = null;
                List<AutoPart> lstAutoParts = new();

                foreach (DataRow drPart in dsParts.Tables[0].Rows)
                {
                    StoreItem = new AutoPart();

                    StoreItem.PartNumber = 0;
                    StoreItem.CarYear    = int.Parse(drPart[0].ToString()!);
                    StoreItem.Make       =           drPart[1].ToString();
                    StoreItem.Model      =           drPart[2].ToString();
                    StoreItem.Category   =           drPart[3].ToString();
                    StoreItem.PartName   = string.Empty;
                    StoreItem.UnitPrice  = 0;
                    lstAutoParts.Add(StoreItem);
                }

                foreach (TreeNode nodYear in nodRoot.Nodes)
                {
                    List<string> lstMakes = new List<string>();

                    foreach (AutoPart part in lstAutoParts)
                    {
                        if (nodYear.Text == part.CarYear.ToString())
                        {
                            if (!lstMakes.Contains(part.Make!))
                                lstMakes.Add(part.Make!);
                        }
                    }

                    foreach (string strMake in lstMakes)
                        nodYear.Nodes.Add(strMake, strMake, 4, 5);
                }

                foreach (TreeNode nodYear in nodRoot.Nodes)
                {
                    foreach (TreeNode nodMake in nodYear.Nodes)
                    {
                        List<string> lstModels = new();

                        foreach (AutoPart part in lstAutoParts)
                        {
                            if ((nodYear.Text == part.CarYear.ToString()) &&
                                (nodMake.Text == part.Make))
                            {
                                if (!lstModels.Contains(part.Model!))
                                    lstModels.Add(part.Model!);
                            }
                        }

                        foreach (string strModel in lstModels)
                            nodMake.Nodes.Add(strModel, strModel, 6, 7);
                    }
                }

                foreach (TreeNode nodYear in nodRoot.Nodes)
                {
                    foreach (TreeNode nodMake in nodYear.Nodes)
                    {
                        foreach (TreeNode nodModel in nodMake.Nodes)
                        {
                            var lstCategories = new List<string>();

                            foreach (AutoPart part in lstAutoParts)
                            {
                                if ((nodYear.Text == part.CarYear.ToString()) &&
                                    (nodMake.Text == part.Make) &&
                                    (nodModel.Text == part.Model))
                                {
                                    if (!lstCategories.Contains(part.Category!))
                                        lstCategories.Add(part.Category!);
                                }
                            }

                            foreach (string strCategory in lstCategories)
                                nodModel.Nodes.Add(strCategory, strCategory, 8, 9);
                        }
                    }
                }
            }

            lvwSelectedParts.Items.Clear();
            lvwAvailableParts.Items.Clear();
            txtPartName.Text           = string.Empty;
            txtQuantity.Text           = string.Empty;
            txtSubTotal.Text           = string.Empty;
            txtUnitPrice.Text          = string.Empty;
            txtTaxAmount.Text          = string.Empty;
            txtOrderTotal.Text         = string.Empty;
            txtPartNumber.Text         = string.Empty;
            txtSelectedPartsTotal.Text = string.Empty;
            pbxPartImage.Image         = Image.FromFile(@"E:\College Park Auto-Parts\Generic.png");
        }
        
        private void CollegeParkAutoParts_Load(object sender, EventArgs e)
        {
            InitializeAutoParts();
        }

        private void tvwAutoParts_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode nodClicked = e.Node;

            if (nodClicked.Level == 4)
                lvwAvailableParts.Items.Clear();

            DataSet dsParts = new DataSet("PartsSet");

            using (SqlConnection scCollegeParkAutoParts =
                new SqlConnection("Data Source=(local);" +
                                  "Database=CollegeParkAutoParts2;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdParts =
                    new SqlCommand("SELECT PartNumber, " +
                                   "       CarYear,    " +
                                   "       Make,       " +
                                   "       Model,      " +
                                   "       Category,   " +
                                   "       PartName,   " +
                                   "       PartImage,  " +
                                   "       UnitPrice   " +
                                   "FROM   AutoParts;  ", scCollegeParkAutoParts);
                scCollegeParkAutoParts.Open();

                SqlDataAdapter sdaParts = new SqlDataAdapter(cmdParts);
                sdaParts.Fill(dsParts);

                AutoPart? storeItem = null;
                List<AutoPart> lstAutoParts = new List<AutoPart>();

                foreach (DataRow drPart in dsParts.Tables[0].Rows)
                {
                    storeItem            = new AutoPart();
                    storeItem.PartNumber =    int.Parse(drPart[0].ToString()!);
                    storeItem.CarYear    =    int.Parse(drPart[1].ToString()!);
                    storeItem.Make       =              drPart[2].ToString();
                    storeItem.Model      =              drPart[3].ToString();
                    storeItem.Category   =              drPart[4].ToString();
                    storeItem.PartName   =              drPart[5].ToString();
                    storeItem.PartImage  =              drPart[6].ToString();
                    storeItem.UnitPrice  = double.Parse(drPart[7].ToString()!);
                    lstAutoParts.Add(storeItem);
                }

                try
                {
                    foreach (AutoPart part in lstAutoParts)
                    {
                        if ((part.Category           == nodClicked.Text) &&
                            (part.Model              == nodClicked.Parent.Text) &&
                            (part.Make               == nodClicked.Parent.Parent.Text) &&
                            (part.CarYear.ToString() == nodClicked.Parent.Parent.Parent.Text))
                        {
                            ListViewItem lviAutoPart = new ListViewItem(part.PartNumber.ToString());

                            lviAutoPart.SubItems.Add(part.PartName);
                            lviAutoPart.SubItems.Add(part.UnitPrice.ToString("F"));
                            lvwAvailableParts.Items.Add(lviAutoPart);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
            }
        }

        private void lvwAvailableParts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool    pictureFound = false;
            DataSet dsParts      = new("PartsSet");

            using (SqlConnection scCollegeParkAutoParts =
                new SqlConnection("Data Source=(local);" +
                                  "Database=CollegeParkAutoParts2;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdParts =
                    new SqlCommand("SELECT PartNumber, " +
                                   "       PartImage " +
                                   "FROM   AutoParts;", scCollegeParkAutoParts);

                scCollegeParkAutoParts.Open();

                SqlDataAdapter sdaParts = new SqlDataAdapter(cmdParts);

                sdaParts.Fill(dsParts);

                AutoPart? storeItem = null;
                List<AutoPart> lstAutoParts = new();

                foreach (DataRow drPart in dsParts.Tables[0].Rows)
                {
                    storeItem = new AutoPart();
                    storeItem.PartNumber = int.Parse(drPart[0].ToString()!);
                    storeItem.CarYear    = 0;
                    storeItem.Make       = string.Empty;
                    storeItem.Model      = string.Empty;
                    storeItem.Category   = string.Empty;
                    storeItem.PartName   = string.Empty;
                    storeItem.PartImage  = drPart[1].ToString();
                    storeItem.UnitPrice  = 0.00;
                    lstAutoParts.Add(storeItem);
                }

                foreach (AutoPart part in lstAutoParts)
                {
                    if (part.PartNumber == long.Parse(e.Item!.SubItems[0].Text))
                    {
                        pictureFound       = true;
                        pbxPartImage.Image = Image.FromFile(@"E:\College Park Auto-Parts\" + part.PartImage!);
                        break;
                    }
                }
            }

            if (pictureFound == false)
            {
                pbxPartImage.Image = Image.FromFile(@"E:\College Park Auto-Parts\Generic.png");
            }

            Width  = pbxPartImage.Right  + 40;
            Height = pbxPartImage.Bottom + 75;
        }

        private void lvwAvailableParts_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lviAutoPart = lvwAvailableParts.SelectedItems[0];

            if ((lvwAvailableParts.SelectedItems.Count == 0) ||
                (lvwAvailableParts.SelectedItems.Count > 1))
                return;

            txtPartNumber.Text = lviAutoPart.Text;
            txtPartName.Text   = lviAutoPart.SubItems[1].Text;
            txtUnitPrice.Text  = lviAutoPart.SubItems[2].Text;

            txtQuantity.Text   = "1";
            txtSubTotal.Text   = lviAutoPart.SubItems[2].Text;

            txtQuantity.Focus();
        }

        private void txtUnitPrice_Leave(object sender, EventArgs e)
        {
            double unitPrice = 0D;
            double quantity  = 0.00d;

            try
            {
                unitPrice = double.Parse(txtUnitPrice.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Unit Price!",
                                "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                quantity = int.Parse(txtQuantity.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Quandtity!",
                                "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            double subTotal = unitPrice * quantity;
            txtSubTotal.Text = subTotal.ToString("F");
        }

        internal void CalculateOrder()
        {
            // Calculate the current total order and update the order
            double partsTotal = 0.00D;
            double taxRate    = 0.00D;

            if (string.IsNullOrEmpty(txtTaxRate.Text))
                txtTaxRate.Text = "7.25";

            foreach (ListViewItem lviPart in lvwSelectedParts.Items)
            {
                ListViewItem.ListViewSubItem SubItem = lviPart.SubItems[4];
                partsTotal += double.Parse(SubItem.Text);
            }

            try
            {
                taxRate = double.Parse(txtTaxRate.Text) / 100;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Tax Rate",
                                "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            double taxAmount = partsTotal * taxRate;
            double orderTotal = partsTotal + taxAmount;

            txtSelectedPartsTotal.Text = partsTotal.ToString("F");
            txtTaxAmount.Text          = taxAmount.ToString("F");
            txtOrderTotal.Text         = orderTotal.ToString("F");
        }

        private void txtPartNumber_Leave(object sender, EventArgs e)
        {
            bool    found   = false;
            DataSet dsParts = new("PartsSet");

            using (SqlConnection scCollegeParkAutoParts =
                new SqlConnection("Data Source=(local);" +
                                  "Database=CollegeParkAutoParts2;" +
                                  "Integrated Security=SSPI;"))
            {
                SqlCommand cmdParts = new SqlCommand("SELECT PartNumber, " +
                                                     "       PartName, " +
                                                     "       UnitPrice " +
                                                     "FROM   AutoParts;", scCollegeParkAutoParts);

                scCollegeParkAutoParts.Open();

                SqlDataAdapter sdaParts = new SqlDataAdapter(cmdParts);

                sdaParts.Fill(dsParts);

                /* After the user had entered a part number,
                 * check the whole list of parts */
                foreach (DataRow drPart in dsParts.Tables[0].Rows)
                {
                    // If you find a part that holds the number the user had entered
                    if (drPart[0].ToString()!.Equals(txtPartNumber.Text))
                    {
                        // Show the corresponding part name and unit price
                        txtPartName.Text = drPart[1].ToString()!;
                        txtUnitPrice.Text = double.Parse(drPart[2].ToString()!).ToString("F");
                        
                        if (string.IsNullOrEmpty(txtQuantity.Text))
                            txtQuantity.Text = "1";
                        
                        txtSubTotal.Text = double.Parse(drPart[2].ToString()!).ToString("F");
                        // Give focus to the quantity in case the user was to increase it
                        txtQuantity.Focus();
                        
                        // And update the flag that specifies that the part has been found
                        found = true;
                        break;
                    }
                    // If the part number was not found, check the next
                } // If no part has that number, the found flag is marked as false
            }

            // If no part with that number was found...
            if (found == false)
            {
                // Since no part with that number was found,
                // reset the text boxes
                txtPartName.Text  = "";
                txtUnitPrice.Text = "0.00";
                txtQuantity.Text  = "0";
                txtSubTotal.Text  = "0.00";

                // Let the user know that the part number that 
                // was entered is not in the list
                MessageBox.Show("There is no part with that number.",
                            "College Park Auto-Parts",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPartNumber.Text))
            {
                MessageBox.Show("There is no part to be added to the order.",
                                "College Park Auto-Parts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem lviSelectedPart = new ListViewItem(txtPartNumber.Text);
            
            lviSelectedPart.SubItems.Add(txtPartName.Text);
            lviSelectedPart.SubItems.Add(txtUnitPrice.Text);
            lviSelectedPart.SubItems.Add(txtQuantity.Text);
            lviSelectedPart.SubItems.Add(txtSubTotal.Text);
            
            lvwSelectedParts.Items.Add(lviSelectedPart);

            txtPartNumber.Text = txtPartName.Text = txtUnitPrice.Text = txtQuantity.Text = txtSubTotal.Text = string.Empty;
            CalculateOrder();
        }

        private void lvwSelectedParts_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lviSelectedPart = lvwSelectedParts.SelectedItems[0];

            if ((lvwSelectedParts.SelectedItems.Count == 0) ||
                (lvwSelectedParts.SelectedItems.Count > 1))
                return;

            txtPartNumber.Text = lviSelectedPart.Text;
            txtPartName.Text   = lviSelectedPart.SubItems[1].Text;
            txtUnitPrice.Text  = lviSelectedPart.SubItems[2].Text;
            txtQuantity.Text   = lviSelectedPart.SubItems[3].Text;
            txtSubTotal.Text   = lviSelectedPart.SubItems[4].Text;

            lvwSelectedParts.Items.Remove(lviSelectedPart);
        }

        private void btnNewAutoPart_Click(object sender, EventArgs e)
        {
            StoreItemNew sin = new StoreItemNew();

            sin.ShowDialog();

            InitializeAutoParts();
        }

        private void btnUpdateAutoPart_Click(object sender, EventArgs e)
        {
            StoreItemEditor sie = new StoreItemEditor();

            sie.ShowDialog();

            InitializeAutoParts();
        }

        private void btnDeleteAutoPart_Click(object sender, EventArgs e)
        {
            StoreItemDelete sid = new StoreItemDelete();

            sid.ShowDialog();

            InitializeAutoParts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}