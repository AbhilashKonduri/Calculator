namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.point = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.sqroot = new System.Windows.Forms.Button();
            this.receprocal = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.PictureBox();
            this.A2D = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.point);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.reload);
            this.panel1.Controls.Add(this.sqroot);
            this.panel1.Controls.Add(this.receprocal);
            this.panel1.Controls.Add(this.div);
            this.panel1.Controls.Add(this.mult);
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.zero);
            this.panel1.Controls.Add(this.nine);
            this.panel1.Controls.Add(this.six);
            this.panel1.Controls.Add(this.five);
            this.panel1.Controls.Add(this.eight);
            this.panel1.Controls.Add(this.seven);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.one);
            this.panel1.Location = new System.Drawing.Point(0, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 522);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.point.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.point.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.point.Location = new System.Drawing.Point(29, 357);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(62, 62);
            this.point.TabIndex = 36;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.equal.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equal.Location = new System.Drawing.Point(216, 354);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(62, 62);
            this.equal.TabIndex = 35;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.SystemColors.Info;
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.reload.Location = new System.Drawing.Point(431, 355);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(79, 64);
            this.reload.TabIndex = 34;
            this.reload.Text = "REL";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // sqroot
            // 
            this.sqroot.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sqroot.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqroot.Location = new System.Drawing.Point(431, 148);
            this.sqroot.Name = "sqroot";
            this.sqroot.Size = new System.Drawing.Size(62, 62);
            this.sqroot.TabIndex = 33;
            this.sqroot.Text = "√x";
            this.sqroot.UseVisualStyleBackColor = false;
            this.sqroot.Click += new System.EventHandler(this.sqroot_Click);
            // 
            // receprocal
            // 
            this.receprocal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.receprocal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receprocal.Location = new System.Drawing.Point(431, 41);
            this.receprocal.Name = "receprocal";
            this.receprocal.Size = new System.Drawing.Size(62, 62);
            this.receprocal.TabIndex = 32;
            this.receprocal.Text = "1/x";
            this.receprocal.UseVisualStyleBackColor = false;
            this.receprocal.Click += new System.EventHandler(this.receprocal_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.div.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(345, 357);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(62, 62);
            this.div.TabIndex = 31;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mult.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(345, 255);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(62, 62);
            this.mult.TabIndex = 30;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.minus.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(345, 148);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(62, 62);
            this.minus.TabIndex = 29;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zero.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zero.Location = new System.Drawing.Point(123, 357);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(62, 62);
            this.zero.TabIndex = 28;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nine.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nine.Location = new System.Drawing.Point(216, 253);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(62, 62);
            this.nine.TabIndex = 27;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.six.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.six.Location = new System.Drawing.Point(216, 147);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(62, 62);
            this.six.TabIndex = 26;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.five.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.five.Location = new System.Drawing.Point(123, 147);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(62, 62);
            this.five.TabIndex = 25;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button4_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eight.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eight.Location = new System.Drawing.Point(123, 253);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(62, 62);
            this.eight.TabIndex = 24;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.seven.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seven.Location = new System.Drawing.Point(29, 254);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(62, 62);
            this.seven.TabIndex = 23;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.four.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.four.Location = new System.Drawing.Point(29, 148);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(62, 62);
            this.four.TabIndex = 22;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.three.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.three.Location = new System.Drawing.Point(216, 41);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(62, 62);
            this.three.TabIndex = 21;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.two.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.two.Location = new System.Drawing.Point(123, 41);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(62, 62);
            this.two.TabIndex = 20;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.plus.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(345, 43);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(62, 62);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.Info;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button24.Location = new System.Drawing.Point(431, 253);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(79, 64);
            this.button24.TabIndex = 14;
            this.button24.Text = "REC";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.one.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.one.Location = new System.Drawing.Point(29, 42);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(62, 62);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.button1_Click);
            // 
            // Memory
            // 
            this.Memory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Memory.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.Memory.Location = new System.Drawing.Point(10, 21);
            this.Memory.MaximumSize = new System.Drawing.Size(4, 100000);
            this.Memory.MinimumSize = new System.Drawing.Size(250, 55);
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            this.Memory.Size = new System.Drawing.Size(250, 55);
            this.Memory.TabIndex = 1;
            this.Memory.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.Reset);
            this.panel2.Controls.Add(this.A2D);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.answer);
            this.panel2.Controls.Add(this.Display);
            this.panel2.Controls.Add(this.Memory);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 249);
            this.panel2.TabIndex = 1;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Reset.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Reset.ErrorImage")));
            this.Reset.ImageLocation = "D:\\C#\\Calculator\\images\'";
            this.Reset.InitialImage = ((System.Drawing.Image)(resources.GetObject("Reset.InitialImage")));
            this.Reset.Location = new System.Drawing.Point(286, 32);
            this.Reset.MaximumSize = new System.Drawing.Size(40, 40);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(40, 40);
            this.Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Reset.TabIndex = 6;
            this.Reset.TabStop = false;
            this.Reset.Click += new System.EventHandler(this.pictureBox1_Click);
            this.Reset.DoubleClick += new System.EventHandler(this.Form1_Load);
            // 
            // A2D
            // 
            this.A2D.BackColor = System.Drawing.SystemColors.WindowText;
            this.A2D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.A2D.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A2D.Location = new System.Drawing.Point(447, 29);
            this.A2D.Name = "A2D";
            this.A2D.Size = new System.Drawing.Size(91, 47);
            this.A2D.TabIndex = 5;
            this.A2D.Text = "A2D";
            this.A2D.UseVisualStyleBackColor = false;
            this.A2D.Click += new System.EventHandler(this.A2D_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.WindowText;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(350, 29);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 47);
            this.clear.TabIndex = 4;
            this.clear.Text = "CLR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.answer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.answer.Location = new System.Drawing.Point(243, 178);
            this.answer.MaximumSize = new System.Drawing.Size(4, 100000);
            this.answer.MinimumSize = new System.Drawing.Size(250, 40);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(250, 40);
            this.answer.TabIndex = 3;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(10, 107);
            this.Display.MaximumSize = new System.Drawing.Size(4, 100000);
            this.Display.MinimumSize = new System.Drawing.Size(500, 125);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(500, 125);
            this.Display.TabIndex = 2;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(550, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator.exe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox Memory;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button sqroot;
        private System.Windows.Forms.Button receprocal;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button A2D;
        private System.Windows.Forms.PictureBox Reset;
    }
}

