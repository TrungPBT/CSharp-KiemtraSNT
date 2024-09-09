using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_KiemtraSNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool ktraSNT(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return true;
            }
            return false;
        }

        private void txt_kq_TextChanged(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txt_n.Text != string.Empty)
            {
                if (ktraSNT(int.Parse(txt_n.Text)))
                {
                    txt_kq.Text = "Là SNT";
                }
                else
                {
                    txt_kq.Text = "Không Là SNT";
                }
                for (int i = 2; i < int.Parse(txt_n.Text); i++)
                {
                    if (ktraSNT(i))
                    {
                        kq += " " + i;
                    }
                }
                txt_sn.Text = kq;
            }
        }
    }
}
