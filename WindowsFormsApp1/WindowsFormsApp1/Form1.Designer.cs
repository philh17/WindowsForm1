namespace WindowsFormsApp1
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
            this.pressMe = new System.Windows.Forms.Button();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pressMe
            // 
            this.pressMe.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pressMe.BackColor = System.Drawing.Color.DarkGray;
            this.pressMe.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressMe.ForeColor = System.Drawing.Color.Black;
            this.pressMe.Location = new System.Drawing.Point(197, 99);
            this.pressMe.Name = "pressMe";
            this.pressMe.Size = new System.Drawing.Size(75, 50);
            this.pressMe.TabIndex = 0;
            this.pressMe.Text = "Go";
            this.pressMe.UseVisualStyleBackColor = false;
            this.pressMe.Click += new System.EventHandler(this.pressMe_Click);
            this.pressMe.MouseLeave += new System.EventHandler(this.pressMe_MouseLeave);
            this.pressMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pressMe_MouseMove);
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(25, 99);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(45, 20);
            this.txtPercent.TabIndex = 1;
            this.txtPercent.TextChanged += new System.EventHandler(this.txtPercent_TextChanged);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(23, 83);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(68, 13);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "APR Amount";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(21, 15);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(34, 13);
            this.lblGross.TabIndex = 4;
            this.lblGross.Text = "Gross";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(23, 31);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(64, 20);
            this.txtGross.TabIndex = 3;
            this.txtGross.TextChanged += new System.EventHandler(this.txtGross_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.pressMe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Net Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pressMe;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label1;
    }
}

