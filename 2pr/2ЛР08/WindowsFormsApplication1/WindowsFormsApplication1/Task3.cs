using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void res_Click(object sender, EventArgs e)
        {
            string len = "Длина вектора: ";
            string sum = "Сумма векторов: ";
            string scal = "Скалярное произведение векторов: ";
            string[] vect1 = vec1.Text.Trim().Split(' ');
            string[] vect2 = vec2.Text.Trim().Split(' ');
            IVectorable avec = new ArrayVector(Int32.Parse(vect1[0]));
            IVectorable lvec = new LinkedListVector(Int32.Parse(vect2[0]));
            for (int i = 0; i < avec.Length; i++)
            {
                avec[i] = Double.Parse(vect1[i + 1]);
            }
            for (int i = 0; i < lvec.Length; i++)
            {
                lvec[i] = Double.Parse(vect2[i + 1]);
            }
            len += avec.GetNorm();
            len1.Text = len;
            len2.Text = "Длина вектора: " + lvec.GetNorm();
            if (avec.Length == lvec.Length)
            {
                sum += Vectors.Sum(avec, lvec).ToString();
                Summa.Text = sum;
                scal += Vectors.Scalar(avec, lvec);
                Scal.Text = scal;
            }
            else
            {
                MessageBox.Show("Количество координат векторов не совпадает.");
            }
        }

        private void Task3_Load(object sender, EventArgs e)
        {

        }
    }
}
