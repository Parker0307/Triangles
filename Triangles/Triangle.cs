using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles {
    class Triangle {
        const int NUM_SIDES = 3;
        const double RIGHT_ANG = 90;
        const string EQU = "equilateral", ISO = "isosceles", SCA = "scalene",
            ACU = "acute", RIG = "right", OBT = "obtuse";

        private double[] side_Lengths = new double[NUM_SIDES];
        private double[] _angles = new double[NUM_SIDES];
        public string side_Type { get; private set; }
        public string angle_Type { get; private set; }

        public double[] angles {
            get { return _angles; }
            private set { _angles = value; }
        }

        public Triangle() { }

        public void update_Triangle(double a_Length, double b_Length, double c_Length) {
            side_Lengths[0] = a_Length;
            side_Lengths[1] = b_Length;
            side_Lengths[2] = c_Length;

            update_Types();
            update_Angles();
        }

        private void update_Types() {
            if ((side_Lengths[0] == side_Lengths[1]) && (side_Lengths[0] == side_Lengths[2])) {
                side_Type = EQU;
            }

            else if ((side_Lengths[0] == side_Lengths[1]) || (side_Lengths[0] == side_Lengths[2]) ||
                side_Lengths[1] == side_Lengths[2]) {

                side_Type = ISO;
            }

            else {
                side_Type = SCA;
            }
        }

        private void update_Angles() {
            angles[0] = Math.Acos((Math.Pow(side_Lengths[1], 2) + Math.Pow(side_Lengths[2], 2) -
                Math.Pow(side_Lengths[0], 2)) / (2 * side_Lengths[1] * side_Lengths[2])) * (180/Math.PI);

            angles[1] = Math.Acos((Math.Pow(side_Lengths[0], 2) + Math.Pow(side_Lengths[2], 2) -
                Math.Pow(side_Lengths[1], 2)) / (2 * side_Lengths[0] * side_Lengths[2])) * (180/Math.PI);

            angles[2] = Math.Acos((Math.Pow(side_Lengths[0], 2) + Math.Pow(side_Lengths[1], 2) -
                Math.Pow(side_Lengths[2], 2)) / (2 * side_Lengths[0] * side_Lengths[1])) * (180/Math.PI);

            angles[0] = Math.Round(angles[0], 4);
            angles[1] = Math.Round(angles[1], 4);
            angles[2] = Math.Round(angles[2], 4);

            if (angles[0] > RIGHT_ANG || angles[1] > RIGHT_ANG || angles[2] > RIGHT_ANG) {
                angle_Type = OBT;
            }

            else if (angles[0] == RIGHT_ANG || angles[1] == RIGHT_ANG || angles[2] == RIGHT_ANG) {
                angle_Type = RIG;
            }

            else {
                angle_Type = ACU;
            }
        }
    }
}