namespace COOPFOOD
{
    partial class frmHoaDon
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTienKHTra = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.txtPTTT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvwHoaDon = new System.Windows.Forms.ListView();
            this.MAHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYLAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PTTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MANV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TIENKHACHTRA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TONGTIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TIENTHUA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpHoaDon = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn bán hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(439, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "*COOP-FOOD*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(109, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phương thức thanh toán:";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(225, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(0, 0);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tiền khách trả: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tổng tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tiền thừa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã nhân viên:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(216, 110);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(235, 22);
            this.txtMaHD.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(216, 226);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(235, 22);
            this.txtMaNV.TabIndex = 11;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(610, 104);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(235, 22);
            this.txtMaKH.TabIndex = 11;
            // 
            // txtTienKHTra
            // 
            this.txtTienKHTra.Location = new System.Drawing.Point(610, 166);
            this.txtTienKHTra.Name = "txtTienKHTra";
            this.txtTienKHTra.Size = new System.Drawing.Size(235, 22);
            this.txtTienKHTra.TabIndex = 11;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(610, 226);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(235, 22);
            this.txtTongTien.TabIndex = 11;
            // 
            // txtTienThua
            // 
            this.txtTienThua.Location = new System.Drawing.Point(610, 283);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(235, 22);
            this.txtTienThua.TabIndex = 11;
            // 
            // txtPTTT
            // 
            this.txtPTTT.Location = new System.Drawing.Point(112, 289);
            this.txtPTTT.Name = "txtPTTT";
            this.txtPTTT.Size = new System.Drawing.Size(235, 22);
            this.txtPTTT.TabIndex = 12;
            this.txtPTTT.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(151, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 45);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(356, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 45);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(542, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(735, 350);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 45);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lvwHoaDon
            // 
            this.lvwHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MAHD,
            this.NGAYLAP,
            this.PTTT,
            this.MANV,
            this.MAKH,
            this.TIENKHACHTRA,
            this.TONGTIEN,
            this.TIENTHUA});
            this.lvwHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwHoaDon.GridLines = true;
            this.lvwHoaDon.HideSelection = false;
            this.lvwHoaDon.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10});
            this.lvwHoaDon.Location = new System.Drawing.Point(0, 423);
            this.lvwHoaDon.Name = "lvwHoaDon";
            this.lvwHoaDon.Size = new System.Drawing.Size(1022, 175);
            this.lvwHoaDon.TabIndex = 17;
            this.lvwHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvwHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // MAHD
            // 
            this.MAHD.Text = "Mã hóa đơn";
            this.MAHD.Width = 98;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Text = "Ngày lập";
            this.NGAYLAP.Width = 137;
            // 
            // PTTT
            // 
            this.PTTT.Text = "PTTT";
            this.PTTT.Width = 111;
            // 
            // MANV
            // 
            this.MANV.Text = "Mã nhân viên";
            this.MANV.Width = 112;
            // 
            // MAKH
            // 
            this.MAKH.Text = "Mã khách hàng";
            this.MAKH.Width = 115;
            // 
            // TIENKHACHTRA
            // 
            this.TIENKHACHTRA.Text = "Tiền khách trả";
            this.TIENKHACHTRA.Width = 145;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.Text = "Tổng tiền";
            this.TONGTIEN.Width = 152;
            // 
            // TIENTHUA
            // 
            this.TIENTHUA.Text = "Tiền thừa";
            this.TIENTHUA.Width = 243;
            // 
            // dtpHoaDon
            // 
            this.dtpHoaDon.Location = new System.Drawing.Point(216, 169);
            this.dtpHoaDon.Name = "dtpHoaDon";
            this.dtpHoaDon.Size = new System.Drawing.Size(235, 22);
            this.dtpHoaDon.TabIndex = 18;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 598);
            this.Controls.Add(this.dtpHoaDon);
            this.Controls.Add(this.lvwHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtPTTT);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTienKHTra);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.Text = "Hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTienKHTra;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.TextBox txtPTTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvwHoaDon;
        private System.Windows.Forms.ColumnHeader MAHD;
        private System.Windows.Forms.ColumnHeader NGAYLAP;
        private System.Windows.Forms.ColumnHeader PTTT;
        private System.Windows.Forms.ColumnHeader MANV;
        private System.Windows.Forms.ColumnHeader MAKH;
        private System.Windows.Forms.ColumnHeader TIENKHACHTRA;
        private System.Windows.Forms.ColumnHeader TONGTIEN;
        private System.Windows.Forms.ColumnHeader TIENTHUA;
        private System.Windows.Forms.DateTimePicker dtpHoaDon;
    }
}