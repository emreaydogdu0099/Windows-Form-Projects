
namespace ProductManagementSystem
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cashRadio = new System.Windows.Forms.RadioButton();
            this.creditCartRadio = new System.Windows.Forms.RadioButton();
            this.previousBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(696, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sepet Bilgileri";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1114, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tutar";
            // 
            // totalLbl
            // 
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(1198, 566);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(66, 21);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "0";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(568, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ödeme Yöntemi";
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acceptBtn.BackgroundImage")));
            this.acceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.FlatAppearance.BorderSize = 0;
            this.acceptBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.ForeColor = System.Drawing.Color.Transparent;
            this.acceptBtn.Location = new System.Drawing.Point(833, 725);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(121, 116);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.cashRadio);
            this.groupBox1.Controls.Add(this.creditCartRadio);
            this.groupBox1.Location = new System.Drawing.Point(764, 652);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cashRadio
            // 
            this.cashRadio.AutoSize = true;
            this.cashRadio.Location = new System.Drawing.Point(166, 19);
            this.cashRadio.Name = "cashRadio";
            this.cashRadio.Size = new System.Drawing.Size(61, 21);
            this.cashRadio.TabIndex = 1;
            this.cashRadio.TabStop = true;
            this.cashRadio.Text = "Nakit";
            this.cashRadio.UseVisualStyleBackColor = true;
            // 
            // creditCartRadio
            // 
            this.creditCartRadio.AutoSize = true;
            this.creditCartRadio.Location = new System.Drawing.Point(25, 19);
            this.creditCartRadio.Name = "creditCartRadio";
            this.creditCartRadio.Size = new System.Drawing.Size(95, 21);
            this.creditCartRadio.TabIndex = 0;
            this.creditCartRadio.TabStop = true;
            this.creditCartRadio.Text = "Kredi Kartı";
            this.creditCartRadio.UseVisualStyleBackColor = true;
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.Color.Transparent;
            this.previousBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousBtn.BackgroundImage")));
            this.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn.FlatAppearance.BorderSize = 0;
            this.previousBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.previousBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn.Location = new System.Drawing.Point(1444, 22);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(64, 64);
            this.previousBtn.TabIndex = 8;
            this.previousBtn.UseVisualStyleBackColor = false;
            this.previousBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sepetten çıkarmak istediğiniz ürünün üzerine çift tıklayabilirsiniz.";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management System";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cashRadio;
        private System.Windows.Forms.RadioButton creditCartRadio;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Label label3;
    }
}