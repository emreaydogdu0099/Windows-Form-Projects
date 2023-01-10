namespace HospitalManagementSystem
{
    partial class Main
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
            this.buttonControl1 = new HospitalManagementSystem.ButtonControl();
            this.SuspendLayout();
            // 
            // buttonControl1
            // 
            this.buttonControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonControl1.Location = new System.Drawing.Point(0, 0);
            this.buttonControl1.Name = "buttonControl1";
            this.buttonControl1.Size = new System.Drawing.Size(1052, 602);
            this.buttonControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 605);
            this.Controls.Add(this.buttonControl1);
            this.Name = "Main";
            this.Text = "Hastane Otomasyonu Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonControl buttonControl1;
    }
}