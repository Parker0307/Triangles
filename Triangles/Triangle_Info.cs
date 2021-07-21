using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Triangles {

    public partial class Triangle_Info : Form {
        const char PERIOD = '.';
        const string EMPTY = "";
        const string BASE_LBL = "These side lengths ";

        public string side_a_Txt { get; private set; }
        public string side_b_Txt { get; private set; }
        public string side_c_Txt { get; private set; }

        private Validate_Input validation;
        private Triangle cur_Triangle;
        private int a_Num_Periods, b_Num_Periods, c_Num_Periods;

        public Triangle_Info() {
            InitializeComponent();

            validation = Validate_Input.get_Instance();
            cur_Triangle = new Triangle();
            a_Num_Periods = 0;
            b_Num_Periods = 0;
            c_Num_Periods = 0;
        }

        private void update_Result() {
            if ((side_a_Txt != null && side_a_Txt != EMPTY) && (side_b_Txt != null && side_b_Txt != EMPTY) &&
                (side_c_Txt != null && side_c_Txt != EMPTY)) {

                bool nums_Validated = validation.validate_Nums(side_a_Txt, side_b_Txt, side_c_Txt);
                bool triangle_Validated = validation.validate_Triangle();

                /* If the user entered an invalid number or 3 side lengths that cannot
                   form a triangle an error message is displayed in the label. */
                if (!nums_Validated || !triangle_Validated) {
                    Result_Label.Text = BASE_LBL + "do not produce a triangle.";
                    Angle_A_TxtBox.Text = EMPTY;
                    Angle_B_TxtBox.Text = EMPTY;
                    Angle_C_TxtBox.Text = EMPTY;
                }

                /* Otherwise the user has entered valid side lengths and the type of triangle
                   formed is determined, along with its angles. */
                else {
                    cur_Triangle.update_Triangle(Convert.ToDouble(side_a_Txt), Convert.ToDouble(side_b_Txt),
                        Convert.ToDouble(side_c_Txt));

                    string triangle_Type = cur_Triangle.angle_Type + "-" + cur_Triangle.side_Type;
                    Result_Label.Text = BASE_LBL + "produce a valid " + triangle_Type + " triangle.";
                    Angle_A_TxtBox.Text = String.Format("{0:0.####}", cur_Triangle.angles[0]);
                    Angle_B_TxtBox.Text = String.Format("{0:0.####}", cur_Triangle.angles[1]);
                    Angle_C_TxtBox.Text = String.Format("{0:0.####}", cur_Triangle.angles[2]);
                }
            }

            else {
                Result_Label.Text = BASE_LBL;
                Angle_A_TxtBox.Text = EMPTY;
                Angle_B_TxtBox.Text = EMPTY;
                Angle_C_TxtBox.Text = EMPTY;
            }
        }

        private void Side_a_TxtBox_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = check_KeyPress(e.KeyChar, Side_a_TxtBox.Text, ref a_Num_Periods);
            }

            finally {}
        }

        private void Side_a_TxtBox_TextChanged(object sender, EventArgs e) {
            side_a_Txt = Side_a_TxtBox.Text;

            /* If a section of the number is highlighted and then deleted along with the
               decimal point, then the decimal point count needs to be decremented. */
            if (!side_a_Txt.Contains(PERIOD) && a_Num_Periods == 1) {
                a_Num_Periods--;
            }

            update_Result();
        }

        private void Side_b_TxtBox_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = check_KeyPress(e.KeyChar, Side_b_TxtBox.Text, ref b_Num_Periods);
            }

            finally {}
        }

        private void Side_b_TxtBox_TextChanged(object sender, EventArgs e) {
            side_b_Txt = Side_b_TxtBox.Text;

            /* If a section of the number is highlighted and then deleted along with the
               decimal point, then the decimal point count needs to be decremented. */
            if (!side_b_Txt.Contains(PERIOD) && b_Num_Periods == 1) {
                b_Num_Periods--;
            }

            update_Result();
        }

        private void Side_c_TxtBox_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                e.Handled = check_KeyPress(e.KeyChar, Side_c_TxtBox.Text, ref c_Num_Periods);
            }

            finally { }
        }

        private void Side_c_TxtBox_TextChanged(object sender, EventArgs e) {
            side_c_Txt = Side_c_TxtBox.Text;

            /* If a section of the number is highlighted and then deleted along with the
               decimal point, then the decimal point count needs to be decremented. */
            if (!side_c_Txt.Contains(PERIOD) && c_Num_Periods == 1) {
                c_Num_Periods--;
            }

            update_Result();
        }

        /* This function ensures that only numbers, decimal points, and backspaces can
           be entered in the textboxes. */
        private bool check_KeyPress(char key_Pressed, string cur_Text, ref int texts_Num_Periods) {
            bool is_Handled = false;
            int text_Len = cur_Text.Length;

            is_Handled = !char.IsDigit(key_Pressed);

            if (key_Pressed == PERIOD) {
                is_Handled = false;
                texts_Num_Periods++;
            }

            //There can be a maximum of one decimal point in the number. 
            if (texts_Num_Periods > 1) {
                is_Handled = true;
                texts_Num_Periods--;
                Debug.Assert(texts_Num_Periods == 1, "There can only be one decimal point in a number");
            }

            if (key_Pressed == (char)Keys.Back) {
                is_Handled = false;

                /* If the decimal point is deleted, then the decimal point count
                   needs to be decremented. */
                if (text_Len > 0 && cur_Text[text_Len - 1] == PERIOD) {
                    Debug.Assert(texts_Num_Periods == 1, "There can only be one decimal point in a number");
                    texts_Num_Periods--;
                }
            }

            return is_Handled;
        }
    }
}