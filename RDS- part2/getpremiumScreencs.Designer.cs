namespace RDS__part2
{
    partial class getpremiumScreencs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoutput
            // 
            this.textoutput.BackColor = System.Drawing.Color.LightCoral;
            this.textoutput.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoutput.Location = new System.Drawing.Point(-18, 166);
            this.textoutput.Name = "textoutput";
            this.textoutput.Size = new System.Drawing.Size(1228, 269);
            this.textoutput.TabIndex = 8;
            this.textoutput.Text = "To gain premium access, please give the payment to the developer,\r\nRia Das\r\nin ca" +
    "sh!!\r\nThank you :))";
            this.textoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getpremiumScreencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textoutput);
            this.Name = "getpremiumScreencs";
            this.Size = new System.Drawing.Size(1192, 600);
            this.Load += new System.EventHandler(this.getpremiumScreencs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textoutput;
    }
}
