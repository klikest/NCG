using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCG
{
    public class Curve
    {

        static int acc = 100;
        static double len = Math.PI * 2 ;

        static int num_points = Convert.ToInt32(acc * len) + 1 ;

        public double[] X_Data = new double[num_points];
        public double[] Y_Data = new double[num_points];

        public double[] second_gear_Angle_Data = new double[num_points];


        Function f;

        public void read_func(string text)
        {
            f = new Function("f", text, "x");
        }

        public void generate_i_func_by_coefs(double angle, bool normalize, double num_rotate)
        {

                for (int i = 0; i < num_points; i++)
                {
                    double x = (Convert.ToDouble(i) / acc) + angle ;

                    X_Data[i] = x;
                    Y_Data[i] = f.calculate(x);
                }

            integrate_i(X_Data, Y_Data, normalize, num_rotate);

        }



        public void integrate_i(double[] i_x, double[] i_y, bool normalize, double num_rotate)
        {

            for (int i = 0; i < num_points; i++)
            {
                if (i == 0)
                {
                    second_gear_Angle_Data[i] = 0;
                }
                else
                {
                    second_gear_Angle_Data[i] = (second_gear_Angle_Data[i - 1] + i_y[i] * (1 / Convert.ToDouble(num_points)));
                }
            }


            if (normalize == true)
            {
                double max_angle = second_gear_Angle_Data.Max();
                double razn = 1.0 - max_angle;
                

                for (int i = 0; i < num_points; i++)
                {
                    Y_Data[i] += razn;
                }

                for (int i = 0; i < num_points; i++)
                {

                    Y_Data[i] *= num_rotate;
                }
            }

            //MessageBox.Show(Convert.ToString(num_rotate));

        }


    }
}
