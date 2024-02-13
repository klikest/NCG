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
    public partial class Main_Aprox : Form
    {

        List<Double> X_Points_Data = new List<Double>();
        List<Double> Y_Points_Data = new List<Double>();


        public Main_Aprox()
        {
            InitializeComponent();

            Plot_Data_Input.Plot.Clear();
            Plot_Data_Input.Plot.Grid(Enabled);
            Plot_Data_Input.Plot.Title("Передаточная функция");
            Plot_Data_Input.Plot.SetAxisLimitsX(0, Math.PI * 2);
            Plot_Data_Input.Plot.SetAxisLimitsY(0, 2);
            Plot_Data_Input.Render();

        }


        public void Draw()
        {
            Plot_Data_Input.Plot.Clear();
            Plot_Data_Input.Plot.Grid(Enabled);
            Plot_Data_Input.Plot.Title("Передаточная функция");
            //Plot_Data_Input.Plot.AxisAuto();
            if (X_Points_Data.Count > 0)
            {
                Plot_Data_Input.Plot.AddScatterPoints(X_Points_Data.ToArray(), Y_Points_Data.ToArray());
            }

            Plot_Data_Input.Plot.SetAxisLimitsX(0, Math.PI * 2);
            Plot_Data_Input.Plot.SetAxisLimitsY(0, 2);

            Plot_Data_Input.Configuration.LeftClickDragPan = false;
            Plot_Data_Input.Configuration.Zoom = false;
            Plot_Data_Input.Configuration.Pan = false;
            Plot_Data_Input.Configuration.DoubleClickBenchmark = false;

            Plot_Data_Input.Render();
        }


        private void Main_Aprox_Load(object sender, EventArgs e)
        {

        }

        private void start_fourie_approx_Click(object sender, EventArgs e)
        {
            Fourie_approx fourie_aprox_form = new Fourie_approx();
            fourie_aprox_form.Show();
        }

        private void button_input_std_data_Click(object sender, EventArgs e)
        {
            double acc = 0.2;
            int num_points = Convert.ToInt16(Math.PI * 2 / acc);

            for (int i = 0; i <= num_points; i++)
            {
                double x = i * acc;
                X_Points_Data.Add(x);
                Y_Points_Data.Add(1 + Math.Sin(2 * x)/2);
            }

            Draw();
        }

        private void button_delete_last_point_Click(object sender, EventArgs e)
        {
            X_Points_Data.RemoveAt(X_Points_Data.Count - 1);
            Y_Points_Data.RemoveAt(Y_Points_Data.Count - 1);
            Draw();
        }

        private void button_delete_all_points_Click(object sender, EventArgs e)
        {
            X_Points_Data.Clear();
            Y_Points_Data.Clear();
            Draw();
        }

        private void Plot_Data_Input_Load(object sender, EventArgs e)
        {

        }

        private void Plot_Data_Input_MouseDown(object sender, MouseEventArgs e)
        {
            X_Points_Data.Add(Plot_Data_Input.Plot.GetCoordinateX(e.X));
            Y_Points_Data.Add(Plot_Data_Input.Plot.GetCoordinateY(e.Y));

            Draw();
        }

        private void Plot_Data_Input_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Plot_Data_Input_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
