using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COOPFOOD
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadThongTinHoaDon();
            load_cboMaHoaDon();
            load_cboMaKH();
            load_cboMANV();
            load_cboMaHang();
        }
        //Kết nối db
        //connect sql at school
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=QUANLYSTCOOPFOOD;Integrated Security=True");

        //connet sql at home
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=QUANLYSTCOOPFOOD;Integrated Security=True");

        SqlConnection con = new SqlConnection("Data Source=THONGJ4" + KiTu() + "SQLEXPRESS;Initial Catalog=QUANLYSTCOOPFOOD;Integrated Security=True");

        //----------------------------------------------------------------------------------------------------------------------------------------------

        //Load thông tin hóa đơn
        void LoadThongTinHoaDon()
        {
            try
            {
                con.Open();
                SqlCommand cmdHoaDon = new SqlCommand();
                cmdHoaDon.CommandText = "sp_LAYDSHD";
                cmdHoaDon.CommandType = CommandType.StoredProcedure;

                cmdHoaDon.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmdHoaDon);
                DataTable dtHoaDon = new DataTable();
                da.Fill(dtHoaDon);
                dgv_HD.DataSource = dtHoaDon;
                dgv_HD.Refresh();

            }
            catch (Exception e)
            {

                MessageBox.Show("Lỗi " + e, "Thông báo");
            }
            finally
            {
                con.Close();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            int count = 0;
            count = dgv_HD.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgv_HD.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txtMaHD.Text = "HD0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMaHD.Text = "HD" + (chuoi2 + 1).ToString();
            }
            if (KTThongTin() == true)
            {
                try
                {
                    con.Open();
                    SqlCommand cmdThemHD = new SqlCommand();
                    cmdThemHD.CommandText = "sp_THEMHD";
                    cmdThemHD.CommandType = CommandType.StoredProcedure;
                    cmdThemHD.Connection = con;

                    //mã hd
                    SqlParameter parMaHD = new SqlParameter("@MAHD", SqlDbType.NVarChar);
                    parMaHD.Value = txtMaHD.Text;
                    cmdThemHD.Parameters.Add(parMaHD);

                    //ngày lập
                    SqlParameter parNgayLap = new SqlParameter("@NGAYLAP", SqlDbType.Date);
                    parNgayLap.Value = dtpHoaDon.Text;
                    cmdThemHD.Parameters.Add(parNgayLap);
                    //phương thức thanh toán
                    SqlParameter parPTTT = new SqlParameter("@PTTHANHTOAN", SqlDbType.NVarChar);
                    parPTTT.Value = cboPTTT.Text;
                    cmdThemHD.Parameters.Add(parPTTT);
                    //mã nhân viên
                    SqlParameter parMaNV = new SqlParameter("@MANV", SqlDbType.NVarChar);
                    parMaNV.Value = cbo_NhanVien.Text;
                    cmdThemHD.Parameters.Add(parMaNV);
                    //mã khách hàng
                    SqlParameter parMaKH = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                    parMaKH.Value = cbo_KhachHang.Text;
                    cmdThemHD.Parameters.Add(parMaKH);
                    //tiền khách trả
                    SqlParameter parTienKHTra = new SqlParameter("@TIENKHACHTRA", SqlDbType.Int);
                    parTienKHTra.Value = txtTienKHTra.Text;
                    cmdThemHD.Parameters.Add(parTienKHTra);

                    if (cmdThemHD.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
                    }
                    dgv_HD.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
                finally
                {
                    con.Close();
                    Reset();
                    load_cboMaHoaDon();
                    load_cboMaHang();
                    LoadThongTinHoaDon();
                }
            }


        }
        public bool KTThongTin()
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return false;
            }
            if (cbo_NhanVien.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_NhanVien.Focus();
                return false;
            }
            if (cbo_KhachHang.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_KhachHang.Focus();
                return false;
            }
            if (cboPTTT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPTTT.Focus();
                return false;
            }
            return true;
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn muốn đóng cửa sổ quản lý hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static string KiTu()
        {
            char c = (char)92;
            string s = c.ToString();
            return s;
        }

        //load mã hóa đơn
        void load_cboMaHoaDon()
        {
            try
            {
                
                con.Open();
                cbo_MaHoaDon.Items.Clear();
                cbo_MaHoaDon.SelectedIndex = -1;
                string qry = "SELECT MAHD from HOADON ";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    
                    cbo_MaHoaDon.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi:  " + ex);
            }
        }
        //load mã khách hàng
        void load_cboMaKH()
        {
            try
            {
                con.Open();
                cbo_KhachHang.Items.Clear();
                cbo_KhachHang.SelectedIndex = -1;
                string qry = "SELECT MAKH from KHACHHANG";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    cbo_KhachHang.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi:  " + ex);
            }
        }
        //load mã nhân viên lập hóa đơn
        void load_cboMANV()
        {
            try
            {
                con.Open();
                cbo_NhanVien.Items.Clear();
                cbo_NhanVien.SelectedIndex = -1;
                string qry = "SELECT MANV from NHANVIEN";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    cbo_NhanVien.Items.Add(dr.GetValue(0).ToString());

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi:  " + ex);
            }
        }
        //load mã hàng hóa
        void load_cboMaHang()
        {
            try
            {
                con.Open();
                cbo_MaHang.Items.Clear();
                cbo_MaHang.SelectedIndex = -1;
                string qry = "SELECT MAHH from HANGHOA";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
                while (dr.Read())
                {
                    cbo_MaHang.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi:  " + ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần xóa", "Thông báo");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmdXoa = new SqlCommand();
                    cmdXoa.CommandText = "sp_XOAHD";
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    cmdXoa.Connection = con;
                    cmdXoa.Parameters.Add("@MAHD", SqlDbType.NVarChar).Value = txtMaHD.Text;
                    cmdXoa.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi " + ex);
                }
                finally
                {
                    con.Close();
                    Reset();
                    load_cboMaHoaDon();
                    load_cboMaHang();
                    LoadThongTinHoaDon();
                }
            }

        }

        private void dgv_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = new DataGridViewRow();
            row = dgv_HD.Rows[e.RowIndex];
            txtMaHD.Text = Convert.ToString(row.Cells["MAHD"].Value);
            dtpHoaDon.Text = Convert.ToString(row.Cells["NGAYLAP"].Value);
            cbo_KhachHang.Text = Convert.ToString(row.Cells["MAKH"].Value);
            txtTienKHTra.Text = Convert.ToString(row.Cells["TIENKHACHTRA"].Value);
            cbo_NhanVien.Text = Convert.ToString(row.Cells["MANV"].Value);
            cboPTTT.Text = Convert.ToString(row.Cells["PTTHANHTOAN"].Value);

        }

        void Reset()
        {
            txtMaHD.Text = "";
            cboPTTT.Text = null;
            cbo_KhachHang.Text = null;
            cbo_NhanVien.Text = null;
            dtpHoaDon.Text = "15/12/2022";
            txtTienKHTra.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần sửa", "Thông báo");
            }
            else
            {
                try
                {
                    if (KTThongTin())
                    {
                        con.Open();
                        SqlCommand cmdSua = new SqlCommand();
                        cmdSua.CommandText = "sp_SUAHD";
                        cmdSua.CommandType = CommandType.StoredProcedure;
                        cmdSua.Connection = con;

                        cmdSua.Parameters.Add("@MAHD", SqlDbType.NVarChar).Value = txtMaHD.Text;
                        cmdSua.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = dtpHoaDon.Text;
                        cmdSua.Parameters.Add("@PTTHANHTOAN", SqlDbType.NVarChar).Value = cboPTTT.Text;
                        cmdSua.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = cbo_NhanVien.Text;
                        cmdSua.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = cbo_KhachHang.Text;
                        cmdSua.Parameters.Add("@TIENKHACHTRA", SqlDbType.Int).Value = txtTienKHTra.Text;
                        cmdSua.ExecuteNonQuery();
                        MessageBox.Show("Sửa thông tin hóa đơn thành công", "Thông báo");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi: " + ex);
                }
                finally
                {
                    con.Close();
                    Reset();
                    load_cboMaHoaDon();
                    load_cboMaHang();
                    LoadThongTinHoaDon();
                }
            }
        }

        private void cbo_MaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as ComboBox).SelectedItem.ToString(), "Index");
            try
            {
                var t = (ComboBox)sender;
                con.Open();
                SqlCommand cmdHDCT = new SqlCommand();
                cmdHDCT.CommandText = "sp_LAYHDCT";
                cmdHDCT.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaHD = new SqlParameter("@MAHD", SqlDbType.NVarChar);
                parMaHD.Value = t.SelectedItem;
                cmdHDCT.Parameters.Add(parMaHD);

                cmdHDCT.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmdHDCT);
                DataTable dtHDCT = new DataTable();
                da.Fill(dtHDCT);
                dgv_HDCT.DataSource = dtHDCT;
                dgv_HDCT.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex, "Thông báo");
            }
            finally
            {
                con.Close();
            }

        }

        private void cbo_MaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [HANGHOA] WHERE MAHH = '" + cbo_MaHang.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        txt_TenHang.Text = dt.Rows[i]["TENHH"].ToString();
                        txt_DonGia.Text = dt.Rows[i]["DONGIA"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally
            {
                con.Close();
                txt_TenHang.Refresh();
                txt_DonGia.Refresh();
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
