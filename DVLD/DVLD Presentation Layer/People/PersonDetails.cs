using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonDetails : Form
    {
        private int _PersonID;

        public PersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        public void PersonDetails_Load(object sender, EventArgs e)
        {
 
            ctrlPersonInformation1.LaodDataPerson(_PersonID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
