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
    public partial class Form1 : Form
    {
        public static Form1 instance;
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
            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                if (pic.Tag.ToString() == (string)drv["Imagine"])
                {
                    string x = (string)drv["Diagnostic"];
                    string y = (string)drv["Comentarii"];
             
                    Form2 f = new Form2(pic.Tag.ToString(), x, y);
                    f.ShowDialog();

                }
             
            }


        }

        private void pacientiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pacientiBindingSource_PositionChanged_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3((string)((DataRowView)pacientiBindingSource.Current)["CNP"]);
            if (f.ShowDialog() == DialogResult.OK)
            {
                radiografiiTableAdapter.Insert((string)((DataRowView)pacientiBindingSource.Current)["CNP"], f.Imagine_p, f.Data_p, f.Diagnostic_p, f.Comentarii_p);
               
     

            }
        }
      /*  private void search()
        {
            string searchTerm = textBox1.Text;
            foreach (DataGridViewRow row in pacientiDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchTerm))
                    {
                        cell.Selected = true;
                        pacientiDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }
            MessageBox.Show("No results found.");
        }
      */
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            tableAdapterManager.UpdateAll(pacientiDataSet);
            radiografiiTableAdapter.Fill(pacientiDataSet.Radiografii);
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

     
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in pacientiDataGridView.Rows)
            {
                row.Selected = false;
            }
                string searchValue = textBox1.Text;

                pacientiDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in pacientiDataGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                   
                }
            }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

     
    }


