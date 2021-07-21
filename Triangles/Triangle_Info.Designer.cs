
namespace Triangles {
    partial class Triangle_Info {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Side_a_TxtBox = new System.Windows.Forms.TextBox();
            this.Side_b_TxtBox = new System.Windows.Forms.TextBox();
            this.Side_c_TxtBox = new System.Windows.Forms.TextBox();
            this.Side_a_Label = new System.Windows.Forms.Label();
            this.Side_b_Label = new System.Windows.Forms.Label();
            this.Side_c_Label = new System.Windows.Forms.Label();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Angle_A_TxtBox = new System.Windows.Forms.TextBox();
            this.Angle_A_Label = new System.Windows.Forms.Label();
            this.Angle_B_TxtBox = new System.Windows.Forms.TextBox();
            this.Angle_C_TxtBox = new System.Windows.Forms.TextBox();
            this.Angle_B_Label = new System.Windows.Forms.Label();
            this.Angle_C_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Side_a_TxtBox
            // 
            this.Side_a_TxtBox.Location = new System.Drawing.Point(196, 44);
            this.Side_a_TxtBox.Name = "Side_a_TxtBox";
            this.Side_a_TxtBox.Size = new System.Drawing.Size(129, 31);
            this.Side_a_TxtBox.TabIndex = 0;
            this.Side_a_TxtBox.TextChanged += new System.EventHandler(this.Side_a_TxtBox_TextChanged);
            this.Side_a_TxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Side_a_TxtBox_KeyPress);
            // 
            // Side_b_TxtBox
            // 
            this.Side_b_TxtBox.Location = new System.Drawing.Point(197, 105);
            this.Side_b_TxtBox.Name = "Side_b_TxtBox";
            this.Side_b_TxtBox.Size = new System.Drawing.Size(129, 31);
            this.Side_b_TxtBox.TabIndex = 1;
            this.Side_b_TxtBox.TextChanged += new System.EventHandler(this.Side_b_TxtBox_TextChanged);
            this.Side_b_TxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Side_b_TxtBox_KeyPress);
            // 
            // Side_c_TxtBox
            // 
            this.Side_c_TxtBox.Location = new System.Drawing.Point(196, 165);
            this.Side_c_TxtBox.Name = "Side_c_TxtBox";
            this.Side_c_TxtBox.Size = new System.Drawing.Size(129, 31);
            this.Side_c_TxtBox.TabIndex = 2;
            this.Side_c_TxtBox.TextChanged += new System.EventHandler(this.Side_c_TxtBox_TextChanged);
            this.Side_c_TxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Side_c_TxtBox_KeyPress);
            // 
            // Side_a_Label
            // 
            this.Side_a_Label.AutoSize = true;
            this.Side_a_Label.Location = new System.Drawing.Point(47, 47);
            this.Side_a_Label.Name = "Side_a_Label";
            this.Side_a_Label.Size = new System.Drawing.Size(144, 25);
            this.Side_a_Label.TabIndex = 3;
            this.Side_a_Label.Text = "Side a length:";
            // 
            // Side_b_Label
            // 
            this.Side_b_Label.AutoSize = true;
            this.Side_b_Label.Location = new System.Drawing.Point(47, 108);
            this.Side_b_Label.Name = "Side_b_Label";
            this.Side_b_Label.Size = new System.Drawing.Size(144, 25);
            this.Side_b_Label.TabIndex = 4;
            this.Side_b_Label.Text = "Side b length:";
            // 
            // Side_c_Label
            // 
            this.Side_c_Label.AutoSize = true;
            this.Side_c_Label.Location = new System.Drawing.Point(47, 168);
            this.Side_c_Label.Name = "Side_c_Label";
            this.Side_c_Label.Size = new System.Drawing.Size(143, 25);
            this.Side_c_Label.TabIndex = 5;
            this.Side_c_Label.Text = "Side c length:";
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Location = new System.Drawing.Point(47, 271);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(200, 25);
            this.Result_Label.TabIndex = 6;
            this.Result_Label.Text = "These side lengths ";
            // 
            // Angle_A_TxtBox
            // 
            this.Angle_A_TxtBox.Enabled = false;
            this.Angle_A_TxtBox.Location = new System.Drawing.Point(471, 44);
            this.Angle_A_TxtBox.Name = "Angle_A_TxtBox";
            this.Angle_A_TxtBox.Size = new System.Drawing.Size(129, 31);
            this.Angle_A_TxtBox.TabIndex = 7;
            // 
            // Angle_A_Label
            // 
            this.Angle_A_Label.AutoSize = true;
            this.Angle_A_Label.Location = new System.Drawing.Point(372, 47);
            this.Angle_A_Label.Name = "Angle_A_Label";
            this.Angle_A_Label.Size = new System.Drawing.Size(93, 25);
            this.Angle_A_Label.TabIndex = 8;
            this.Angle_A_Label.Text = "Angle A:";
            // 
            // Angle_B_TxtBox
            // 
            this.Angle_B_TxtBox.Enabled = false;
            this.Angle_B_TxtBox.Location = new System.Drawing.Point(471, 105);
            this.Angle_B_TxtBox.Name = "Angle_B_TxtBox";
            this.Angle_B_TxtBox.Size = new System.Drawing.Size(129, 31);
            this.Angle_B_TxtBox.TabIndex = 9;
            // 
            // Angle_C_TxtBox
            // 
            this.Angle_C_TxtBox.Enabled = false;
            this.Angle_C_TxtBox.Location = new System.Drawing.Point(471, 165);
            this.Angle_C_TxtBox.Name = "Angle_C_TxtBox";
            this.Angle_C_TxtBox.Size = new System.Drawing.Size(129, 31);
            this.Angle_C_TxtBox.TabIndex = 10;
            // 
            // Angle_B_Label
            // 
            this.Angle_B_Label.AutoSize = true;
            this.Angle_B_Label.Location = new System.Drawing.Point(372, 108);
            this.Angle_B_Label.Name = "Angle_B_Label";
            this.Angle_B_Label.Size = new System.Drawing.Size(93, 25);
            this.Angle_B_Label.TabIndex = 11;
            this.Angle_B_Label.Text = "Angle B:";
            // 
            // Angle_C_Label
            // 
            this.Angle_C_Label.AutoSize = true;
            this.Angle_C_Label.Location = new System.Drawing.Point(371, 168);
            this.Angle_C_Label.Name = "Angle_C_Label";
            this.Angle_C_Label.Size = new System.Drawing.Size(94, 25);
            this.Angle_C_Label.TabIndex = 12;
            this.Angle_C_Label.Text = "Angle C:";
            // 
            // Triangle_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 536);
            this.Controls.Add(this.Angle_C_Label);
            this.Controls.Add(this.Angle_B_Label);
            this.Controls.Add(this.Angle_C_TxtBox);
            this.Controls.Add(this.Angle_B_TxtBox);
            this.Controls.Add(this.Angle_A_Label);
            this.Controls.Add(this.Angle_A_TxtBox);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Side_c_Label);
            this.Controls.Add(this.Side_b_Label);
            this.Controls.Add(this.Side_a_Label);
            this.Controls.Add(this.Side_c_TxtBox);
            this.Controls.Add(this.Side_b_TxtBox);
            this.Controls.Add(this.Side_a_TxtBox);
            this.Name = "Triangle_Info";
            this.Text = "Triangle Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Side_a_TxtBox;
        private System.Windows.Forms.TextBox Side_b_TxtBox;
        private System.Windows.Forms.TextBox Side_c_TxtBox;
        private System.Windows.Forms.Label Side_a_Label;
        private System.Windows.Forms.Label Side_b_Label;
        private System.Windows.Forms.Label Side_c_Label;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.TextBox Angle_A_TxtBox;
        private System.Windows.Forms.Label Angle_A_Label;
        private System.Windows.Forms.TextBox Angle_B_TxtBox;
        private System.Windows.Forms.TextBox Angle_C_TxtBox;
        private System.Windows.Forms.Label Angle_B_Label;
        private System.Windows.Forms.Label Angle_C_Label;
    }
}

