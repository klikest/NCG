using ScottPlot;
using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCG
{
    public partial class Form1 : Form
    {

        Curve curve = new Curve();

        Gears gears = new Gears();


        void gen_i_func()
        {
            curve.generate_i_func_by_coefs(0, checkBox_normalize.Checked, Convert.ToDouble(textBox_num_rotates.Text));
        }

        void gen_gears_func()
        {
            gears.calc_gears(curve.X_Data, curve.Y_Data, 0);
        }

        void Draw()
        {
            Plot_i.Plot.Clear();
            Plot_i.Plot.Grid(Enabled);
            Plot_i.Plot.Title("Передаточная функция");
            Plot_i.Plot.AddScatterLines(curve.X_Data, curve.Y_Data, lineWidth: 3);
            Plot_i.Plot.AxisAuto();
            Plot_i.Plot.SetAxisLimitsY(-0.1, 1.1 * curve.Y_Data.Max());
            Plot_i.Render();


            Plot_Angle.Plot.Clear();
            Plot_Angle.Plot.Grid(Enabled);
            Plot_Angle.Plot.Title("Функция зависимости угла второго колеса");
            Plot_Angle.Plot.AddScatterLines(gears.i_x, gears.second_gear_Angle_Data, lineWidth: 3);
            Plot_Angle.Plot.AxisAuto();
            Plot_Angle.Render();

            Plot_Gears.Plot.Clear();
            Plot_Gears.Plot.Grid(Enabled);
            Plot_Gears.Plot.Title("Форма колес");
            Plot_Gears.Plot.AddScatterLines(gears.first_gear_X_Data, gears.first_gear_Y_Data, lineWidth: 3);
            Plot_Gears.Plot.AddScatterLines(gears.second_gear_X_Data, gears.second_gear_Y_Data, lineWidth: 3);
            Plot_Gears.Plot.AddPoint(0, 0, Color.Blue, size: 8);
            Plot_Gears.Plot.AddPoint(gears.A, 0, Color.Orange, size: 8);
            double r1_max = gears.first_gear_R_Data.Max();
            double r2_max = gears.second_gear_R_Data.Max();
            Plot_Gears.Plot.SetAxisLimitsX(-1.1 * r1_max, gears.A + 1.1 * r2_max);
            Plot_Gears.Plot.SetAxisLimitsY(-1.1 *Math.Max(r1_max, r2_max), 1.1 * Math.Max(r1_max, r2_max));
            //Plot_Gears.Plot.AxisAuto();
            Plot_Gears.Render();
        }

        public Form1()
        {
            InitializeComponent();

            curve.read_func(textBox_function.Text);
            gen_i_func();
            gen_gears_func();
            Draw();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gen_i_func();
            gen_gears_func();
            Draw();
        }

        public void Render()
        {

        }

        private void Plot_i_Load(object sender, EventArgs e)
        {

        }

        private void trackBar_Angle_Scroll(object sender, EventArgs e)
        {
            gen_i_func();
            gen_gears_func();
            Draw();
        }

        private void button_plot_Click(object sender, EventArgs e)
        {
            curve.read_func(textBox_function.Text);
            gen_i_func();
            gen_gears_func();
            Draw();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double angle = 0;

            while (angle < 360)
            {
                angle += Convert.ToDouble(textBox_Angle_Step.Text);
                curve.generate_i_func_by_coefs(angle*Math.PI/180, checkBox_normalize.Checked, Convert.ToDouble(textBox_num_rotates.Text));
                gears.calc_gears(curve.X_Data, curve.Y_Data, angle * Math.PI / 180);
                Draw();

            }
        }

        private void button_aprox_Click(object sender, EventArgs e)
        {
            Main_Aprox main_aprox_form = new Main_Aprox();
            main_aprox_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            curve.read_func(textBox_function.Text);
            gen_i_func();
            gen_gears_func();
            Draw();
        }

        private void textBox_num_rotates_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
