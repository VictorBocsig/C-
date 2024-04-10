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

namespace victormtp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var dir in Directory.EnumerateDirectories(@"C:\Users\Student\Desktop\LPF\"))
            {
              // MessageBox.Show(dir);
                string s = new DirectoryInfo(dir).Name;
                comboBox1.Items.Add(s);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var dir in Directory.EnumerateDirectories(@"C:\Users\Student\Desktop\LPF\"))
            {
                string s = new DirectoryInfo(dir).Name;
                if (s == comboBox1.SelectedItem.ToString())
                {
                    foreach (var dirs in Directory.EnumerateFiles(dir))
                    {
                        Button btn = new Button();
                        StreamReader sr = new StreamReader(dirs);
                        string num;
                        string post;
                        string CNP;
                        CNP = Path.GetFileNameWithoutExtension(dir);
                        num = sr.ReadLine();
                        post = sr.ReadLine();
                        btn.Text = num;
                        btn.Width = 200;
                        flowLayoutPanel1.Controls.Add(btn);
                        Jucator j;
                        j = new Jucator(num, post, CNP);
                        btn.Tag = j;
                        btn.Click += Btn_Click;
                    }
                }
            }
           
        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Jucator j = (Jucator)btn.Tag;
            numeBox.Text = j.Nume;
            CNPBox.Text = j.CNP;
            postBox.Text = j.Post;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }

    public class Jucator
    {
       public string Nume { get; private set; }
        public string CNP { get; private set; }
       public string Post { get; private set; }
       public Jucator(string n, string p, string CNP)
        {
            this.Nume = n;
            this.Post = p;
            this.CNP = CNP;
        }

    }
}
