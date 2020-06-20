using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._2
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnPoschitat_Click(object sender, EventArgs e)
        {
            double storona1_1 = Convert.ToDouble(tbStorona1_1.Text);
            double storona2_1 = Convert.ToDouble(tbStorona2_1.Text);
            double storona3_1 = Convert.ToDouble(tbStorona3_1.Text);
            double storona1_2 = Convert.ToDouble(tbStorona1_2.Text);
            double storona2_2 = Convert.ToDouble(tbStorona2_2.Text);
            double storona3_2 = Convert.ToDouble(tbStorona3_2.Text);
            if (storona1_1+storona2_1 >= storona3_1 && storona2_1 + storona3_1 >= storona1_1 && storona1_1 + storona3_1 >= storona2_1)
            {
                if (storona1_2 + storona2_2 >= storona3_2 && storona2_2 + storona3_2 >= storona1_2 && storona1_2 + storona3_2 >= storona2_2)
                {
                    double perimetr1 = (storona1_1 + storona2_1 + storona3_1) / 2;
                    double perimetr2 = (storona1_2 + storona2_2 + storona3_2) / 2;
                    double ploshad1 = Math.Sqrt(perimetr1 * (perimetr1 - storona1_1) * (perimetr1 - storona2_1) * (perimetr1 - storona3_1));
                    double ploshad2 = Math.Sqrt(perimetr2 * (perimetr2 - storona1_2) * (perimetr2 - storona2_2) * (perimetr2 - storona3_2));
                    if (ploshad1 > ploshad2)
                    {
                        lblOtvet.Text = "Площадь 1 треугольника больше площади 2 треугольника";
                    }
                    else
                        if (ploshad1 < ploshad2)
                    {
                        lblOtvet.Text = "Площадь 1 треугольника меньше площади 2 треугольника";
                    }
                    else
                    {
                        lblOtvet.Text = "Площади треугольников равны";
                    }
                }
                else
                {
                    lblOtvet.Text = "2 треугольник не существует";
                }
            } else
            {
                lblOtvet.Text = "1 треугольник не существует";
            }
            
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            formMain Main = this;
            Main.BackColor = colorDialog.Color;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbStorona_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void tbStorona1_1_TextChanged(object sender, EventArgs e)
        {
            if (tbStorona1_1.Text != "" && tbStorona1_2.Text != "" && tbStorona2_1.Text != "" && tbStorona2_2.Text != "" && tbStorona3_1.Text != "" && tbStorona3_2.Text !="")
            {
                btnPoschitat.Enabled = true;
            }
            else
            {
                btnPoschitat.Enabled = false;
            }
        }

        private void tbStorona2_1_TextChanged(object sender, EventArgs e)
        {
            if (tbStorona1_1.Text != "" && tbStorona1_2.Text != "" && tbStorona2_1.Text != "" && tbStorona2_2.Text != "" && tbStorona3_1.Text != "" && tbStorona3_2.Text != "")
            {
                btnPoschitat.Enabled = true;
            }
            else
            {
                btnPoschitat.Enabled = false;
            }
        }

        private void tbStorona3_1_TextChanged(object sender, EventArgs e)
        {
            if (tbStorona1_1.Text != "" && tbStorona1_2.Text != "" && tbStorona2_1.Text != "" && tbStorona2_2.Text != "" && tbStorona3_1.Text != "" && tbStorona3_2.Text != "")
            {
                btnPoschitat.Enabled = true;
            }
            else
            {
                btnPoschitat.Enabled = false;
            }
        }

        private void tbStorona1_2_TextChanged(object sender, EventArgs e)
        {
            if (tbStorona1_1.Text != "" && tbStorona1_2.Text != "" && tbStorona2_1.Text != "" && tbStorona2_2.Text != "" && tbStorona3_1.Text != "" && tbStorona3_2.Text != "")
            {
                btnPoschitat.Enabled = true;
            }
            else
            {
                btnPoschitat.Enabled = false;
            }
        }

        private void tbStorona2_2_TextChanged(object sender, EventArgs e)
        {
            if (tbStorona1_1.Text != "" && tbStorona1_2.Text != "" && tbStorona2_1.Text != "" && tbStorona2_2.Text != "" && tbStorona3_1.Text != "" && tbStorona3_2.Text != "")
            {
                btnPoschitat.Enabled = true;
            }
            else
            {
                btnPoschitat.Enabled = false;
            }
        }

        private void tbStorona3_2_TextChanged(object sender, EventArgs e)
        {
            if (tbStorona1_1.Text != "" && tbStorona1_2.Text != "" && tbStorona2_1.Text != "" && tbStorona2_2.Text != "" && tbStorona3_1.Text != "" && tbStorona3_2.Text != "")
            {
                btnPoschitat.Enabled = true;
            }
            else
            {
                btnPoschitat.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStorona1_1.Text = "";
            tbStorona2_1.Text = "";
            tbStorona3_1.Text = "";
            tbStorona1_2.Text = "";
            tbStorona2_2.Text = "";
            tbStorona3_2.Text = "";
            btnPoschitat.Enabled = false;
        }
    }
}
