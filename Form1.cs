using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        List<string> months = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = months;
            listBox1.SelectionMode = SelectionMode.One ;
            textBox3.Multiline = false;
            textBox2.Multiline = false;
            listBox1.ClearSelected();
            // listBox1.Sorted=true;  // cannot work when we are using dataSource
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // listBox1.SelectionMode = SelectionMode.MultiSimple;
           // textBox3.Text = String.Empty;  MULTISELECTED
           // textBox2.Text = String.Empty; MULISELECTED


            textBox1.Text = Convert.ToString(listBox1.Items.Count);
            textBox2.Text = Convert.ToString(listBox1.SelectedIndex);
            textBox3.Text = Convert.ToString(listBox1.SelectedItem);


            // foreach (int i in listBox1.SelectedIndices) 
            // textBox2.Text += Convert.ToString(i)+ Environment.NewLine;
            //foreach (var item in listBox1.SelectedItems)
            //   textBox3.Text += Convert.ToString(item) + Environment.NewLine;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();

            

            int index = listBox1.FindString("j"); // it will be showing jeudi

            if (index < 0)
            {
                MessageBox.Show("Item not found.");
                textBox1.Text = String.Empty;
            }
            else
            {
                listBox1.SelectedIndex = index;
               // listBox1.Items.RemoveAt(index);// 'Items collection cannot be modified when the DataSource property is set.'

            }
        }
    }
}
