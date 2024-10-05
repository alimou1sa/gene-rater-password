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
//using static System.Net.WebRequestMethods;

namespace Project_1_reandom_Characters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random number = new Random();
        char GeneratRandomcharacter()
        {
            byte Character= (byte)number.Next(48,100);

            char a = (Char)Character;

            return a;
        }

        string GeneratPassword(short lengthpassword = 7)
        {
            string password = "";
            for (short i = 0; i < lengthpassword; i++)
            { 

            password += GeneratRandomcharacter();

            }
            return password;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password= GeneratPassword((short)trackBar1.Value);

            comboBox1.Items.Add(password);
            comboBox1.Text = comboBox1.Items[0].ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text= trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save a Text File",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = "default.txt"

            };

            if (save.ShowDialog() == DialogResult.OK)
            {

                string filebath = save.FileName;
                string na = Path.Combine(filebath, "Password.txt");
                File.WriteAllText(filebath,comboBox1.SelectedItem.ToString());

                MessageBox.Show("OK","SAVE SUCCESFULY");
            }


        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
