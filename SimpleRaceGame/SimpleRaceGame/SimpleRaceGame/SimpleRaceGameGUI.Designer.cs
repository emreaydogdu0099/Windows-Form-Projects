namespace SimpleRaceGame
{
    partial class SimpleRaceGameGUI
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
            this.components = new System.ComponentModel.Container();
            this.pcbFord = new System.Windows.Forms.PictureBox();
            this.pcbRenault = new System.Windows.Forms.PictureBox();
            this.pcbMercedes = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRenault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMercedes)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbFord
            // 
            this.pcbFord.Image = global::SimpleRaceGame.Properties.Resources.ford;
            this.pcbFord.Location = new System.Drawing.Point(149, 127);
            this.pcbFord.Name = "pcbFord";
            this.pcbFord.Size = new System.Drawing.Size(125, 108);
            this.pcbFord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFord.TabIndex = 0;
            this.pcbFord.TabStop = false;
            // 
            // pcbRenault
            // 
            this.pcbRenault.Image = global::SimpleRaceGame.Properties.Resources.renault;
            this.pcbRenault.Location = new System.Drawing.Point(149, 271);
            this.pcbRenault.Name = "pcbRenault";
            this.pcbRenault.Size = new System.Drawing.Size(125, 108);
            this.pcbRenault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRenault.TabIndex = 0;
            this.pcbRenault.TabStop = false;
            // 
            // pcbMercedes
            // 
            this.pcbMercedes.Image = global::SimpleRaceGame.Properties.Resources.mercedes;
            this.pcbMercedes.Location = new System.Drawing.Point(149, 411);
            this.pcbMercedes.Name = "pcbMercedes";
            this.pcbMercedes.Size = new System.Drawing.Size(125, 108);
            this.pcbMercedes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMercedes.TabIndex = 0;
            this.pcbMercedes.TabStop = false;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Lime;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinish.Location = new System.Drawing.Point(1066, 127);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(42, 392);
            this.lblFinish.TabIndex = 1;
            this.lblFinish.Text = "FINISH";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(576, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.pcbMercedes);
            this.Controls.Add(this.pcbRenault);
            this.Controls.Add(this.pcbFord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRenault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMercedes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFord;
        private System.Windows.Forms.PictureBox pcbRenault;
        private System.Windows.Forms.PictureBox pcbMercedes;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
    }
}

