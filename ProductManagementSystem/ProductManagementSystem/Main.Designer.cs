
namespace ProductManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drinksPictureBox = new System.Windows.Forms.Button();
            this.vegetablesPictureBox = new System.Windows.Forms.Button();
            this.fruitsPictureBox = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.goCartBtn = new System.Windows.Forms.Button();
            this.countInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.drinksPictureBox);
            this.groupBox1.Controls.Add(this.vegetablesPictureBox);
            this.groupBox1.Controls.Add(this.fruitsPictureBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(71, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 632);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // drinksPictureBox
            // 
            this.drinksPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drinksPictureBox.BackgroundImage")));
            this.drinksPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drinksPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drinksPictureBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.drinksPictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinksPictureBox.Location = new System.Drawing.Point(26, 446);
            this.drinksPictureBox.Name = "drinksPictureBox";
            this.drinksPictureBox.Size = new System.Drawing.Size(270, 150);
            this.drinksPictureBox.TabIndex = 2;
            this.drinksPictureBox.UseVisualStyleBackColor = true;
            this.drinksPictureBox.Click += new System.EventHandler(this.button3_Click);
            // 
            // vegetablesPictureBox
            // 
            this.vegetablesPictureBox.BackgroundImage = global::ProductManagementSystem.Properties.Resources.vegetables;
            this.vegetablesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vegetablesPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vegetablesPictureBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.vegetablesPictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegetablesPictureBox.Location = new System.Drawing.Point(26, 261);
            this.vegetablesPictureBox.Name = "vegetablesPictureBox";
            this.vegetablesPictureBox.Size = new System.Drawing.Size(270, 150);
            this.vegetablesPictureBox.TabIndex = 1;
            this.vegetablesPictureBox.UseVisualStyleBackColor = true;
            this.vegetablesPictureBox.Click += new System.EventHandler(this.button2_Click);
            // 
            // fruitsPictureBox
            // 
            this.fruitsPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fruitsPictureBox.BackgroundImage")));
            this.fruitsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fruitsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fruitsPictureBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.fruitsPictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fruitsPictureBox.Location = new System.Drawing.Point(26, 61);
            this.fruitsPictureBox.Name = "fruitsPictureBox";
            this.fruitsPictureBox.Size = new System.Drawing.Size(270, 150);
            this.fruitsPictureBox.TabIndex = 0;
            this.fruitsPictureBox.UseVisualStyleBackColor = true;
            this.fruitsPictureBox.Click += new System.EventHandler(this.fruitBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(466, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 632);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // countLbl
            // 
            this.countLbl.BackColor = System.Drawing.Color.White;
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.Location = new System.Drawing.Point(869, 690);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(96, 22);
            this.countLbl.TabIndex = 9;
            this.countLbl.Text = "Adet/Kilo";
            this.countLbl.Visible = false;
            // 
            // goCartBtn
            // 
            this.goCartBtn.BackColor = System.Drawing.Color.Transparent;
            this.goCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goCartBtn.FlatAppearance.BorderSize = 0;
            this.goCartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.goCartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.goCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goCartBtn.ForeColor = System.Drawing.Color.Transparent;
            this.goCartBtn.Image = ((System.Drawing.Image)(resources.GetObject("goCartBtn.Image")));
            this.goCartBtn.Location = new System.Drawing.Point(1408, 740);
            this.goCartBtn.Name = "goCartBtn";
            this.goCartBtn.Size = new System.Drawing.Size(106, 87);
            this.goCartBtn.TabIndex = 2;
            this.goCartBtn.UseVisualStyleBackColor = false;
            this.goCartBtn.Click += new System.EventHandler(this.button13_Click);
            // 
            // countInput
            // 
            this.countInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countInput.Location = new System.Drawing.Point(989, 688);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(122, 27);
            this.countInput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lütfen satın almak istediğiniz ürünün adetini/kilosunu yazdıktan sonra ürün resmi" +
    "ne tıklayınız.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countInput);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.goCartBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drinksPictureBox;
        private System.Windows.Forms.Button vegetablesPictureBox;
        private System.Windows.Forms.Button fruitsPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button goCartBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.NumericUpDown countInput;
        private System.Windows.Forms.Label label1;
    }
}