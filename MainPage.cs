using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Generator
{
    public partial class MainPage : Form
    {
        internal Outfit OF { get; set; } = new Outfit(null, null, null, null);

        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BasketballToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SweatshirtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            string occasion = comboBox1.Text;
            
            OF.Randomize(temp, occasion);
            Console.WriteLine(OF.Jacket.Name);
            ClothingDisplayPage frm = new ClothingDisplayPage(OF);
            frm.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LongSleeveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
