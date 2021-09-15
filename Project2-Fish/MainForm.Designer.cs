namespace Project2_Fish
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FishLabel = new System.Windows.Forms.Label();
            this.crappieButton = new System.Windows.Forms.RadioButton();
            this.perchButton = new System.Windows.Forms.RadioButton();
            this.walleyeButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.walleyeButton);
            this.panel1.Controls.Add(this.perchButton);
            this.panel1.Controls.Add(this.crappieButton);
            this.panel1.Location = new System.Drawing.Point(170, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 273);
            this.panel1.TabIndex = 0;
            // 
            // FishLabel
            // 
            this.FishLabel.AutoSize = true;
            this.FishLabel.Location = new System.Drawing.Point(195, 31);
            this.FishLabel.Name = "FishLabel";
            this.FishLabel.Size = new System.Drawing.Size(103, 13);
            this.FishLabel.TabIndex = 1;
            this.FishLabel.Text = "Choose a fish to see";

            this.FishLabel.Click += new System.EventHandler(this.label1_Click);

            // 
            // crappieButton
            // 
            this.crappieButton.AutoSize = true;
            this.crappieButton.Location = new System.Drawing.Point(67, 74);
            this.crappieButton.Name = "crappieButton";
            this.crappieButton.Size = new System.Drawing.Size(61, 17);
            this.crappieButton.TabIndex = 0;
            this.crappieButton.TabStop = true;
            this.crappieButton.Text = "Crappie";
            this.crappieButton.UseVisualStyleBackColor = true;

            this.crappieButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);

            // 
            // perchButton
            // 
            this.perchButton.AutoSize = true;
            this.perchButton.Location = new System.Drawing.Point(79, 134);
            this.perchButton.Name = "perchButton";
            this.perchButton.Size = new System.Drawing.Size(53, 17);
            this.perchButton.TabIndex = 1;
            this.perchButton.TabStop = true;
            this.perchButton.Text = "Perch";
            this.perchButton.UseVisualStyleBackColor = true;
            // 
            // walleyeButton
            // 
            this.walleyeButton.AutoSize = true;
            this.walleyeButton.Location = new System.Drawing.Point(79, 194);
            this.walleyeButton.Name = "walleyeButton";
            this.walleyeButton.Size = new System.Drawing.Size(63, 17);
            this.walleyeButton.TabIndex = 2;
            this.walleyeButton.TabStop = true;
            this.walleyeButton.Text = "Walleye";
            this.walleyeButton.UseVisualStyleBackColor = true;

            this.walleyeButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FishLabel);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FishLabel;
        private System.Windows.Forms.RadioButton walleyeButton;
        private System.Windows.Forms.RadioButton perchButton;
        private System.Windows.Forms.RadioButton crappieButton;
    }
}