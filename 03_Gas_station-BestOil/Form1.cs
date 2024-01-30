using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Gas_station_BestOil
{
    public partial class Form1 : Form
    {
        private static double OrderValueHotDog = 0;
        private static double OrderValueHamburger = 0;
        private static double OrderValueFries = 0;
        private static double OrderValueCocaCola = 0;
        private Timer timer;
        private int elapsedTimeInSeconds;
        private static double RevenuePerDay = 0;
        private static int NumberOfClients = 0;
        public Form1()
        {
            InitializeComponent();
            textBoxPrice.ReadOnly = true;
            comboBoxBenzine.SelectedIndex = 0;
            textBoxSum.Enabled = false;
            textBoxNumber.Enabled = false;
            textBoxHotDog.Enabled = false;
            textBoxHamburger.Enabled = false;
            textBoxFries.Enabled = false;
            textBoxCocaCola.Enabled = false;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            elapsedTimeInSeconds = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTimeInSeconds++;
            if (elapsedTimeInSeconds == 10)
            {
                if (MessageBox.Show("Очистити форму?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RevenuePerDay += double.Parse(labelPurchaseAmount.Text);
                    NumberOfClients++;
                    ClearForms(this);
                    elapsedTimeInSeconds = 0;
                    Timer_Stop();
                }
                else
                {
                    Timer_Stop();
                    elapsedTimeInSeconds = 0;
                    Timer_Start();
                }
            }
        }
        private void Timer_Start()
        {
            timer.Start();
        }
        private void Timer_Stop()
        {
            timer.Stop();
        }
        private void ClearForms(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (ctrl is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (ctrl is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                // Рекурсивно викликаємо метод для всіх контейнерів (GroupBox, Panel і т. д.), які можуть містити елементи
                if (ctrl.HasChildren)
                {
                    ClearForms(ctrl);
                }
            }
        }
        private void comboBoxBenzine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBenzine.SelectedIndex == 0)
                textBoxPrice.Text = "54,25";
            if (comboBoxBenzine.SelectedIndex == 1)
                textBoxPrice.Text = "50,76";
            if (comboBoxBenzine.SelectedIndex == 2)
                textBoxPrice.Text = "46,98";
            if (comboBoxBenzine.SelectedIndex == 3)
                textBoxPrice.Text = "50,81";
            if (comboBoxBenzine.SelectedIndex == 4)
                textBoxPrice.Text = "27,54";
            textBoxNumber_TextChanged(sender, e);
        }
        private void radioButtonNumber_Click(object sender, EventArgs e)
        {
            groupBoxAZSOrderSum.Text = "До оплати:";
            textBoxNumber.Enabled = true;
            textBoxSum.Enabled = false;
            labelCurrency.Text = "Грн.";
            textBoxNumber_TextChanged(sender, e);
        }

        private void radioButtonSum_Click(object sender, EventArgs e)
        {
            groupBoxAZSOrderSum.Text = "До видачі:";
            textBoxNumber.Enabled = false;
            textBoxSum.Enabled = true;
            labelCurrency.Text = "Л.";
            textBoxSum_TextChanged(sender, e);
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                if (double.TryParse(textBoxNumber.Text, out double result))
                {
                    var sumOrder = double.Parse(textBoxPrice.Text) * double.Parse(textBoxNumber.Text);
                    labelCurrency.Text = "Грн.";
                    labelAZSSum.Text = sumOrder.ToString();
                }
                else
                {
                    textBoxNumber.Text = textBoxNumber.Text.Remove(textBoxNumber.Text.Length-1);
                    MessageBox.Show("Ви ввели неправильне значення", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                labelAZSSum.Text = "0,00";
            }
        }
        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSum.Text))
            {
                if (double.TryParse(textBoxSum.Text, out double result))
                {
                    var sumOrder = double.Parse(textBoxSum.Text) / double.Parse(textBoxPrice.Text);
                    labelCurrency.Text = "Л.";
                    labelAZSSum.Text = sumOrder.ToString();
                }
                else
                {
                    textBoxSum.Text = textBoxSum.Text.Remove(textBoxSum.Text.Length - 1);
                    MessageBox.Show("Ви ввели неправильне значення", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                labelAZSSum.Text = "0,00";
            }
        }
        private void CheckSelectedCheckBoxes()
        {
            if (checkBoxHotDog.Checked)
            {
                textBoxHotDog.Enabled = true;
                string number = textBoxHotDog.Text;
                double price = double.Parse(labelHotDog.Text);
                if (!string.IsNullOrWhiteSpace(number))
                {
                    if (int.TryParse(number, out int result))
                    {
                        OrderValueHotDog = double.Parse(number) * price;
                    }
                    else
                    {
                        textBoxHotDog.Text = textBoxHotDog.Text.Remove(textBoxHotDog.Text.Length - 1);
                        MessageBox.Show("Ви ввели неправильне значення, введіть тільки - (Цілі числа)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OrderValueHotDog = 0;
                }
            }
            else if(!checkBoxHotDog.Checked)
            {
                textBoxHotDog.Enabled = false;
                OrderValueHotDog = 0;
            }
            if (checkBoxHamburger.Checked)
            {
                textBoxHamburger.Enabled = true;
                string number = textBoxHamburger.Text;
                double price = double.Parse(labelHamburger.Text);
                if (!string.IsNullOrWhiteSpace(number))
                {
                    if (int.TryParse(number, out int result))
                    {
                        OrderValueHamburger = double.Parse(number) * price;
                    }
                    else
                    {
                        textBoxHamburger.Text = textBoxHamburger.Text.Remove(textBoxHamburger.Text.Length - 1);
                        MessageBox.Show("Ви ввели неправильне значення, введіть тільки - (Цілі числа)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OrderValueHamburger = 0;
                }
            }
            else if (!checkBoxHamburger.Checked)
            {
                textBoxHamburger.Enabled = false;
                OrderValueHamburger = 0;
            }
            if (checkBoxFries.Checked)
            {
                textBoxFries.Enabled = true;
                string number = textBoxFries.Text;
                double price = double.Parse(labelFries.Text);
                if (!string.IsNullOrWhiteSpace(number))
                {
                    if (int.TryParse(number, out int result))
                    {
                        OrderValueFries = double.Parse(number) * price;
                    }
                    else
                    {
                        textBoxFries.Text = textBoxFries.Text.Remove(textBoxFries.Text.Length - 1);
                        MessageBox.Show("Ви ввели неправильне значення, введіть тільки - (Цілі числа)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OrderValueFries = 0;
                }
            }
            else if (!checkBoxFries.Checked)
            {
                textBoxFries.Enabled = false;
                OrderValueFries = 0;
            }
            if (checkBoxCocaCola.Checked)
            {
                textBoxCocaCola.Enabled = true;
                string number = textBoxCocaCola.Text;
                double price = double.Parse(labelCocaCola.Text);
                if (!string.IsNullOrWhiteSpace(number))
                {
                    if (int.TryParse(number, out int result))
                    {
                        OrderValueCocaCola = double.Parse(number) * price;
                    }
                    else
                    {
                        textBoxCocaCola.Text = textBoxCocaCola.Text.Remove(textBoxCocaCola.Text.Length - 1);
                        MessageBox.Show("Ви ввели неправильне значення, введіть тільки - (Цілі числа)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    OrderValueCocaCola = 0;
                }
            }
            else if(!checkBoxCocaCola.Checked)
            {
                textBoxCocaCola.Enabled = false;
                OrderValueCocaCola = 0;
            }
            double text = OrderValueHotDog + OrderValueHamburger + OrderValueFries + OrderValueCocaCola;
            labelCafeSum.Text = text.ToString();
        }                       
                                
        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void checkBoxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void checkBoxFries_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void checkBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void textBoxHotDog_TextChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void textBoxHamburger_TextChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void textBoxFries_TextChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void textBoxCocaCola_TextChanged(object sender, EventArgs e)
        {
            CheckSelectedCheckBoxes();
        }

        private void buttonTotalBillAmount_Click(object sender, EventArgs e)
        {
            labelPurchaseAmount.Text = (double.Parse(labelCafeSum.Text) + double.Parse(labelAZSSum.Text)).ToString();
            Timer_Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Виручка за день - {RevenuePerDay}Грн.\nКількість клієнтів - {NumberOfClients}", "Кінець робочого дня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

