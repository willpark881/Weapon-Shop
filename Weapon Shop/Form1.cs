using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weapon_Shop
{
    public partial class Form1 : Form
    {
        //Global Constants
        const double CLAYMORE_PRICE = 250.00;
        const double TAX = 0.13;
        const double GLADIUS_PRICE = 175.00;
        const double KHOPESH_PRICE = 215.00;
        const double KATANA_PRICE = 190.00;

        //Global Variables
        int claymore;
        int gladius;
        int khopesh;
        int katana;
        double totalprice;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            claymore = Convert.ToInt16(clayInput.Text);

        }
    }
}
        