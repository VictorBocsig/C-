using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTP4_1_REC
{
    public partial class Form2 : Form
    {
      
        public DateTime Data_p
        {get;set;}
        public string Diagnostic_p 
        {get;set;}
        public string Comentarii_p
        {get;set;}
        public Form2(string path,string x,string y)
        {
            InitializeComponent();
            pictureBox1.Image = Bitmap.FromFile(path);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = x +"\n";
            label2.Text = y;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
