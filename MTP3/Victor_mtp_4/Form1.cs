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

namespace Victor_mtp_4
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public PictureBox tb1;
        public Form1()
        {
            InitializeComponent();
            instance = this;
           
        }

        private void pacientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pacientiDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pacientiDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.pacientiDataSet.Radiografii);
            // TODO: This line of code loads data into the 'pacientiDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.pacientiDataSet.Pacienti);

        }
        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Form2 f = new Form2(pic.Tag.ToString());
            f.ShowDialog();
            
        }
        private void pacientiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void pacientiBindingSource_PositionChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRowView drv in radiografiiBindingSource.List)
            {       
                string img = (string)drv["Imagine"];
                PictureBox pic = new PictureBox();
                pic.SetBounds(0, 0, 100, 100);
                pic.BackColor = Color.Black;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Bitmap.FromFile(img);
                pic.Tag = img;

                flowLayoutPanel1.Controls.Add(pic);
                pic.Click += pic_Click;
               }
            }
        }
}
