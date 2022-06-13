namespace RDS__part2
{
    partial class bellagameScreen
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
            this.leftArrow = new System.Windows.Forms.Label();
            this.rightArrow = new System.Windows.Forms.Label();
            this.leftOption = new System.Windows.Forms.Label();
            this.rightOption = new System.Windows.Forms.Label();
            this.letsplayButton = new System.Windows.Forms.Button();
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
            this.textoutput.Text = "What unique choice";
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
            this.nameOutput.Text = "Ria";
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fancylabel
            // 
            this.fancylabel.BackColor = System.Drawing.Color.LightCoral;
            this.fancylabel.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancylabel.Location = new System.Drawing.Point(-4, 450);
            this.fancylabel.Name = "fancylabel";
            this.fancylabel.Size = new System.Drawing.Size(376, 54);
            this.fancylabel.TabIndex = 8;
            this.fancylabel.Text = "―*☆*――*☆*――*☆*――*☆*――*☆*";
            this.fancylabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.Font = new System.Drawing.Font("SimSun-ExtB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftArrow.Location = new System.Drawing.Point(207, 175);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(80, 88);
            this.leftArrow.TabIndex = 9;
            this.leftArrow.Text = "←";
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.Font = new System.Drawing.Font("SimSun-ExtB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightArrow.Location = new System.Drawing.Point(898, 175);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(80, 88);
            this.rightArrow.TabIndex = 10;
            this.rightArrow.Text = "→";
            // 
            // leftOption
            // 
            this.leftOption.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.leftOption.BackColor = System.Drawing.Color.DarkRed;
            this.leftOption.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftOption.ForeColor = System.Drawing.SystemColors.Control;
            this.leftOption.Location = new System.Drawing.Point(70, 263);
            this.leftOption.Name = "leftOption";
            this.leftOption.Size = new System.Drawing.Size(376, 54);
            this.leftOption.TabIndex = 11;
            this.leftOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightOption
            // 
            this.rightOption.BackColor = System.Drawing.Color.DarkRed;
            this.rightOption.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOption.ForeColor = System.Drawing.SystemColors.Control;
            this.rightOption.Location = new System.Drawing.Point(757, 263);
            this.rightOption.Name = "rightOption";
            this.rightOption.Size = new System.Drawing.Size(376, 54);
            this.rightOption.TabIndex = 12;
            this.rightOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letsplayButton
            // 
            this.letsplayButton.Font = new System.Drawing.Font("SimSun", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letsplayButton.Location = new System.Drawing.Point(502, 244);
            this.letsplayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letsplayButton.Name = "letsplayButton";
            this.letsplayButton.Size = new System.Drawing.Size(210, 98);
            this.letsplayButton.TabIndex = 13;
            this.letsplayButton.Text = "LETS PLAY!";
            this.letsplayButton.UseVisualStyleBackColor = true;
            this.letsplayButton.Click += new System.EventHandler(this.letsplayButton_Click);
            // 
            // bellagameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.letsplayButton);
            this.Controls.Add(this.rightOption);
            this.Controls.Add(this.leftOption);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.fancylabel);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.textoutput);
            this.Name = "bellagameScreen";
            this.Size = new System.Drawing.Size(1192, 600);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bellagameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textoutput;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label fancylabel;
        private System.Windows.Forms.Label leftArrow;
        private System.Windows.Forms.Label rightArrow;
        private System.Windows.Forms.Label leftOption;
        private System.Windows.Forms.Label rightOption;
        private System.Windows.Forms.Button letsplayButton;
    }
}
