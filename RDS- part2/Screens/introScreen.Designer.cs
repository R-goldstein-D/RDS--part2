namespace RDS__part2
{
    partial class introScreen
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.nameOutput = new System.Windows.Forms.Label();
            this.fancylabel = new System.Windows.Forms.Label();
            this.femButton = new System.Windows.Forms.Button();
            this.mascButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoutput
            // 
            this.textoutput.BackColor = System.Drawing.Color.LightCoral;
            this.textoutput.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoutput.Location = new System.Drawing.Point(-14, 472);
            this.textoutput.Name = "textoutput";
            this.textoutput.Size = new System.Drawing.Size(1228, 140);
            this.textoutput.TabIndex = 0;
            this.textoutput.Text = "Welcome to RDS; part II..ready for your adventure?";
            this.textoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("SimSun-ExtB", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(469, 254);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(276, 63);
            this.nameInput.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(541, 336);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(133, 57);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK!";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.Color.LightCoral;
            this.nameOutput.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutput.Location = new System.Drawing.Point(3, 418);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(376, 54);
            this.nameOutput.TabIndex = 6;
            this.nameOutput.Text = "Ria";
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fancylabel
            // 
            this.fancylabel.BackColor = System.Drawing.Color.LightCoral;
            this.fancylabel.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancylabel.Location = new System.Drawing.Point(3, 455);
            this.fancylabel.Name = "fancylabel";
            this.fancylabel.Size = new System.Drawing.Size(376, 54);
            this.fancylabel.TabIndex = 7;
            this.fancylabel.Text = "―*☆*――*☆*――*☆*――*☆*――*☆*";
            this.fancylabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // femButton
            // 
            this.femButton.Location = new System.Drawing.Point(663, 80);
            this.femButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.femButton.Name = "femButton";
            this.femButton.Size = new System.Drawing.Size(483, 304);
            this.femButton.TabIndex = 8;
            this.femButton.Text = "Femminine";
            this.femButton.UseVisualStyleBackColor = true;
            this.femButton.Click += new System.EventHandler(this.femButton_Click);
            // 
            // mascButton
            // 
            this.mascButton.Location = new System.Drawing.Point(50, 80);
            this.mascButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mascButton.Name = "mascButton";
            this.mascButton.Size = new System.Drawing.Size(483, 304);
            this.mascButton.TabIndex = 9;
            this.mascButton.Text = "Masculine";
            this.mascButton.UseVisualStyleBackColor = true;
            this.mascButton.Click += new System.EventHandler(this.mascButton_Click);
            // 
            // introScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.mascButton);
            this.Controls.Add(this.femButton);
            this.Controls.Add(this.fancylabel);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.textoutput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "introScreen";
            this.Size = new System.Drawing.Size(1192, 600);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.introScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoutput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label fancylabel;
        private System.Windows.Forms.Button femButton;
        private System.Windows.Forms.Button mascButton;
    }
}
