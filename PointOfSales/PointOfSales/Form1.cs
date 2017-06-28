using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace PointOfSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] productCost = new double[10];
        List<string> products = new List<string> () { "Shoe", "Glasses", "Books","Socks","Joggers"};
        List<double> productPrice = new List<double> () {20,12.5, 13, 9.5, 10 };
        double totalCost;
        double shippingCost;
        int x = 50, y= 289, z=1;
        int a = 10, b = 85, c = 10;
        int k = 0;
        double[] finalProducts = new double[10];
        double[] numericalValues = new double[10];

        // Implementation of Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult toExit;
            toExit = MessageBox.Show("Exit?", "PointOfSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (toExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Adds Item, Price to view and also adds respective checkbox to Items List
        private void addToList_Click(object sender, EventArgs e)
        {
            GroupBox box = new GroupBox();
            CheckBox checkBox = new CheckBox();
            NumericUpDown num = new NumericUpDown();

            num.Enabled = false;
            num.Size = new System.Drawing.Size(37, 20);
            num.Location = new System.Drawing.Point(b, a);
            num.Name = String.Concat("num", z);

            checkBox.Enabled = true;
            checkBox.Text = newItemName.Text;
            checkBox.Name = String.Concat("check", z);
            checkBox.Size = new System.Drawing.Size(56, 17);
            checkBox.Location = new System.Drawing.Point(c, a);

            //products.Add(box.Text);
            products.Add(newItemName.Text);
            productPrice.Add(Convert.ToDouble(newItemPrice.Text));
            checkBox.AutoSize = true;
            
            box.Location = new System.Drawing.Point(y, x);
            box.Size = new System.Drawing.Size(133, 35);
            box.Controls.Add(checkBox);
            box.Controls.Add(num);
            x = x +45;
            y = y + 1;     
            this.groupBox3.Controls.Add(box);

            string[] row = new string[] { newItemName.Text, String.Format("{0:C}", Convert.ToDouble(newItemPrice.Text)) };
            dataGridView1.Rows.Add(row);
            newItemName.Text = "";
            newItemPrice.Text = "";
        }

        // Enables numericUpDown on checking each CheckBox
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (shopShoe.Checked == true)
            {
                numericUpDown1.Enabled = true;
            }
        }

        private void shopGlasses_CheckedChanged(object sender, EventArgs e)
        {
            if (shopGlasses.Checked == true)
            {
                numericUpDown2.Enabled = true;
            }
        }

        private void shopBooks_CheckedChanged(object sender, EventArgs e)
        {
            if (shopBooks.Checked == true)
            {
                numericUpDown3.Enabled = true;
            }
        }

        private void shopSocks_CheckedChanged(object sender, EventArgs e)
        {
            if (shopSocks.Checked == true)
            {
                numericUpDown4.Enabled = true;
                numericUpDown4.Focus();
            }
        }

        private void shopJoggers_CheckedChanged(object sender, EventArgs e)
        {
            if (shopJoggers.Checked == true)
            {
                numericUpDown5.Enabled = true;
            }
        }
        
        //Resets all the existing on the form
        private void dataReset_Click(object sender, EventArgs e)
        {
            resetCheckboxes();
            resetNumValues();
            newItemName.Text = "";
            newItemPrice.Text = "";
            finalReceipt.Text = "";
            dataGridView1.Rows.Clear();

        }

        //Exporting the receipt to XML that can be seen in debug folder of bin
        private void exportToXml_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("MSGoods",
             new XElement("items", new XElement ("item", new XAttribute("itemName", products[0]), new XAttribute("count", numericalValues[0]), new XAttribute("cost", productCost[0])),
                                   new XElement ("item", new XAttribute("itemName", products[1]), new XAttribute("count", numericalValues[1]), new XAttribute("cost", productCost[1])),
                                   new XElement ("item", new XAttribute("itemName", products[2]), new XAttribute("count", numericalValues[2]), new XAttribute("cost", productCost[2])),
                                   new XElement ("item", new XAttribute("itemName", products[3]), new XAttribute("count", numericalValues[3]), new XAttribute("cost", productCost[3])),
                                   new XElement ("item", new XAttribute("itemName", products[4]), new XAttribute("count", numericalValues[4]), new XAttribute("cost", productCost[4]))),
             new XElement("ShippingCost",new XAttribute( "Cost", shippingCost)),
             new XElement("TotalCost", new XAttribute("FinalCost", totalCost)));

            xml.Save("XMLFile.xml");
        }

        //Resets checkboxes 
        private void resetCheckboxes() {
            shopShoe.Checked = false;
            shopGlasses.Checked = false;
            shopBooks.Checked = false;
            shopSocks.Checked = false;
            shopJoggers.Checked = false;
        }

        //Resets numericUpDown Values
        private void resetNumValues() {

            numericUpDown1.Enabled = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Enabled = false;
            numericUpDown2.Value = 0;
            numericUpDown3.Enabled = false;
            numericUpDown3.Value = 0;
            numericUpDown4.Enabled = false;
            numericUpDown4.Value = 0;
            numericUpDown5.Enabled = false;
            numericUpDown5.Value = 0;
        }

        //After adding things to Cart, this prints the receipt to textArea
        private void addTotal_Click(object sender, EventArgs e)
        {

            numericalValues[0] = Convert.ToDouble(numericUpDown1.Value);
            numericalValues[1] = Convert.ToDouble(numericUpDown2.Value);
            numericalValues[2] = Convert.ToDouble(numericUpDown3.Value);
            numericalValues[3] = Convert.ToDouble(numericUpDown4.Value);
            numericalValues[4] = Convert.ToDouble(numericUpDown5.Value);

            productCost[0] = numericalValues[0] * productPrice.ElementAt(0);
            productCost[1] = numericalValues[1] * productPrice.ElementAt(1);
            productCost[2] = numericalValues[2] * productPrice.ElementAt(2);
            productCost[3] = numericalValues[3] * productPrice.ElementAt(3);
            productCost[4] = numericalValues[4] * productPrice.ElementAt(4);


            productCost[9] = productCost[0] + productCost[1] + productCost[2] + productCost[3] + productCost[4];

            finalReceipt.AppendText("\t\t" + "MS Goods" + Environment.NewLine+"\n\n");
            finalReceipt.AppendText("************************************************" + Environment.NewLine+ "\n\n");
            for (int i = 0; i < products.Count; i++)
            {
                if (productCost[i] != 0)
                {
                    finalReceipt.AppendText("\t" + products.ElementAt(i) + ":"+String.Format("{0:C}",productCost[i]) + Environment.NewLine+ "\n\n");
                    
                    finalProducts[k] = productCost[i];
                    k++;
                }
            }

            if (productCost[9] != 0) {

                shippingCost = 10.0;
            }

            finalReceipt.AppendText("************************************************" + Environment.NewLine+"\n\n");
            finalReceipt.AppendText("\t" + "Shipping Cost" + ":" + String.Format("{0:C}", shippingCost)+ Environment.NewLine+ "\n\n");
            totalCost = shippingCost + productCost[9];
            finalReceipt.AppendText("\t" + "Total Cost" + ":" + String.Format("{0:C}", totalCost) + Environment.NewLine+ "\n\n");
            finalReceipt.AppendText("\t\t"+"------******--------" + Environment.NewLine + "\n\n");
            resetNumValues();
            resetCheckboxes();

        }

       
    }
}
