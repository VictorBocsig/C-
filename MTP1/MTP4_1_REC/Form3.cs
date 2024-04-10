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

namespace MTP4_1_REC
{   
    public partial class Form3 : Form
    {
        string imagine, diagnostic, comentarii;
        DateTime data;
        public Form3(string CNP)
        {
            InitializeComponent();
            textBoxCNP.Text = CNP;
        }
        public DateTime Data_p
        {
            get { return data; }
            set { data = value; }
        }
        public string Imagine_p
        {
            get { return imagine; }
            set { imagine = value; }
        }
        public string Diagnostic_p
        {
            get { return diagnostic; }
            set { diagnostic = value; }
        }
        public string Comentarii_p
        {
            get { return comentarii; }
            set { comentarii= value; }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
             
                string[] filex = Directory.GetFiles(FBD.SelectedPath);

                foreach (string file in filex)

                {
                    textBoxImagine.Text = file;
                    break;
                }


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diagnostic_p = textBoxDiag.Text;
            Comentarii_p = richTextBox1.Text;
            Data_p = dateTimePicker1.Value;
            Imagine_p = textBoxImagine.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            DialogResult = DialogResult.Cancel;
        }
    }
}
