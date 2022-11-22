namespace GymManagement.GUI
{
    partial class frmThemHoiVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaHet = new System.Windows.Forms.Button();
            this.btnLuuThemMoi = new System.Windows.Forms.Button();
            this.cboSoNgayTap = new System.Windows.Forms.ComboBox();
            this.cboThemGoiTap = new System.Windows.Forms.ComboBox();
            this.cboThemGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNgayDKy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThemDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThemSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThemHoiVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaHet);
            this.groupBox1.Controls.Add(this.btnLuuThemMoi);
            this.groupBox1.Controls.Add(this.cboSoNgayTap);
            this.groupBox1.Controls.Add(this.cboThemGoiTap);
            this.groupBox1.Controls.Add(this.cboThemGioiTinh);
            this.groupBox1.Controls.Add(this.lblNgayDKy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgayHetHan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtThemDiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtThemSDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtThemHoiVien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm mới hội viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.Location = new System.Drawing.Point(260, 472);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHet.TabIndex = 8;
            this.btnXoaHet.Text = "Xóa hết";
            this.btnXoaHet.UseVisualStyleBackColor = true;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            // 
            // btnLuuThemMoi
            // 
            this.btnLuuThemMoi.Location = new System.Drawing.Point(168, 472);
            this.btnLuuThemMoi.Name = "btnLuuThemMoi";
            this.btnLuuThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLuuThemMoi.TabIndex = 7;
            this.btnLuuThemMoi.Text = "Lưu";
            this.btnLuuThemMoi.UseVisualStyleBackColor = true;
            this.btnLuuThemMoi.Click += new System.EventHandler(this.btnLuuThemMoi_Click);
            // 
            // cboSoNgayTap
            // 
            this.cboSoNgayTap.FormattingEnabled = true;
            this.cboSoNgayTap.Items.AddRange(new object[] {
            "30",
            ""});
            this.cboSoNgayTap.Location = new System.Drawing.Point(121, 347);
            this.cboSoNgayTap.Name = "cboSoNgayTap";
            this.cboSoNgayTap.Size = new System.Drawing.Size(121, 23);
            this.cboSoNgayTap.TabIndex = 5;
            // 
            // cboThemGoiTap
            // 
            this.cboThemGoiTap.FormattingEnabled = true;
            this.cboThemGoiTap.Items.AddRange(new object[] {
            "VIP",
            "Thường"});
            this.cboThemGoiTap.Location = new System.Drawing.Point(121, 318);
            this.cboThemGoiTap.Name = "cboThemGoiTap";
            this.cboThemGoiTap.Size = new System.Drawing.Size(121, 23);
            this.cboThemGoiTap.TabIndex = 4;
            // 
            // cboThemGioiTinh
            // 
            this.cboThemGioiTinh.FormattingEnabled = true;
            this.cboThemGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboThemGioiTinh.Location = new System.Drawing.Point(121, 289);
            this.cboThemGioiTinh.Name = "cboThemGioiTinh";
            this.cboThemGioiTinh.Size = new System.Drawing.Size(121, 23);
            this.cboThemGioiTinh.TabIndex = 3;
            // 
            // lblNgayDKy
            // 
            this.lblNgayDKy.AutoSize = true;
            this.lblNgayDKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayDKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNgayDKy.Location = new System.Drawing.Point(121, 383);
            this.lblNgayDKy.Name = "lblNgayDKy";
            this.lblNgayDKy.Size = new System.Drawing.Size(56, 21);
            this.lblNgayDKy.TabIndex = 1;
            this.lblNgayDKy.Text = "Today";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số ngày tập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày đăng ký:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gói tập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính:";
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayHetHan.Location = new System.Drawing.Point(121, 421);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(214, 23);
            this.txtNgayHetHan.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày hết hạn:";
            // 
            // txtThemDiaChi
            // 
            this.txtThemDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThemDiaChi.Location = new System.Drawing.Point(121, 260);
            this.txtThemDiaChi.Name = "txtThemDiaChi";
            this.txtThemDiaChi.Size = new System.Drawing.Size(214, 23);
            this.txtThemDiaChi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ:";
            // 
            // txtThemSDT
            // 
            this.txtThemSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThemSDT.Location = new System.Drawing.Point(121, 231);
            this.txtThemSDT.Name = "txtThemSDT";
            this.txtThemSDT.Size = new System.Drawing.Size(214, 23);
            this.txtThemSDT.TabIndex = 1;
            this.txtThemSDT.TextChanged += new System.EventHandler(this.txtThemSDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT:";
            // 
            // txtThemHoiVien
            // 
            this.txtThemHoiVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThemHoiVien.Location = new System.Drawing.Point(121, 202);
            this.txtThemHoiVien.Name = "txtThemHoiVien";
            this.txtThemHoiVien.Size = new System.Drawing.Size(214, 23);
            this.txtThemHoiVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GymManagement.Properties.Resources.img4;
            this.pictureBox1.Location = new System.Drawing.Point(82, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmThemHoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 525);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemHoiVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hội viên";
            this.Load += new System.EventHandler(this.frmThemHoiVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboThemGioiTinh;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtThemSDT;
        private Label label2;
        private TextBox txtThemHoiVien;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cboThemGoiTap;
        private Label lblNgayDKy;
        private Button btnXoaHet;
        private Button btnLuuThemMoi;
        private TextBox txtThemDiaChi;
        private Label label6;
        private ComboBox cboSoNgayTap;
        private Label label7;
        private TextBox txtNgayHetHan;
        private Label label8;
        private ErrorProvider errorProvider1;
    }
}