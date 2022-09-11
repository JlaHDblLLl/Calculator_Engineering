namespace Calculator
{
    partial class Form_Calculator
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
            this.Up = new System.Windows.Forms.Button();
            this.Switch = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Button();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(11, 102);
            this.Plus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(64, 59);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(11, 39);
            this.Minus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(64, 59);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiplise
            // 
            this.Multiplise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Multiplise.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiplise.Location = new System.Drawing.Point(79, 39);
            this.Multiplise.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Multiplise.Name = "Multiplise";
            this.Multiplise.Size = new System.Drawing.Size(64, 59);
            this.Multiplise.TabIndex = 2;
            this.Multiplise.Text = "*";
            this.Multiplise.UseVisualStyleBackColor = true;
            this.Multiplise.Click += new System.EventHandler(this.Multiplise_Click);
            // 
            // Devise
            // 
            this.Devise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Devise.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Devise.Location = new System.Drawing.Point(79, 102);
            this.Devise.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Devise.Name = "Devise";
            this.Devise.Size = new System.Drawing.Size(64, 59);
            this.Devise.TabIndex = 3;
            this.Devise.Text = "/";
            this.Devise.UseVisualStyleBackColor = true;
            this.Devise.Click += new System.EventHandler(this.Devise_Click);
            // 
            // Up
            // 
            this.Up.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Up.Location = new System.Drawing.Point(332, 39);
            this.Up.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(64, 59);
            this.Up.TabIndex = 7;
            this.Up.Text = "↑";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Switch
            // 
            this.Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Switch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Switch.Location = new System.Drawing.Point(332, 102);
            this.Switch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(64, 59);
            this.Switch.TabIndex = 6;
            this.Switch.Text = "⤥⤣";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // Down
            // 
            this.Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Down.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Down.Location = new System.Drawing.Point(400, 39);
            this.Down.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(64, 59);
            this.Down.TabIndex = 5;
            this.Down.Text = "↓";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Rotate
            // 
            this.Rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rotate.Location = new System.Drawing.Point(400, 102);
            this.Rotate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(64, 59);
            this.Rotate.TabIndex = 4;
            this.Rotate.Text = "↻";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // textBox0
            // 
            this.textBox0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox0.Location = new System.Drawing.Point(148, 39);
            this.textBox0.Name = "textBox0";
            this.textBox0.ReadOnly = true;
            this.textBox0.Size = new System.Drawing.Size(179, 23);
            this.textBox0.TabIndex = 8;
            this.textBox0.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(148, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(148, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(179, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox3.Location = new System.Drawing.Point(148, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 23);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // Form_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(475, 183);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.Devise);
            this.Controls.Add(this.Multiplise);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(491, 222);
            this.Name = "Form_Calculator";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Plus;
        private Button Minus;
        private Button Multiplise;
        private Button Devise;
        private Button Up;
        private Button Switch;
        private Button Down;
        private Button Rotate;
        private TextBox textBox0;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}