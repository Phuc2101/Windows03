using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(hs1.Text);
            int B = Convert.ToInt32(hs2.Text);
            int C = Convert.ToInt32(hs3.Text);
            double delta = (B*B)-(4*A*C);
            if (delta > 0)
            {
                // Phương trình có hai nghiệm thực phân biệt
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-A - Math.Sqrt(delta)) / (2 * A);
                hs4.Text = Convert.ToString(x1) + (" and ") + (Convert.ToString(x2));
            }
            else if (delta == 0)
            {
                // Phương trình có nghiệm kép
                double x = -B / (2 * A);
               hs4.Text = ("Nghiem Kep : ") + Convert.ToString(x);
            }
            else if (delta < 0)
            {
               // Tính phần thực và phần ảo
                double realPart = -B / (2 * A);
                double imaginaryPart = Math.Sqrt(-delta) / (2 * A);

                // Hiển thị kết quả
                hs4.Text = string.Format("Nghiệm 1: {0} + {1}i \nNghiệm 2: {0} - {1}i", realPart, imaginaryPart);
            }
        }
    }
}
