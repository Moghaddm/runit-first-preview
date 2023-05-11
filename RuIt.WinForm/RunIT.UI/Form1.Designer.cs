namespace RunIT.UI
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
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radStepProgressBar1 = new Telerik.WinControls.UI.RadStepProgressBar();
            this.stepProgressItem1 = new Telerik.WinControls.UI.StepProgressItem();
            this.stepProgressItem2 = new Telerik.WinControls.UI.StepProgressItem();
            this.stepProgressItem3 = new Telerik.WinControls.UI.StepProgressItem();
            this.stepProgressItem4 = new Telerik.WinControls.UI.StepProgressItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStepProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(405, 50);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "RunIT";
            this.radTitleBar1.ThemeName = "Material";
            // 
            // radButton1
            // 
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radButton1.Location = new System.Drawing.Point(0, 417);
            this.radButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(405, 61);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "OK";
            this.radButton1.ThemeName = "Material";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radStepProgressBar1
            // 
            this.radStepProgressBar1.Location = new System.Drawing.Point(28, 313);
            this.radStepProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radStepProgressBar1.Name = "radStepProgressBar1";
            this.radStepProgressBar1.Size = new System.Drawing.Size(364, 96);
            this.radStepProgressBar1.Steps.AddRange(new Telerik.WinControls.UI.StepProgressItem[] {
            this.stepProgressItem1,
            this.stepProgressItem2,
            this.stepProgressItem3,
            this.stepProgressItem4});
            this.radStepProgressBar1.TabIndex = 1;
            this.radStepProgressBar1.Text = "radStepProgressBar1";
            this.radStepProgressBar1.ThemeName = "Material";
            // 
            // stepProgressItem1
            // 
            this.stepProgressItem1.Name = "stepProgressItem1";
            this.stepProgressItem1.Text = "stepProgressItem1";
            // 
            // stepProgressItem2
            // 
            this.stepProgressItem2.Name = "stepProgressItem2";
            this.stepProgressItem2.Text = "stepProgressItem2";
            // 
            // stepProgressItem3
            // 
            this.stepProgressItem3.Name = "stepProgressItem3";
            this.stepProgressItem3.Text = "stepProgressItem3";
            // 
            // stepProgressItem4
            // 
            this.stepProgressItem4.Name = "stepProgressItem4";
            this.stepProgressItem4.Text = "stepProgressItem4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RunIT.UI.Properties.Resources.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(61, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radStepProgressBar1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "RunIT";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStepProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadStepProgressBar radStepProgressBar1;
        private Telerik.WinControls.UI.StepProgressItem stepProgressItem1;
        private Telerik.WinControls.UI.StepProgressItem stepProgressItem2;
        private Telerik.WinControls.UI.StepProgressItem stepProgressItem3;
        private Telerik.WinControls.UI.StepProgressItem stepProgressItem4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

