namespace RDS__part2
{
    partial class premiumScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(premiumScreen));
            this.startoverButton = new System.Windows.Forms.Button();
            this.textoutput = new System.Windows.Forms.Label();
            this.getperimiumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startoverButton
            // 
            this.startoverButton.Font = new System.Drawing.Font("SimSun", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startoverButton.Location = new System.Drawing.Point(287, 442);
            this.startoverButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startoverButton.Name = "startoverButton";
            this.startoverButton.Size = new System.Drawing.Size(198, 81);
            this.startoverButton.TabIndex = 6;
            this.startoverButton.Text = "START OVER";
            this.startoverButton.UseVisualStyleBackColor = true;
            this.startoverButton.Click += new System.EventHandler(this.startoverButton_Click);
            // 
            // textoutput
            // 
            this.textoutput.BackColor = System.Drawing.Color.LightCoral;
            this.textoutput.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoutput.Location = new System.Drawing.Point(-18, 101);
            this.textoutput.Name = "textoutput";
            this.textoutput.Size = new System.Drawing.Size(1228, 269);
            this.textoutput.TabIndex = 7;
            this.textoutput.Text = resources.GetString("textoutput.Text");
            this.textoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getperimiumButton
            // 
            this.getperimiumButton.Font = new System.Drawing.Font("SimSun", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getperimiumButton.Location = new System.Drawing.Point(738, 442);
            this.getperimiumButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getperimiumButton.Name = "getperimiumButton";
            this.getperimiumButton.Size = new System.Drawing.Size(198, 81);
            this.getperimiumButton.TabIndex = 8;
            this.getperimiumButton.Text = "GET PREMIUM";
            this.getperimiumButton.UseVisualStyleBackColor = true;
            this.getperimiumButton.Click += new System.EventHandler(this.getperimiumButton_Click);
            // 
            // premiumScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getperimiumButton);
            this.Controls.Add(this.textoutput);
            this.Controls.Add(this.startoverButton);
            this.Name = "premiumScreen";
            this.Size = new System.Drawing.Size(1192, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startoverButton;
        private System.Windows.Forms.Label textoutput;
        private System.Windows.Forms.Button getperimiumButton;
    }
}
