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
    public partial class burgerking : sample
    {
        public burgerking()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            // burgers
            tabControl2.SelectTab("tabPage2");
            int qty;
            double cost;
            string dcost;

            if(checkBox35.Checked==true)
            {
                ListViewItem item = new ListViewItem("Chicken Whopper");
                item.SubItems.Add(textBox28.Text);
                qty = Convert.ToInt32(textBox28.Text);
                cost = qty * 499;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
                if(textBox28.Text=="")
                {
                    DialogResult dialog = MessageBox.Show("Quantity is required!");
                }
            }
            else if (checkBox34.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Big King");
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
                ListViewItem item = new ListViewItem("Long Chicken");
                item.SubItems.Add(textBox25.Text);
                qty = Convert.ToInt32(textBox25.Text);
                cost = qty * 510;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
            else if (checkBox31.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Steak Burger");
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
                ListViewItem item = new ListViewItem("Chicken Tikka Meal");
                item.SubItems.Add(textBox31.Text);
                qty = Convert.ToInt32(textBox31.Text);
                cost = qty * 360;
                dcost = cost.ToString();
                item.SubItems.Add(dcost);
                listView2.Items.Add(item);
            }
             else if (checkBox37.Checked == true)
             {
                 ListViewItem item = new ListViewItem("Crispy Chicken Meal");
                 item.SubItems.Add(textBox30.Text);
                 qty = Convert.ToInt32(textBox30.Text);
                 cost = qty * 325;
                 dcost = cost.ToString();
                 item.SubItems.Add(dcost);
                 listView2.Items.Add(item);
             }
             else if (checkBox36.Checked == true)
             {
                 ListViewItem item = new ListViewItem("Chicken Cheese Meal");
                 item.SubItems.Add(textBox29.Text);
                 qty = Convert.ToInt32(textBox29.Text);
                 cost = qty * 325;
                 dcost = cost.ToString();
                 item.SubItems.Add(dcost);
                 listView2.Items.Add(item);
             }
             else if (checkBox35.Checked == true)
             {
                 ListViewItem item = new ListViewItem("King Meal");
                 item.SubItems.Add(textBox28.Text);
                 qty = Convert.ToInt32(textBox28.Text);
                 cost = qty * 600;
                 dcost = cost.ToString();
                 item.SubItems.Add(dcost);
                 listView2.Items.Add(item);
             }
             else if (checkBox34.Checked == true)
             {
                 ListViewItem item = new ListViewItem("Fish Meal ");
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
                 ListViewItem item = new ListViewItem("Nuggets");
                 item.SubItems.Add("");
                 item.SubItems.Add("165");
                 listView2.Items.Add(item);
             }
             else if (checkBox23.Checked == true)
              {
                  ListViewItem item = new ListViewItem("Fries Large");
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
                  ListViewItem item = new ListViewItem("Garlic Dip");
                  item.SubItems.Add("");
                  item.SubItems.Add("0.00");
                  listView2.Items.Add(item);
              }
              if (checkBox27.Checked == true)
              {
                  ListViewItem item = new ListViewItem("BBQ Dip");
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

              showamount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab("tabPage1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            total = 0;
            gst=0;
            totaldue = 0;
            listView2.SelectedItems.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        double total = 0;
        double gst = 0;
        double totaldue = 0;

        private void showamount()
        {
            foreach(ListViewItem item in listView2.Items)
            {
                total = total + Convert.ToDouble(item.SubItems[2].Text);
            }
            gst = total * 0.05;   //GST=5%
            totaldue = gst + total;

            string gstdisplay = gst.ToString("c2");
            string totaldisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");

            textBox8.Text = amount;
            textBox9.Text = gstdisplay;
            textBox10.Text = totaldisplay;
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void burgerking_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sindh");
            comboBox1.Items.Add("Punjab");
            comboBox1.Items.Add("Balochistan");
            comboBox1.Items.Add("KPK");
            comboBox1.Items.Add("Gilgit Baltistan");

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
            comboBox2.Items.Add("Promo Card");
            
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }
            else
            {
                string money = textBox19.Text;
                //char[] rupee={'$'};
                //string paymoney = money.TrimStart(rupee);
                double paymentDue = totaldue;
                double amountPaid = Convert.ToDouble(textBox20.Text);
                double change = 0;
                change = amountPaid - paymentDue;
                textBox21.Text = change.ToString("c2");
                if (change < 0)
                {
                    MessageBox.Show("Please pay your balance");

                }
                else
                {
                    button8.Enabled = true;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
                textBox18.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab("tabPage2");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Thanks for ordering at Pizza Express. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                checkBox1.Checked = false;
               checkBox35.Checked = false;
               checkBox34.Checked = false;
               checkBox33.Checked = false;
               checkBox32.Checked = false;
               checkBox31.Checked = false;
               checkBox22.Checked = false;
               checkBox23.Checked = false;
               checkBox24.Checked = false;
               checkBox25.Checked = false;
               checkBox26.Checked = false;
               checkBox27.Checked = false;
               checkBox28.Checked = false;
               checkBox38.Checked = false;
               checkBox37.Checked = false;
               checkBox29.Checked = false;
               checkBox17.Checked = false;
               checkBox18.Checked = false;
               checkBox19.Checked = false;
               checkBox15.Checked = false;
               checkBox21.Checked = false;
               checkBox16.Checked = false;
               checkBox17.Checked = false;
               checkBox21.Checked = false;
               
               textBox28.Text = "";
               textBox27.Text = "";
               textBox26.Text = "";
               textBox25.Text = "";
               textBox31.Text = "";
               textBox29.Text = "";
               textBox23.Text = "";

               listView2.Items.Clear();
               textBox22.Text = "";
               textBox1.Text = "";
               textBox2.Text = "";

               textBox3.Text = "";
               textBox4.Text = "";
               textBox5.Text = "";
               textBox6.Text = "";
               textBox7.Text = "";
               textBox8.Text = "";
               textBox9.Text = "";
               textBox11.Text = "";
               textBox12.Text = "";
               textBox13.Text = "";
               textBox14.Text = "";
               textBox15.Text = "";
               textBox16.Text = "";
               textBox17.Text = "";
               textBox18.Text = "";
               textBox19.Text = "";
               textBox20.Text = "";
               textBox21.Text = "";
               comboBox1.Text = "";
               comboBox2.Text = "";

               tabControl2.SelectTab("tabPage1");
           }
            else if (dialog == DialogResult.No)
            {
                this.Close();
            }
        }
       
    }
}
