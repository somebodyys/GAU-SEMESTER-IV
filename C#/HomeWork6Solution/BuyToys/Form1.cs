using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyToys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (toyRadio.Checked && !toyName.Text.Equals(""))
            {
                Toy newToy = new Toy(toyName.Text, toyPrice.Value);
                newToy.Buy();
            }

            if(cuddlyRadio.Checked && !toyName.Text.Equals(""))
            {
                CuddlyToy newToy = new CuddlyToy(toyName.Text, toyPrice.Value);
                newToy.Buy();
            }

            itemCount.Text = Convert.ToString(Toy.Toys.Count);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (Toy myToy in Toy.Toys)
            {
                result += $"{myToy.Description}\n";
            }
            MessageBox.Show(result.Trim(), "Purchases");
        }
    }
}
