using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Ordering_A_Taxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonCancel.Enabled = false;
            buttonOrder.Enabled = false;
        }

        private void checkBoxIsTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsTrue.Checked == true) 
            {
                buttonCancel.Enabled = true;
                buttonOrder.Enabled = true;
            }
            else
            {
                buttonCancel.Enabled = false;
                buttonOrder.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been successfully cancelled", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var order = new Order()
            {
                Name = textBoxName.Text,
                NumberPhone = maskedTextBoxNumberPhone.Text,
                TypeOfTaxi = comboBoxTypeOfTaxi.Text,
                NumberOfPassengers = numericUpDownNumberOfPassengers.Value,
                Address = textBoxAddress.Text,
            };
            MessageBox.Show($"{order.ToString()}", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public class Order
        {
            public string Name { get; set; }
            public string NumberPhone { get; set; }
            public string TypeOfTaxi {  get; set; }
            public decimal NumberOfPassengers {  get; set; }
            public string Address {  get; set; }
            public override string ToString()
            {
                return $"Name order - {Name}\nPhone number - {NumberPhone}\nType of taxi - {TypeOfTaxi}\nNumber of passengers - {NumberOfPassengers}\nAddress - {Address}";
            }
        }
    }
}
