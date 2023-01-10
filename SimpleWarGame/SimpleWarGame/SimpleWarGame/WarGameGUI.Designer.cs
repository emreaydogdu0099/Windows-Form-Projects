namespace SimpleWarGame
{
    partial class WarGameGUI
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
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserHealthCount = new System.Windows.Forms.Label();
            this.lblWolfManHealthCount = new System.Windows.Forms.Label();
            this.lblWolfManName = new System.Windows.Forms.Label();
            this.lblUserHealth = new System.Windows.Forms.Label();
            this.lblWolfManHealth = new System.Windows.Forms.Label();
            this.pcbUserPicture = new System.Windows.Forms.PictureBox();
            this.pcbWolfManPicture = new System.Windows.Forms.PictureBox();
            this.btnAttack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfManPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Assasin",
            "Archor"});
            this.cmbBranch.Location = new System.Drawing.Point(233, 212);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(161, 24);
            this.cmbBranch.TabIndex = 11;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbRace.Location = new System.Drawing.Point(233, 144);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(161, 24);
            this.cmbRace.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(233, 78);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(161, 22);
            this.txtUserName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Branch :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Race :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username : ";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(465, 184);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(157, 52);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(465, 78);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(157, 52);
            this.btnNewGame.TabIndex = 13;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Cyan;
            this.lblUserName.Location = new System.Drawing.Point(109, 336);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(137, 38);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserName.Visible = false;
            // 
            // lblUserHealthCount
            // 
            this.lblUserHealthCount.BackColor = System.Drawing.Color.Lime;
            this.lblUserHealthCount.Location = new System.Drawing.Point(272, 336);
            this.lblUserHealthCount.Name = "lblUserHealthCount";
            this.lblUserHealthCount.Size = new System.Drawing.Size(137, 38);
            this.lblUserHealthCount.TabIndex = 15;
            this.lblUserHealthCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserHealthCount.Visible = false;
            // 
            // lblWolfManHealthCount
            // 
            this.lblWolfManHealthCount.BackColor = System.Drawing.Color.Lime;
            this.lblWolfManHealthCount.Location = new System.Drawing.Point(865, 336);
            this.lblWolfManHealthCount.Name = "lblWolfManHealthCount";
            this.lblWolfManHealthCount.Size = new System.Drawing.Size(137, 38);
            this.lblWolfManHealthCount.TabIndex = 17;
            this.lblWolfManHealthCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWolfManHealthCount.Visible = false;
            // 
            // lblWolfManName
            // 
            this.lblWolfManName.BackColor = System.Drawing.Color.Cyan;
            this.lblWolfManName.Location = new System.Drawing.Point(701, 336);
            this.lblWolfManName.Name = "lblWolfManName";
            this.lblWolfManName.Size = new System.Drawing.Size(137, 38);
            this.lblWolfManName.TabIndex = 16;
            this.lblWolfManName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWolfManName.Visible = false;
            // 
            // lblUserHealth
            // 
            this.lblUserHealth.BackColor = System.Drawing.Color.Red;
            this.lblUserHealth.Location = new System.Drawing.Point(109, 414);
            this.lblUserHealth.Name = "lblUserHealth";
            this.lblUserHealth.Size = new System.Drawing.Size(300, 23);
            this.lblUserHealth.TabIndex = 18;
            this.lblUserHealth.Visible = false;
            // 
            // lblWolfManHealth
            // 
            this.lblWolfManHealth.BackColor = System.Drawing.Color.Red;
            this.lblWolfManHealth.Location = new System.Drawing.Point(701, 414);
            this.lblWolfManHealth.Name = "lblWolfManHealth";
            this.lblWolfManHealth.Size = new System.Drawing.Size(300, 23);
            this.lblWolfManHealth.TabIndex = 19;
            this.lblWolfManHealth.Visible = false;
            // 
            // pcbUserPicture
            // 
            this.pcbUserPicture.Image = global::SimpleWarGame.Properties.Resources.user;
            this.pcbUserPicture.Location = new System.Drawing.Point(112, 478);
            this.pcbUserPicture.Name = "pcbUserPicture";
            this.pcbUserPicture.Size = new System.Drawing.Size(297, 226);
            this.pcbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserPicture.TabIndex = 20;
            this.pcbUserPicture.TabStop = false;
            this.pcbUserPicture.Visible = false;
            // 
            // pcbWolfManPicture
            // 
            this.pcbWolfManPicture.Image = global::SimpleWarGame.Properties.Resources.wolfman;
            this.pcbWolfManPicture.Location = new System.Drawing.Point(705, 478);
            this.pcbWolfManPicture.Name = "pcbWolfManPicture";
            this.pcbWolfManPicture.Size = new System.Drawing.Size(297, 226);
            this.pcbWolfManPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWolfManPicture.TabIndex = 21;
            this.pcbWolfManPicture.TabStop = false;
            this.pcbWolfManPicture.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(484, 559);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(157, 52);
            this.btnAttack.TabIndex = 22;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // WarGameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 728);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.pcbWolfManPicture);
            this.Controls.Add(this.pcbUserPicture);
            this.Controls.Add(this.lblWolfManHealth);
            this.Controls.Add(this.lblUserHealth);
            this.Controls.Add(this.lblWolfManHealthCount);
            this.Controls.Add(this.lblWolfManName);
            this.Controls.Add(this.lblUserHealthCount);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WarGameGUI";
            this.Text = "WarGameGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfManPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserHealthCount;
        private System.Windows.Forms.Label lblWolfManHealthCount;
        private System.Windows.Forms.Label lblWolfManName;
        private System.Windows.Forms.Label lblUserHealth;
        private System.Windows.Forms.Label lblWolfManHealth;
        private System.Windows.Forms.PictureBox pcbUserPicture;
        private System.Windows.Forms.PictureBox pcbWolfManPicture;
        private System.Windows.Forms.Button btnAttack;
    }
}