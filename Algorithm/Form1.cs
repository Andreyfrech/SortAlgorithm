using AlgorithmBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BubbleSort<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxResult.Text, out int value))
            {
                algorithm.Items.Add(value);
                label_Out.Text += " " + value;
            }
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            algorithm.Sort();

            foreach(var item in algorithm.Items)
            {
                label_Sort.Text += " " + item; 
            }
        }
    }
}
