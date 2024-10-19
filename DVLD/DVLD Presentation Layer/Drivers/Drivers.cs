using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void ListDrivers()
        {
            DataTable DTDrivers = clsDriver.ListDrivers();

            foreach (DataRow DR in DTDrivers.Rows)
            {
                DGVListDrivers.Rows.Add(DR["DriverID"], DR["PersonID"], DR["NationalNo"], DR["FullName"],
                DR["CreatedDate"], DR["NumberOfActiveLicenses"]);
            }

        }

        private void txbSearchByWord_TextChanged(object sender, EventArgs e)
        {
            if (txbSearchByWord.Text == "")
            {
                ListDrivers();
                return;
            }

            DataTable DTDrivers = clsDriver.SearchByWord(cobFilterDrives.Text, txbSearchByWord.Text);

            if (!DTDrivers.HasErrors)
            {
                DGVListDrivers.Rows.Clear();
            }

            foreach (DataRow DR in DTDrivers.Rows)
            {
                DGVListDrivers.Rows.Add(DR["DriverID"], DR["PersonID"], DR["NationalNo"], DR["FullName"],
                DR["CreatedDate"], DR["NumberOfActiveLicenses"]);
            }

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            cobFilterDrives.SelectedIndex = 0;
            ListDrivers();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
