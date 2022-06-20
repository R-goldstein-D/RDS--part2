namespace RDS__part2
{
    partial class bellabadendingScreen
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
            this.nameOutput = new System.Windows.Forms.Label();
            this.fancylabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoutput
            // 
            this.textoutput.BackColor = System.Drawing.Color.LightCoral;
            this.textoutput.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoutput.Location = new System.Drawing.Point(-4, 460);
            this.textoutput.Name = "textoutput";
            this.textoutput.Size = new System.Drawing.Size(1228, 140);
            this.textoutput.TabIndex = 1;
            this.textoutput.Text = "The night was cold";
            this.textoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.Color.LightCoral;
            this.nameOutput.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutput.Location = new System.Drawing.Point(-4, 406);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(376, 54);
            this.nameOutput.TabIndex = 7;
            this.nameOutput.Text = "Narrator";
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fancylabel
            // 
            this.fancylabel.BackColor = System.Drawing.Color.LightCoral;
            this.fancylabel.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancylabel.Location = new System.Drawing.Point(-4, 448);
            this.fancylabel.Name = "fancylabel";
            this.fancylabel.Size = new System.Drawing.Size(376, 54);
            this.fancylabel.TabIndex = 8;
            this.fancylabel.Text = "―*☆*――*☆*――*☆*――*☆*――*☆*";
            this.fancylabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bellabadendingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fancylabel);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.textoutput);
            this.Name = "bellabadendingScreen";
            this.Size = new System.Drawing.Size(1192, 600);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bellabadendingScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textoutput;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label fancylabel;
    }
}
