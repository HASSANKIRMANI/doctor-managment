using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class ginsoy : sample
    {
        public ginsoy()
        {
            InitializeComponent();
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab("tabPage2");
            int qty;
            double cost;
            string dcost;

            if (checkBox35.Checked == true)
            {
                ListViewItem item = new ListViewItem("Classic Chilli Chicken");
                item.SubItems.Add(textBox28.Text);
                qty = Convert.ToInt32(textBox28.Text);
                cost = qty * 499;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
                if (textBox28.Text == "")
                {
                    DialogResult dialog = MessageBox.Show("Quantity is required!");
                }
            }
            else if (checkBox34.Checked == true)
            {
                ListViewItem item = new ListViewItem("Dragon Chicken");
                item.SubItems.Add(textBox27.Text);
                qty = Convert.ToInt32(textBox27.Text);
                cost = qty * 500;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox33.Checked == true)
            {
                ListViewItem item = new ListViewItem("Tendergrill Chicken");
                item.SubItems.Add(textBox26.Text);
                qty = Convert.ToInt32(textBox26.Text);
                cost = qty * 510;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox32.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Manchurian");
                item.SubItems.Add(textBox25.Text);
                qty = Convert.ToInt32(textBox25.Text);
                cost = qty * 510;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox31.Checked == true)
            {
                ListViewItem item = new ListViewItem("Classis Pepper Manchurian");
                item.SubItems.Add(textBox24.Text);
                qty = Convert.ToInt32(textBox24.Text);
                cost = qty * 500;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }

            //deals
            if (checkBox38.Checked == true)
            {
                ListViewItem item = new ListViewItem("Black Pepper Chicken");
                item.SubItems.Add(textBox31.Text);
                qty = Convert.ToInt32(textBox31.Text);
                cost = qty * 360;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox37.Checked == true)
            {
                ListViewItem item = new ListViewItem(" Chicken Chilli Prawn");
                item.SubItems.Add(textBox30.Text);
                qty = Convert.ToInt32(textBox30.Text);
                cost = qty * 325;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox36.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Cheese Prawn");
                item.SubItems.Add(textBox29.Text);
                qty = Convert.ToInt32(textBox29.Text);
                cost = qty * 325;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox35.Checked == true)
            {
                ListViewItem item = new ListViewItem("Fried Rice Chicken");
                item.SubItems.Add(textBox28.Text);
                qty = Convert.ToInt32(textBox28.Text);
                cost = qty * 600;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox34.Checked == true)
            {
                ListViewItem item = new ListViewItem("Prawn Tempura");
                item.SubItems.Add(textBox27.Text);
                qty = Convert.ToInt32(textBox27.Text);
                cost = qty * 400;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            //side Orders
            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Wontons");
                item.SubItems.Add("");
                item.SubItems.Add("165");
                listView2.Items.Add(item);
            }
            else if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Tornado beef sticks");
                item.SubItems.Add("");
                item.SubItems.Add("195");
                listView2.Items.Add(item);
            }
            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Rings");
                item.SubItems.Add("");
                item.SubItems.Add("100");
                listView2.Items.Add(item);
            }
            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheesy Garlic Bread");
                item.SubItems.Add("");
                item.SubItems.Add("75");
                listView2.Items.Add(item);
            }
            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("Soya Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView2.Items.Add(item);
            }
            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("Olive Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView2.Items.Add(item);
            }
            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sour Cream Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView2.Items.Add(item);
            }
            //drinks
            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke");
                item.SubItems.Add(textBox1.Text);
                qty = Convert.ToInt32(textBox1.Text);
                cost = qty * 100;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coke");
                item.SubItems.Add(textBox2.Text);
                qty = Convert.ToInt32(textBox2.Text);
                cost = qty * 100;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("7up");
                item.SubItems.Add(textBox3.Text);
                qty = Convert.ToInt32(textBox3.Text);
                cost = qty * 100;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite");
                item.SubItems.Add(textBox4.Text);
                qty = Convert.ToInt32(textBox4.Text);
                cost = qty * 100;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("Mountain Dew");
                item.SubItems.Add(textBox5.Text);
                qty = Convert.ToInt32(textBox5.Text);
                cost = qty * 100;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea");
                item.SubItems.Add(textBox6.Text);
                qty = Convert.ToInt32(textBox6.Text);
                cost = qty * 125;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Water");
                item.SubItems.Add(textBox7.Text);
                qty = Convert.ToInt32(textBox7.Text);
                cost = qty * 75;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }

         //   showamount();
        }
    }
}
   

