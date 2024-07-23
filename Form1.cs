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
using System.Xml;

namespace WindowsFormsApp1
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
                label1.Text = "...";

                string tfile = @"X:\AOI_CCN\" + "BS_SAKI_AOI_18" + @"\" + textBox1.Text;

                if (File.Exists(tfile))
                {
                    label1.Text = "1";
                }
                else
                {
                    label1.Text = "0";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //

            try
            {
                ;

                label1.Text = "...";

                string tfile = @"X:\AOI_CCN\" + "BS_SAKI_AOI_18" + @"\" + textBox1.Text;

                FileInfo fi = new FileInfo(tfile);

                fi.Refresh();

                if (fi.Exists)
                {
                    label1.Text = "1";
                }
                else
                {
                    label1.Text = "0";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
