namespace TestWindowsFormsApp2
{
    partial class Form1
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
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(171, 41);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(374, 27);
            this.name.TabIndex = 0;
            this.name.Text = "username:";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.UseWaitCursor = true;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(171, 86);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(374, 28);
            this.password.TabIndex = 1;
            this.password.Text = "password:";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(696, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
    }
}

