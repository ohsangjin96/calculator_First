namespace calculator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sum = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Cross = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(387, 74);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(110, 23);
            this.Sum.TabIndex = 0;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(387, 125);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(110, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Cross
            // 
            this.Cross.Location = new System.Drawing.Point(387, 176);
            this.Cross.Name = "Cross";
            this.Cross.Size = new System.Drawing.Size(110, 23);
            this.Cross.TabIndex = 2;
            this.Cross.Text = "*";
            this.Cross.UseVisualStyleBackColor = true;
            this.Cross.Click += new System.EventHandler(this.Cross_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(387, 230);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(110, 23);
            this.Division.TabIndex = 3;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(29, 75);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(114, 23);
            this.num1.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(201, 75);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(108, 23);
            this.num2.TabIndex = 5;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(574, 76);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 293);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Cross);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Cross;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox result;
    }
}

