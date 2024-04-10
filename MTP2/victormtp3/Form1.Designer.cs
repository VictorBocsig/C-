
namespace victormtp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.echipaNouaButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CNPBox = new System.Windows.Forms.TextBox();
            this.postBox = new System.Windows.Forms.TextBox();
            this.numeBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // echipaNouaButton
            // 
            this.echipaNouaButton.Location = new System.Drawing.Point(288, 38);
            this.echipaNouaButton.Name = "echipaNouaButton";
            this.echipaNouaButton.Size = new System.Drawing.Size(113, 23);
            this.echipaNouaButton.TabIndex = 1;
            this.echipaNouaButton.Text = "Echipa noua";
            this.echipaNouaButton.UseVisualStyleBackColor = true;
            this.echipaNouaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Jucator nou";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nume);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CNPBox);
            this.groupBox1.Controls.Add(this.postBox);
            this.groupBox1.Controls.Add(this.numeBox);
            this.groupBox1.Location = new System.Drawing.Point(403, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 300);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Jucator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "VARSTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA NASTERII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CNP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "POST";
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(43, 64);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(39, 13);
            this.Nume.TabIndex = 5;
            this.Nume.Text = "NUME";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(88, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // CNPBox
            // 
            this.CNPBox.Enabled = false;
            this.CNPBox.Location = new System.Drawing.Point(84, 135);
            this.CNPBox.Name = "CNPBox";
            this.CNPBox.Size = new System.Drawing.Size(182, 20);
            this.CNPBox.TabIndex = 2;
            // 
            // postBox
            // 
            this.postBox.Enabled = false;
            this.postBox.Location = new System.Drawing.Point(84, 100);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(182, 20);
            this.postBox.TabIndex = 1;
            // 
            // numeBox
            // 
            this.numeBox.Enabled = false;
            this.numeBox.Location = new System.Drawing.Point(84, 61);
            this.numeBox.Name = "numeBox";
            this.numeBox.Size = new System.Drawing.Size(182, 20);
            this.numeBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 236);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.echipaNouaButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button echipaNouaButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CNPBox;
        private System.Windows.Forms.TextBox postBox;
        private System.Windows.Forms.TextBox numeBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

