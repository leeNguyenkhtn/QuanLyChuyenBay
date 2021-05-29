
namespace QuanLyBanVeMayBay
{
    partial class Sell
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bexit = new System.Windows.Forms.Button();
            this.Bchange = new System.Windows.Forms.Button();
            this.Btotal = new System.Windows.Forms.Button();
            this.Bsell = new System.Windows.Forms.Button();
            this.Bbook = new System.Windows.Forms.Button();
            this.Bsearch = new System.Windows.Forms.Button();
            this.Binput = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.P = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Bexit);
            this.panel1.Controls.Add(this.Bchange);
            this.panel1.Controls.Add(this.Btotal);
            this.panel1.Controls.Add(this.Bsell);
            this.panel1.Controls.Add(this.Bbook);
            this.panel1.Controls.Add(this.Bsearch);
            this.panel1.Controls.Add(this.Binput);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 624);
            this.panel1.TabIndex = 0;
            // 
            // Bexit
            // 
            this.Bexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bexit.Location = new System.Drawing.Point(17, 446);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(315, 37);
            this.Bexit.TabIndex = 6;
            this.Bexit.Text = "THOÁT";
            this.Bexit.UseVisualStyleBackColor = false;
            this.Bexit.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // Bchange
            // 
            this.Bchange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bchange.Location = new System.Drawing.Point(17, 373);
            this.Bchange.Name = "Bchange";
            this.Bchange.Size = new System.Drawing.Size(315, 37);
            this.Bchange.TabIndex = 5;
            this.Bchange.Text = "THAY ĐỔI QUY ĐỊNH";
            this.Bchange.UseVisualStyleBackColor = false;
            this.Bchange.Click += new System.EventHandler(this.Bchange_Click);
            // 
            // Btotal
            // 
            this.Btotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btotal.Location = new System.Drawing.Point(17, 298);
            this.Btotal.Name = "Btotal";
            this.Btotal.Size = new System.Drawing.Size(315, 41);
            this.Btotal.TabIndex = 4;
            this.Btotal.Text = "LẬP BÁO CÁO THÁNG";
            this.Btotal.UseVisualStyleBackColor = false;
            this.Btotal.Click += new System.EventHandler(this.Btotal_Click);
            // 
            // Bsell
            // 
            this.Bsell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bsell.Location = new System.Drawing.Point(17, 224);
            this.Bsell.Name = "Bsell";
            this.Bsell.Size = new System.Drawing.Size(315, 40);
            this.Bsell.TabIndex = 3;
            this.Bsell.Text = "BÁN VÉ";
            this.Bsell.UseVisualStyleBackColor = false;
            this.Bsell.Click += new System.EventHandler(this.Bsell_Click);
            // 
            // Bbook
            // 
            this.Bbook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bbook.Location = new System.Drawing.Point(17, 155);
            this.Bbook.Name = "Bbook";
            this.Bbook.Size = new System.Drawing.Size(315, 35);
            this.Bbook.TabIndex = 2;
            this.Bbook.Text = "ĐẶT VÉ";
            this.Bbook.UseVisualStyleBackColor = false;
            this.Bbook.Click += new System.EventHandler(this.Bbook_Click);
            // 
            // Bsearch
            // 
            this.Bsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bsearch.Location = new System.Drawing.Point(17, 79);
            this.Bsearch.Name = "Bsearch";
            this.Bsearch.Size = new System.Drawing.Size(315, 39);
            this.Bsearch.TabIndex = 1;
            this.Bsearch.Text = "TRA CỨU CHUYẾN BAY";
            this.Bsearch.UseVisualStyleBackColor = false;
            this.Bsearch.Click += new System.EventHandler(this.Bsearch_Click);
            // 
            // Binput
            // 
            this.Binput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Binput.Location = new System.Drawing.Point(17, 12);
            this.Binput.Name = "Binput";
            this.Binput.Size = new System.Drawing.Size(315, 38);
            this.Binput.TabIndex = 0;
            this.Binput.Text = "NHẬP LỊCH CHUYẾN BAY";
            this.Binput.UseVisualStyleBackColor = false;
            this.Binput.Click += new System.EventHandler(this.Binput_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.P);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.S);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(370, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 624);
            this.panel2.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(959, 124);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 500);
            this.vScrollBar1.TabIndex = 19;
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(421, 64);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(94, 34);
            this.P.TabIndex = 12;
            this.P.Text = "IN";
            this.P.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(985, 500);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(244, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 34);
            this.textBox1.TabIndex = 10;
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(421, 12);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(94, 34);
            this.S.TabIndex = 9;
            this.S.Text = "TÌM";
            this.S.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 12);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 34);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 25, 23, 59, 59, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "NGÀY KHỞI HÀNH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ VÉ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ BÁN VÉ CHUYẾN BAY";
            this.Load += new System.EventHandler(this.Sell_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bchange;
        private System.Windows.Forms.Button Btotal;
        private System.Windows.Forms.Button Bsell;
        private System.Windows.Forms.Button Bbook;
        private System.Windows.Forms.Button Bsearch;
        private System.Windows.Forms.Button Binput;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

