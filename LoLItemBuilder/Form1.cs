using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLItemBuilder
{
    public partial class Form1 : Form
    {
        private ItemRepo repo;

        public Form1()
        {
            InitializeComponent();
            repo = new ItemRepo();

            foreach (var item in repo.GetList())
            {
                comboBox1.Items.Add(item.ItemName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicItemsBox1.Clear();
            SubItemsBox1.Clear();
            BasicItemsBox2.Clear();
            SubItemsBox2.Clear();
            BasicItemsBox3.Clear();
            SubItemsBox3.Clear();
            BoxFinishedItem.Clear();


            string selected = comboBox1.SelectedItem.ToString();
            FinishedItem selectedItem = repo.FindItem(selected);
            string finishedItem = @"{""Name"":" + @"""" + selectedItem.ItemName + @""",""id"":" + selectedItem.ItemId + "}";

            //subitems
            for (int i = 0; i < selectedItem.SubItems.Count(); i++)
            {
                if(i == 0)
                {
                    if (selectedItem.SubItems.ElementAt(i).ItemId == 0)
                    {
                        SubItemsBox1.Text = "None";
                        foreach (var basicItem in selectedItem.SubItems.ElementAt(i).BasicItems)
                        {
                            BasicItemsBox1.Text += @"{""Name"":" + @"""" + basicItem.ItemName + @""",""id"":" + basicItem.ItemId + "},";
                        }
                    }
                    else
                    {
                        SubItemsBox1.Text += @"{""Name"":" + @"""" + selectedItem.SubItems.ElementAt(i).ItemName + @""",""id"":" + selectedItem.SubItems.ElementAt(i).ItemId + "},";
                        foreach (var basicItem in selectedItem.SubItems.ElementAt(i).BasicItems)
                        {
                            BasicItemsBox1.Text += @"{""Name"":" + @"""" + basicItem.ItemName + @""",""id"":" + basicItem.ItemId + "},";
                        }
                    }
                }

                if (i == 1)
                {
                    if (selectedItem.SubItems.ElementAt(i).ItemId == 0)
                    {
                        SubItemsBox2.Text = "None";
                        foreach (var basicItem in selectedItem.SubItems.ElementAt(i).BasicItems)
                        {
                            BasicItemsBox2.Text += @"{""Name"":" + @"""" + basicItem.ItemName + @""",""id"":" + basicItem.ItemId + "},";
                        }
                    }
                    else
                    {
                        SubItemsBox2.Text += @"{""Name"":" + @"""" + selectedItem.SubItems.ElementAt(i).ItemName + @""",""id"":" + selectedItem.SubItems.ElementAt(i).ItemId + "},";
                        foreach (var basicItem in selectedItem.SubItems.ElementAt(i).BasicItems)
                        {
                            BasicItemsBox2.Text += @"{""Name"":" + @"""" + basicItem.ItemName + @""",""id"":" + basicItem.ItemId + "},";
                        }
                    }
                }

                if (i == 2)
                {
                    if (selectedItem.SubItems.ElementAt(i).ItemId == 0)
                    {
                        SubItemsBox3.Text = "None";
                        foreach (var basicItem in selectedItem.SubItems.ElementAt(i).BasicItems)
                        {
                            BasicItemsBox3.Text += @"{""Name"":" + @"""" + basicItem.ItemName + @""",""id"":" + basicItem.ItemId + "},";
                        }
                    }
                    else
                    {
                        SubItemsBox3.Text += @"{""Name"":" + @"""" + selectedItem.SubItems.ElementAt(i).ItemName + @""",""id"":" + selectedItem.SubItems.ElementAt(i).ItemId + "},";
                        foreach (var basicItem in selectedItem.SubItems.ElementAt(i).BasicItems)
                        {
                            BasicItemsBox3.Text += @"{""Name"":" + @"""" + basicItem.ItemName + @""",""id"":" + basicItem.ItemId + "},";
                        }
                    }
                }
            }

            BoxFinishedItem.Text = finishedItem;
        }
    }
}
