using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCG
{
    public class Gears
    {
        public double A = 100;

        static int acc = 100;
        static double len = Math.PI * 2;

        static int num_points = Convert.ToInt32(acc * len) + 1;

        public double[] i_x = new double[num_points];
        public double[] i_y = new double[num_points];

        public double[] first_gear_R_Data = new double[num_points];
        public double[] first_gear_X_Data = new double[num_points];
        public double[] first_gear_Y_Data = new double[num_points];

        public double[] second_gear_R_Data = new double[num_points];
        public double[] second_gear_Angle_Data = new double[num_points];
        public double[] second_gear_X_Data = new double[num_points];
        public double[] second_gear_Y_Data = new double[num_points];




        public void integrate_i(double[] i_x_, double[] i_y_)
        {
            i_x = i_x_;
            i_y = i_y_;

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


            for (int i = 0; i < num_points; i++)
            {
                second_gear_Angle_Data[i] *= 2 * Math.PI;
            }

        }



        public void calc_gears(double[] i_x_, double[] i_y_, double angle)
        {
            integrate_i(i_x_, i_y_);

            for (int i = 0; i < num_points; i++)
            {
                first_gear_R_Data[i] = A * ((i_y[i]) / (i_y[i] + 1));
                first_gear_X_Data[i] = first_gear_R_Data[i] * Math.Cos(i_x[i] - angle);
                first_gear_Y_Data[i] = first_gear_R_Data[i] * Math.Sin(i_x[i] - angle);

                second_gear_R_Data[i] = A * (1 / (i_y[i] + 1));
                second_gear_X_Data[i] = (A - second_gear_R_Data[i] * Math.Cos(-second_gear_Angle_Data[i]));
                second_gear_Y_Data[i] = -(second_gear_R_Data[i] * Math.Sin(-second_gear_Angle_Data[i]));
            }

        }

    }
}
