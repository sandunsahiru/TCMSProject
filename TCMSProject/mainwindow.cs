using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCMSProject
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
            sidepanel.BackColor = ColorTranslator.FromHtml("#0E1420");
            mainpanel.BackColor = ColorTranslator.FromHtml("#111926");
            label1.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            label2.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            label3.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            label4.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            label5.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#7E5DC9");
            panel1.BackColor = ColorTranslator.FromHtml("#7E5DC9");
            
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            panel1.BackColor = Color.Transparent;
            
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = ColorTranslator.FromHtml("#7E5DC9");
            panel2.BackColor = ColorTranslator.FromHtml("#7E5DC9");
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            panel2.BackColor = Color.Transparent;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = ColorTranslator.FromHtml("#7E5DC9");
            panel3.BackColor = ColorTranslator.FromHtml("#7E5DC9");
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            panel3.BackColor = Color.Transparent;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = ColorTranslator.FromHtml("#7E5DC9");
            panel4.BackColor = ColorTranslator.FromHtml("#7E5DC9");
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            panel4.BackColor = Color.Transparent;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = ColorTranslator.FromHtml("#7E5DC9");
            panel5.BackColor = ColorTranslator.FromHtml("#7E5DC9");
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = ColorTranslator.FromHtml("#AEB1B6");
            panel5.BackColor = Color.Transparent;
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadform(new home());
        }
    }
}
