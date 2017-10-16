//Weapon shop by Marshall Park, October 16th 2017
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
    public partial class form1 : Form
    {
        //Global Constants
        const double CLAYMORE_PRICE = 250.00;
        const double TAX = 1.13;
        const double GLADIUS_PRICE = 175.00;
        const double KHOPESH_PRICE = 215.00;
        const double KATANA_PRICE = 190.00;

        //Global Variables
        int claymore;
        int gladius;
        int khopesh;
        int katana;
        double totalclayPrice;
        double totalgladPrice;
        double totalkhoPrice;
        double totalkatPrice;
        double totalPrice;

        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Inputs
                claymore = Convert.ToInt16(clayInput.Text);
                gladius = Convert.ToInt16(gladInput.Text);
                katana = Convert.ToInt16(katanInput.Text);
                khopesh = Convert.ToInt16(khoInput.Text);

                //Calculations
                totalclayPrice = CLAYMORE_PRICE + (TAX * claymore);
                totalgladPrice = GLADIUS_PRICE + (TAX * gladius);
                totalkhoPrice = KHOPESH_PRICE + (TAX * khopesh);
                totalkatPrice = KATANA_PRICE + (TAX * katana);
                totalPrice = totalclayPrice + totalgladPrice + totalkhoPrice + totalkatPrice;

                //Outputs
                outputLabel.Text = "The price of your sword(s) is:" + totalPrice.ToString("C");
            }
            catch
            {
                outputLabel.Text = "Ouch! You stabbed me";
            }
        }

        
    }
}
        