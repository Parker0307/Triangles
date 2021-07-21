using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triangles {
    class Validate_Input {
        const int NUM_SIDES = 3;

        private static Validate_Input unique_Instance;
        private double[] lengths = new double[NUM_SIDES];

        private Validate_Input() {}

        public static Validate_Input get_Instance() {
            if (unique_Instance == null) {
                unique_Instance = new Validate_Input();
            }

            return unique_Instance;
        }

        public bool validate_Nums(string a_Txt, string b_Txt, string c_Txt) {
            bool are_Valid = true;

            //Check if the user input can be converted to a number.
            if (!double.TryParse(a_Txt, out lengths[0]) || !double.TryParse(b_Txt, out lengths[1]) ||
                !double.TryParse(c_Txt, out lengths[2])) {

                are_Valid = false;
            }

            return are_Valid;
        }

        public bool validate_Triangle() {
            bool is_Valid = true;
            Array.Sort(lengths);

            /* Triangle Inequality Theorem.
               In order for 3 lengths to be able to form a triangle, any 2 side lengths
               added together need to be greater than the other side length. A shortcut
               is to just add the smallest two side lengths and compare the sum to the
               third. */
            if (lengths[0] + lengths[1] <= lengths[2]) {
                is_Valid = false;
            }

            return is_Valid;
        }
    }
}