using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verkopersprovisie
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Employee> employees;
        private Dictionary<int, Product> products;
        private List<string> soldProductsList;
        private Product _productChair;
        private Product _productSofa;
        private Product temProduct;
        private Employee tempEmployee;
        private double _revenue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employees = new Dictionary<int, Employee>();
            products = new Dictionary<int, Product>();
            soldProductsList = new List<string>();

            employees.Add(1, new Employee("John Deer", 0, 0));
            employees.Add(2, new Employee("John Dough", 0, 0));

            _productChair = new Product("Chair", "", 13, 0, Convert.ToDateTime("1/1/1"));
            _productSofa = new Product("Sofa", "", 15, 0, Convert.ToDateTime("1/1/1"));

            products.Add(1, _productChair);
            products.Add(2, _productSofa);

            // Displays property
            listBoxEmplpoyees.DataSource = employees.Values.ToList();
            listBoxEmplpoyees.DisplayMember = "Value.ToString()";

            // Displays property
            listBoxProduct.DataSource = products.Values.ToList();
            listBoxProduct.DisplayMember = "Value.ToString()";

            // Fills numericupdowns
            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year;
                control.Minimum = DateTime.Today.Year - 1;
                control.Value = DateTime.Today.Year;
            }

            foreach (NumericUpDown control in panelMonth.Controls)
            {
                control.Maximum = 12;
                control.Minimum = 1;
                control.Value = DateTime.Today.Month;
            }

            foreach (NumericUpDown control in panelDay.Controls)
            {
                control.Maximum = 31;
                control.Minimum = 1;
                control.Value = DateTime.Today.Day;
            }

            numericUpDownAmount.Maximum = 1000000;

            // Displays calculation, total
            labelTicketsTotal.Text = $@"(revenue * 3% + € 4 * units sold) * extra %";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_revenue, 2):0.00},-";

            double test = 2999;
            test = Math.Floor(test / 1000);
            test = 0.02 * test;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            temProduct = (Product)listBoxProduct.SelectedItem;
            tempEmployee = (Employee)listBoxEmplpoyees.SelectedItem;

            // Checks if date is valid
            if (ValidateDate((int)numericUpDownDay1.Value, (int)numericUpDownMonth1.Value, (int)numericUpDownYear1.Value))
            {
                if (!soldProductsList.Contains(temProduct.ToString()))
                {
                    //sets product number "key + year"
                    foreach (KeyValuePair<int, Product> entry in products)
                    {
                        entry.Value.ProductNumber = entry.Key.ToString("00") + entry.Value.SaleDate.Year.ToString();
                    }

                    temProduct.UnitsSold = (int)numericUpDownAmount.Value;
                    temProduct.SaleDate = Convert.ToDateTime($"{(int)numericUpDownDay1.Value}/{(int)numericUpDownMonth1.Value}/{(int)numericUpDownYear1.Value}");
                    soldProductsList.Add(temProduct.ToString());

                    // Displays name property
                    listBoxEmplpoyees.DataSource = employees.Values.ToList();
                    listBoxEmplpoyees.DisplayMember = "Value.ToString()";

                    // Displays name property
                    listBoxProduct.DataSource = products.Values.ToList();
                    listBoxProduct.DisplayMember = "Value.ToString()";

                    // Displays properties
                    listBoxSold.DataSource = null;
                    listBoxSold.DataSource = soldProductsList;
                    listBoxSold.DisplayMember = "Value";
                }
            }
            else
            {
                MessageBox.Show($"Please select the correct day of the month \nselected date <= current date");
            }
        }

        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            // Checks if listbox is filled
            if (listBoxSold.Items.Count > 0)
            {
                string key = listBoxSold.SelectedItem.ToString();
                int indexStart = key.IndexOf("Product Number:")+15;
                int indexEnd = key.IndexOf("Price:")-6;
                int lenght = indexEnd - indexStart;
                key = key.Substring(indexStart, lenght);

                temProduct = products[Convert.ToInt32(key)];
                tempEmployee = (Employee)listBoxEmplpoyees.SelectedItem;
                //string tempProductString = listBoxSold

                if (temProduct.UnitsSold > 0 && (int)numericUpDownAmount.Value <= temProduct.UnitsSold)
                {
                    soldProductsList.Remove(temProduct.ToString());
                    temProduct.SaleDate = Convert.ToDateTime($"1/1/1");
                    temProduct.UnitsSold -= (int)numericUpDownAmount.Value;

                    // Displays name property
                    listBoxEmplpoyees.DataSource = employees.Values.ToList();
                    listBoxEmplpoyees.DisplayMember = "Value.ToString()";

                    // Displays name property
                    listBoxProduct.DataSource = products.Values.ToList();
                    listBoxProduct.DisplayMember = "Value.ToString()";

                    // Displays properties
                    listBoxSold.DataSource = null;
                    listBoxSold.DataSource = soldProductsList;
                    listBoxSold.DisplayMember = "Value";
                }
                else
                {
                    MessageBox.Show($"the units sold {temProduct.UnitsSold} must be > 0 & selected value {numericUpDownAmount.Value} <= units sold {temProduct.UnitsSold}");
                }
            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            ButtonReset_Click(buttonReset, EventArgs.Empty);
            List<string>chairs = new List<string>();
            List<string>sofas = new List<string>();
            numericUpDownAmount.Value = 1;
            int level;
            bool level1 = false;
            bool level2 = false;
            string tempString = "";
            string date = "";
            string name = "";
            double price = 0;
            int months = 0;
            double difference = 0;
            int unitsPerYear = 0;
            int chairsPerMonth = 0;
            int sofasPerMonth = 0;
            _revenue = 0;

            if (soldProductsList.Count > 0)
            {
                // Checks if units are sold within the same month
                foreach (string product in soldProductsList)
                {
                    tempString = product;
                    
                    int indexStart = tempString.IndexOf("Sold:")+5;
                    int indexEnd = tempString.Length;
                    int lenght = indexEnd - indexStart;
                    date = tempString.Substring(indexStart, lenght);
                    DateTime tempDate = Convert.ToDateTime(date);
                    months = ((DateTime.Now.Year - tempDate.Year) * 12) + DateTime.Now.Month - tempDate.Month;
                    if (months == 0)
                    {
                        months = 1;
                    }
                    
                    indexStart = tempString.IndexOf("Name:")+5;
                    indexEnd = tempString.IndexOf("Product Number:")-2;
                    lenght = indexEnd - indexStart;
                    name = tempString.Substring(indexStart, lenght);
                    
                    indexStart = tempString.IndexOf("Price:")+6;
                    indexEnd = tempString.IndexOf("Amount:")-2;
                    lenght = indexEnd - indexStart;
                    price = Convert.ToDouble(tempString.Substring(indexStart, lenght));

                    
                    if (months == 1)
                    {
                        switch (name)
                        {
                            case "Chair":
                                tempString = product;
                                indexStart = tempString.IndexOf("Amount:")+7;
                                indexEnd = tempString.IndexOf("Sold:")-2;
                                lenght = indexEnd - indexStart;
                                chairsPerMonth += Convert.ToInt32(tempString.Substring(indexStart, lenght));
                                
                                break;
                            case "Sofa":
                                tempString = product;
                                indexStart = tempString.IndexOf("Amount:")+7;
                                indexEnd = tempString.IndexOf("Sold:")-2;
                                lenght = indexEnd - indexStart;
                                sofasPerMonth += Convert.ToInt32(tempString.Substring(indexStart, lenght));
                                break;
                        }
                    }
                    
                    if (months <= 12)
                    {
                        indexStart = tempString.IndexOf("Amount:")+7;
                        indexEnd = tempString.IndexOf("Sold:")-2;
                        lenght = indexEnd - indexStart;
                        unitsPerYear += Convert.ToInt32(tempString.Substring(indexStart, lenght));
                    }
                }
                
                // Calculates revenue per month
                _revenue += chairsPerMonth * _productChair.Price + sofasPerMonth * _productSofa.Price;

                // Checks which level unitsperyear is in and check which calculations must be made
                if (unitsPerYear > 20001)
                {
                    level2 = true;
                    level1 = true;
                    level = 20000;

                    difference = (unitsPerYear - level);
                    difference = Math.Floor(difference / 1000);
                    difference = 0.02 * difference;
                    tempEmployee.Extra += difference;
                }

                if (unitsPerYear < 20000 && unitsPerYear >= 10001 || level2)
                {
                    level1 = true;
                    level = 10000;

                    if (level2)
                    {
                        difference = (20001 - level);
                        difference = Math.Floor(difference / 1000);
                        difference = 0.015 * difference;
                        tempEmployee.Extra += difference;
                    }
                    else
                    {
                        difference = (unitsPerYear - level);
                        difference = Math.Floor(difference / 1000);
                        difference = 0.015 * difference;
                        tempEmployee.Extra += difference;
                    }
                }

                if (unitsPerYear <= 10000 || level1)
                {
                    if (level1)
                    {
                        difference = Math.Floor((double)10000 / 1000);
                        difference = 0.01 * difference;
                        tempEmployee.Extra += difference;
                    }
                    else
                    {
                        difference = Math.Floor((double)unitsPerYear / 1000);
                        difference = 0.01 * difference;
                        tempEmployee.Extra += difference;
                    }
                    tempEmployee.Extra += 1;
                }

                if (tempEmployee.Extra > 1.50)
                {
                    tempEmployee.Extra = 1.50;
                }

                tempEmployee.Commission += (_revenue * 0.03 + 4 * (chairsPerMonth + sofasPerMonth))* tempEmployee.Extra;

                labelTicketsTotal.Text = $@"(revenue {_revenue}* 3% + € 4 * units sold {unitsPerYear}) * extra {(tempEmployee.Extra-1)*100}%";
                labelPriceTotal.Text = $@"Totaal: € {Math.Round(tempEmployee.Commission, 2):0.00},-";
            }
            else
            {
                MessageBox.Show("You must have ordered any product.");
            }
            
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // Fills numericupdowns
            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year;
                control.Minimum = DateTime.Today.Year - 1;
                control.Value = DateTime.Today.Year;
            }

            foreach (NumericUpDown control in panelMonth.Controls)
            {
                control.Maximum = 12;
                control.Minimum = 1;
                control.Value = DateTime.Today.Month;
            }

            foreach (NumericUpDown control in panelDay.Controls)
            {
                control.Maximum = 31;
                control.Minimum = 1;
                control.Value = DateTime.Today.Day;
            }

            foreach (KeyValuePair<int, Employee> entry in employees)
            {
                entry.Value.Commission = 0;
                entry.Value.Extra = 0;
            }

            foreach (KeyValuePair<int, Product> entry in products)
            {
                entry.Value.UnitsSold = 0;
                entry.Value.SaleDate = Convert.ToDateTime($"1/1/1");
                entry.Value.ProductNumber = "";
            }
        }

        private bool ValidateDate(int day, int month, int year)
        {
            int checkDay = DateTime.DaysInMonth(year, month);

            if ((int)numericUpDownDay1.Value <= checkDay)
            {
                if (Convert.ToDateTime($"{day}/{month}/{year}")<=DateTime.Now.Date)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
    }
}
