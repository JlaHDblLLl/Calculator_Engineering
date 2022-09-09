namespace Calculator
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
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiplise = new System.Windows.Forms.Button();
            this.Devise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(147, 220);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(48, 44);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(93, 220);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(48, 44);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // Multiplise
            // 
            this.Multiplise.Location = new System.Drawing.Point(201, 220);
            this.Multiplise.Name = "Multiplise";
            this.Multiplise.Size = new System.Drawing.Size(48, 44);
            this.Multiplise.TabIndex = 2;
            this.Multiplise.Text = "*";
            this.Multiplise.UseVisualStyleBackColor = true;
            // 
            // Devise
            // 
            this.Devise.Location = new System.Drawing.Point(255, 220);
            this.Devise.Name = "Devise";
            this.Devise.Size = new System.Drawing.Size(48, 44);
            this.Devise.TabIndex = 3;
            this.Devise.Text = "/";
            this.Devise.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(580, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Devise);
            this.Controls.Add(this.Multiplise);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Plus;
        private Button Minus;
        private Button Multiplise;
        private Button Devise;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}