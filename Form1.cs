using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Domaci1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Text Files|*.txt;*.rtf;";
                openFileDialog1.ShowDialog();
                string filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(filename);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "GRESKA");
            }

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //FIND
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // REPLACE
        {

        }

        private void button2_Click(object sender, EventArgs e) // PRONADJI I ZAMENI
        {
            string pronadji = textBox1.Text;
            string zameni = textBox2.Text;
            if (richTextBox1.Text.Length == 0)
            {


                System.Windows.Forms.MessageBox.Show("GRESKA: Nema ucitanog texta");
            } else if (pronadji.Length == 0)
            {
              


                System.Windows.Forms.MessageBox.Show("GRESKA: Niste uneli text za pretragu");
            } else if(zameni.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("GRESKA: Niste uneli text za zamenu");
            } else
            {
                richTextBox1.Text = richTextBox1.Text.Replace(pronadji, zameni);
            }
            

            

        }

        private void button3_Click(object sender, EventArgs e) // Snimi
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "RTF|*.rtf;";
            saveFileDialog1.Title = "Sacuvaj text fajl";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e) // END
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) // font Bold
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) //font Italic
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e) // boja fonta
        {
            ColorDialog bojaDialog = new ColorDialog();
            bojaDialog.ShowHelp = true;
            bojaDialog.ShowDialog();
            richTextBox1.SelectionColor = bojaDialog.Color;
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowHelp = true;
            fontDialog.ShowDialog();
            richTextBox1.SelectionFont = fontDialog.Font;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
