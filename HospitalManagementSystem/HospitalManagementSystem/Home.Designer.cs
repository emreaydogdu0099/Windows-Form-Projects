namespace HospitalManagementSystem
{
    partial class Home
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
            this.panelHizmetlerimiz = new System.Windows.Forms.Panel();
            this.btnLazer = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnTomografi = new System.Windows.Forms.Button();
            this.btnHizmetlerimiz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelUnitelerimiz = new System.Windows.Forms.Panel();
            this.btnDermatoloji = new System.Windows.Forms.Button();
            this.btnGastro = new System.Windows.Forms.Button();
            this.btnGoz = new System.Windows.Forms.Button();
            this.btnKardiyo = new System.Windows.Forms.Button();
            this.btnFizik = new System.Windows.Forms.Button();
            this.btnUnitelerimiz = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnKonsol = new System.Windows.Forms.Button();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHizmetlerimiz.SuspendLayout();
            this.panelUnitelerimiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHizmetlerimiz
            // 
            this.panelHizmetlerimiz.Controls.Add(this.btnLazer);
            this.panelHizmetlerimiz.Controls.Add(this.btnMR);
            this.panelHizmetlerimiz.Controls.Add(this.btnTomografi);
            this.panelHizmetlerimiz.Controls.Add(this.btnHizmetlerimiz);
            this.panelHizmetlerimiz.Location = new System.Drawing.Point(126, 390);
            this.panelHizmetlerimiz.MaximumSize = new System.Drawing.Size(234, 233);
            this.panelHizmetlerimiz.MinimumSize = new System.Drawing.Size(234, 59);
            this.panelHizmetlerimiz.Name = "panelHizmetlerimiz";
            this.panelHizmetlerimiz.Size = new System.Drawing.Size(234, 59);
            this.panelHizmetlerimiz.TabIndex = 0;
            // 
            // btnLazer
            // 
            this.btnLazer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLazer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLazer.Enabled = false;
            this.btnLazer.FlatAppearance.BorderSize = 0;
            this.btnLazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLazer.Location = new System.Drawing.Point(0, 174);
            this.btnLazer.Name = "btnLazer";
            this.btnLazer.Size = new System.Drawing.Size(234, 58);
            this.btnLazer.TabIndex = 4;
            this.btnLazer.Text = "Lazer";
            this.btnLazer.UseVisualStyleBackColor = false;
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMR.Enabled = false;
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMR.Location = new System.Drawing.Point(0, 116);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(234, 58);
            this.btnMR.TabIndex = 3;
            this.btnMR.Text = "Manyetik Rezonans";
            this.btnMR.UseVisualStyleBackColor = false;
            // 
            // btnTomografi
            // 
            this.btnTomografi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTomografi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTomografi.Enabled = false;
            this.btnTomografi.FlatAppearance.BorderSize = 0;
            this.btnTomografi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomografi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomografi.Location = new System.Drawing.Point(0, 58);
            this.btnTomografi.Name = "btnTomografi";
            this.btnTomografi.Size = new System.Drawing.Size(234, 58);
            this.btnTomografi.TabIndex = 2;
            this.btnTomografi.Text = "Bilgisayarlı Tomografi";
            this.btnTomografi.UseVisualStyleBackColor = false;
            // 
            // btnHizmetlerimiz
            // 
            this.btnHizmetlerimiz.BackColor = System.Drawing.Color.Lime;
            this.btnHizmetlerimiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHizmetlerimiz.FlatAppearance.BorderSize = 0;
            this.btnHizmetlerimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmetlerimiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHizmetlerimiz.Location = new System.Drawing.Point(0, 0);
            this.btnHizmetlerimiz.Name = "btnHizmetlerimiz";
            this.btnHizmetlerimiz.Size = new System.Drawing.Size(234, 58);
            this.btnHizmetlerimiz.TabIndex = 1;
            this.btnHizmetlerimiz.Text = "Hizmetlerimiz";
            this.btnHizmetlerimiz.UseVisualStyleBackColor = false;
            this.btnHizmetlerimiz.Click += new System.EventHandler(this.btnHizmetlerimiz_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelUnitelerimiz
            // 
            this.panelUnitelerimiz.Controls.Add(this.btnDermatoloji);
            this.panelUnitelerimiz.Controls.Add(this.btnGastro);
            this.panelUnitelerimiz.Controls.Add(this.btnGoz);
            this.panelUnitelerimiz.Controls.Add(this.btnKardiyo);
            this.panelUnitelerimiz.Controls.Add(this.btnFizik);
            this.panelUnitelerimiz.Controls.Add(this.btnUnitelerimiz);
            this.panelUnitelerimiz.Location = new System.Drawing.Point(423, 390);
            this.panelUnitelerimiz.MaximumSize = new System.Drawing.Size(234, 349);
            this.panelUnitelerimiz.MinimumSize = new System.Drawing.Size(234, 59);
            this.panelUnitelerimiz.Name = "panelUnitelerimiz";
            this.panelUnitelerimiz.Size = new System.Drawing.Size(234, 59);
            this.panelUnitelerimiz.TabIndex = 1;
            // 
            // btnDermatoloji
            // 
            this.btnDermatoloji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDermatoloji.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDermatoloji.Enabled = false;
            this.btnDermatoloji.FlatAppearance.BorderSize = 0;
            this.btnDermatoloji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDermatoloji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDermatoloji.Location = new System.Drawing.Point(0, 290);
            this.btnDermatoloji.Name = "btnDermatoloji";
            this.btnDermatoloji.Size = new System.Drawing.Size(234, 58);
            this.btnDermatoloji.TabIndex = 6;
            this.btnDermatoloji.Text = "Dermatoloji";
            this.btnDermatoloji.UseVisualStyleBackColor = false;
            // 
            // btnGastro
            // 
            this.btnGastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGastro.Enabled = false;
            this.btnGastro.FlatAppearance.BorderSize = 0;
            this.btnGastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGastro.Location = new System.Drawing.Point(0, 232);
            this.btnGastro.Name = "btnGastro";
            this.btnGastro.Size = new System.Drawing.Size(234, 58);
            this.btnGastro.TabIndex = 5;
            this.btnGastro.Text = "Gastroentroloji";
            this.btnGastro.UseVisualStyleBackColor = false;
            // 
            // btnGoz
            // 
            this.btnGoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGoz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoz.Enabled = false;
            this.btnGoz.FlatAppearance.BorderSize = 0;
            this.btnGoz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGoz.Location = new System.Drawing.Point(0, 174);
            this.btnGoz.Name = "btnGoz";
            this.btnGoz.Size = new System.Drawing.Size(234, 58);
            this.btnGoz.TabIndex = 4;
            this.btnGoz.Text = "Göz Hastalıkları";
            this.btnGoz.UseVisualStyleBackColor = false;
            // 
            // btnKardiyo
            // 
            this.btnKardiyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKardiyo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKardiyo.Enabled = false;
            this.btnKardiyo.FlatAppearance.BorderSize = 0;
            this.btnKardiyo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardiyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKardiyo.Location = new System.Drawing.Point(0, 116);
            this.btnKardiyo.Name = "btnKardiyo";
            this.btnKardiyo.Size = new System.Drawing.Size(234, 58);
            this.btnKardiyo.TabIndex = 3;
            this.btnKardiyo.Text = "Kardiyoloji";
            this.btnKardiyo.UseVisualStyleBackColor = false;
            // 
            // btnFizik
            // 
            this.btnFizik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFizik.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFizik.Enabled = false;
            this.btnFizik.FlatAppearance.BorderSize = 0;
            this.btnFizik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFizik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFizik.Location = new System.Drawing.Point(0, 58);
            this.btnFizik.Name = "btnFizik";
            this.btnFizik.Size = new System.Drawing.Size(234, 58);
            this.btnFizik.TabIndex = 2;
            this.btnFizik.Text = "Fizik Tedavi Ünitesi";
            this.btnFizik.UseVisualStyleBackColor = false;
            // 
            // btnUnitelerimiz
            // 
            this.btnUnitelerimiz.BackColor = System.Drawing.Color.Lime;
            this.btnUnitelerimiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnitelerimiz.FlatAppearance.BorderSize = 0;
            this.btnUnitelerimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitelerimiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnUnitelerimiz.Location = new System.Drawing.Point(0, 0);
            this.btnUnitelerimiz.Name = "btnUnitelerimiz";
            this.btnUnitelerimiz.Size = new System.Drawing.Size(234, 58);
            this.btnUnitelerimiz.TabIndex = 1;
            this.btnUnitelerimiz.Text = "Ünitelerimiz";
            this.btnUnitelerimiz.UseVisualStyleBackColor = false;
            this.btnUnitelerimiz.Click += new System.EventHandler(this.btnUnitelerimiz_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnKonsol
            // 
            this.btnKonsol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKonsol.FlatAppearance.BorderSize = 0;
            this.btnKonsol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonsol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnKonsol.Location = new System.Drawing.Point(712, 390);
            this.btnKonsol.Name = "btnKonsol";
            this.btnKonsol.Size = new System.Drawing.Size(234, 58);
            this.btnKonsol.TabIndex = 2;
            this.btnKonsol.Text = "Konsol";
            this.btnKonsol.UseVisualStyleBackColor = false;
            this.btnKonsol.Click += new System.EventHandler(this.btnKonsol_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(202, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTANEMİZE HOŞGELDİNİZ...";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1091, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKonsol);
            this.Controls.Add(this.panelUnitelerimiz);
            this.Controls.Add(this.panelHizmetlerimiz);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Yönetim Sistemi";
            this.panelHizmetlerimiz.ResumeLayout(false);
            this.panelUnitelerimiz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHizmetlerimiz;
        private System.Windows.Forms.Button btnLazer;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnTomografi;
        private System.Windows.Forms.Button btnHizmetlerimiz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelUnitelerimiz;
        private System.Windows.Forms.Button btnDermatoloji;
        private System.Windows.Forms.Button btnGastro;
        private System.Windows.Forms.Button btnGoz;
        private System.Windows.Forms.Button btnKardiyo;
        private System.Windows.Forms.Button btnFizik;
        private System.Windows.Forms.Button btnUnitelerimiz;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnKonsol;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label label1;
    }
}

