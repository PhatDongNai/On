using OnTap1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OnTap1
{
    public partial class Form1 : Form
    {
        QLPetsEntities db = new QLPetsEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txt_MaDon.Clear();
            txt_Ten.Clear();
            txt_ChungLoai.Clear();
            txt_CanNang.Clear();
            dtp_NgayNhan.Value = DateTime.Today;
            txt_TinhTrang.Clear();
            rad_ChuaBenh.Checked = true;
            txt_CPT_NCS.Clear();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát","Xác nhận thoát",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp_NgayNhan.Value = DateTime.Today;
            rad_ChuaBenh.Checked = true;

            foreach(var i in db.Pets.ToList())
            {
                ListViewItem item = new ListViewItem(i.MaDon);
                //item.SubItems.Add(i.MaDon);
                item.SubItems.Add(i.TenThuCung);
                item.SubItems.Add(i.ChungLoai);
                item.SubItems.Add(i.NgayNhan.Value.ToString("dd/MM/yyyy"));

                if (i.CanNang > 40)
                {
                    item.BackColor = Color.Yellow; item.ForeColor = Color.Green;
                }

                lv_DanhSachThuCung.Items.Add(item);
            }
        }

        private void rad_ChuaBenh_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_ChuaBenh.Checked)
            {
                lbl_CPT_NCS.Text = "Chi phí thuốc";
            }
        }

        private void rad_ChamSocHo_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_ChamSocHo.Checked)
            {
                lbl_CPT_NCS.Text = "Số ngày";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Reset();
            txt_MaDon.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txt_MaDon.Text == string.Empty || txt_Ten.Text == string.Empty || txt_CanNang.Text == string.Empty || txt_ChungLoai.Text == string.Empty || txt_TinhTrang.Text == string.Empty)
            {
                MessageBox.Show("Mã đơn, tên thú cưng, chủng loại, cân nặng, tình trạng không được để trống", "Xác nhận",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if(dtp_NgayNhan.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày nhận không được bé hơn ngày hiện tại", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Pet data = new Pet();
            data.MaDon = txt_MaDon.Text;
            data.TenThuCung = txt_Ten.Text;
            data.ChungLoai = txt_ChungLoai.Text;
            data.CanNang = int.Parse(txt_CanNang.Text);
            data.NgayNhan = dtp_NgayNhan.Value;
            data.TinhTrang = txt_TinhTrang.Text;
            data.LoaiHinhDichVu = (rad_ChuaBenh.Checked ? "Chữa bệnh" : "Chăm sóc hộ");
            if(rad_ChuaBenh.Checked )
            {
                data.PhiDieuTri = float.Parse(txt_CPT_NCS.Text);
                data.DoanhThu = 100000 + data.PhiDieuTri;
            }
            if(rad_ChamSocHo.Checked)
            {
                data.SoNgay = int.Parse(txt_CPT_NCS.Text);
                data.DoanhThu = 200000 * data.SoNgay;
            }
            try
            {
                db.Pets.Add(data);
                db.SaveChanges();
                MessageBox.Show("Lưu dữ liệu xuống database thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Lấy dòng data vừa lưu bỏ lên listview
                string[] datarow = { data.MaDon, data.TenThuCung, data.ChungLoai, data.NgayNhan.Value.ToString("dd/MM/yyyy") };
                ListViewItem row = new ListViewItem(datarow);
                row.ImageIndex = 0;

                if(data.CanNang > 40)
                {
                    row.BackColor = Color.Yellow; row.ForeColor = Color.Green;
                }
                lv_DanhSachThuCung.Items.Add(row);
                row.Selected = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể lưu dữ liệu xuống database" + ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lv_DanhSachThuCung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_DanhSachThuCung.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_DanhSachThuCung.SelectedItems[0];
                string maDon = selectedItem.SubItems[0].Text;
                Pet selectedPet = db.Pets.FirstOrDefault(p => p.MaDon == maDon);

                if(selectedPet != null)
                {
                    txt_MaDon.Text = selectedPet.MaDon;
                    txt_Ten.Text = selectedPet.TenThuCung;
                    txt_ChungLoai.Text = selectedPet.ChungLoai;
                    txt_CanNang.Text = selectedPet.CanNang.ToString();
                    dtp_NgayNhan.Value = selectedPet.NgayNhan.Value;
                    txt_TinhTrang.Text = selectedPet.TinhTrang;
                    if (selectedPet.LoaiHinhDichVu == "Chữa bệnh")
                    {
                        rad_ChuaBenh.Checked = true;
                        txt_CPT_NCS.Text = selectedPet.PhiDieuTri.ToString();
                    }else if (selectedPet.LoaiHinhDichVu == "Chăm sóc hộ")
                    {
                        rad_ChamSocHo.Checked = true;
                        txt_CPT_NCS.Text = selectedPet.SoNgay.ToString();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(lv_DanhSachThuCung.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_DanhSachThuCung.SelectedItems[0];

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá thú cưng này","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    int indextoRemove = selectedItem.Index;

                    string maDon = selectedItem.SubItems[0].Text;
                    Pet selectedPet = db.Pets.FirstOrDefault(p => p.MaDon == maDon);
                    if(selectedPet != null)
                    {
                        MessageBox.Show("Xoá thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Pets.Remove(selectedPet);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    selectedItem.Remove();

                    if(indextoRemove < lv_DanhSachThuCung.Items.Count)
                    {
                        lv_DanhSachThuCung.Items[indextoRemove].Selected = true;
                        lv_DanhSachThuCung.Items[indextoRemove].Focused = true;
                    }else if(lv_DanhSachThuCung.Items.Count > 0)
                    {
                        lv_DanhSachThuCung.Items[lv_DanhSachThuCung.Items.Count - 1].Selected = true;
                        lv_DanhSachThuCung.Items[lv_DanhSachThuCung.Items.Count - 1].Focused = true;
                    }
                    else
                    {
                        Reset();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(lv_DanhSachThuCung.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_DanhSachThuCung.SelectedItems[0];
                string maDon = selectedItem.SubItems[0].Text;

                Pet updatePet = db.Pets.FirstOrDefault(p => p.MaDon == maDon);
                if(updatePet != null)
                {
                    // Lưu trạng thái ban đầu của MaDon
                    string originalMaDon = updatePet.MaDon;

                    // Cập nhật thông tin từ các điều khiển nhập liệu vào đối tượng Pet
                    updatePet.MaDon = txt_MaDon.Text; // Cập nhật cả khi MaDon thay đổi

                    // Kiểm tra nếu MaDon đã thay đổi
                    if (originalMaDon != updatePet.MaDon)
                    {
                        MessageBox.Show("Không thể chỉnh sửa Mã đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        updatePet.MaDon = originalMaDon;
                        return; // Dừng quá trình cập nhật
                    }
                    updatePet.TenThuCung = txt_Ten.Text;
                    updatePet.ChungLoai = txt_ChungLoai.Text;
                    updatePet.CanNang = int.Parse(txt_CanNang.Text);
                    updatePet.NgayNhan = dtp_NgayNhan.Value;
                    updatePet.TinhTrang = txt_TinhTrang.Text;
                    if (rad_ChuaBenh.Checked)
                    {
                        updatePet.LoaiHinhDichVu = "Chữa bệnh";
                        updatePet.PhiDieuTri = float.Parse(txt_CPT_NCS.Text);
                        updatePet.DoanhThu = 100000 + updatePet.PhiDieuTri;
                    }else if (rad_ChamSocHo.Checked)
                    {
                        updatePet.LoaiHinhDichVu = "Chăm sóc hộ";
                        updatePet.SoNgay = int.Parse(txt_CPT_NCS.Text);
                        updatePet.DoanhThu = 200000 * updatePet.SoNgay;
                    }
                    db.SaveChanges();

                    //selectedItem.SubItems[0].Text = updatePet.MaDon;
                    selectedItem.SubItems[1].Text = updatePet.TenThuCung;
                    selectedItem.SubItems[2].Text = updatePet.ChungLoai;
                    selectedItem.SubItems[3].Text = updatePet.NgayNhan.Value.ToString("dd/MM/yyyy");

                    MessageBox.Show("Cập nhật thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thú cưng để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_SapXep_Click(object sender, EventArgs e)
        {
            var data = db.Pets.Select(p => new { MaDon = p.MaDon, TenThuCung = p.TenThuCung, ChungLoai = p.ChungLoai, NgayNhan = p.NgayNhan }).ToList();
            //Gán nguồn dữ liệu cho CrystalReport
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(data);
            //Hiển thị báo cáo 
            FormShowReport fRpt = new FormShowReport();
            fRpt.crystalReportViewer1.ReportSource = rpt;
            fRpt.ShowDialog();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWB = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet excelWS = excelApp.Worksheets[1];

            Excel.Range excelRange = excelWS.Cells[1, 1];
            excelRange.Font.Size = 16;
            excelRange.Font.Bold = true;
            excelRange.Font.Color = Color.Blue;
            excelRange.Value = "DANH MỤC SẢN PHẨM";
            // LẤY SP THEO DANH MỤC
            var catalogs = db.Pets.Select(c => new { Code = c.MaDon, Name = c.TenThuCung }).ToList();
            int row = 2;
            foreach (var c in catalogs)
            {
                excelWS.Range["A" + row].Font.Bold = true;
                excelWS.Range["A" + row].Value = c.Name;
                row++;
                //Lấy sản phẩm theo danh mục 
                var products = from p in db.Pets where p.MaDon == c.Code select p;
                foreach (var p in products)
                {
                    excelWS.Range["A" + row].Value = p.MaDon;
                    excelWS.Range["B" + row].ColumnWidth = 50;
                    excelWS.Range["B" + row].Value = p.TenThuCung;
                    excelWS.Range["C" + row].Value = p.NgayNhan;
                    row++;
                }
            }
            excelWS.Name = "DanhMucSanPham";
            excelWB.Activate();
            //Lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                excelWB.SaveAs(saveFileDialog.FileName);
            excelApp.Quit();
        }
    }
}


//public partial class Form1 : Form
//{
//    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VJC0N49I;Initial Catalog=QLNhanVien;Integrated Security=True");
//    SqlCommand cmd;

//    string gioiTinh = "";
//    string loaiNV = "";

//    public Form1()
//    {
//        InitializeComponent();

//    }

//    private void loadData()
//    {
//        lv_DSNV.Items.Clear();

//        cmd = new SqlCommand("select * from NhanVien", conn);
//        SqlDataReader da;
//        da = cmd.ExecuteReader();
//        while (da.Read())
//        {
//            var item = lv_DSNV.Items.Add(da[0].ToString());
//            item.SubItems.Add(da[1].ToString());
//            item.SubItems.Add(da[2].ToString());
//            item.SubItems.Add(da[3].ToString());
//            var datef = DateTime.Parse(da[4].ToString());
//            item.SubItems.Add(datef.ToString("MM/dd/yyyy"));
//            item.SubItems.Add(da[5].ToString());
//            item.SubItems.Add(da[6].ToString());
//        }

//        da.Close();
//    }

//    private void Form1_Load(object sender, EventArgs e)
//    {
//        conn.Open();
//        loadData();
//        rad_Nam.Checked = true;
//        rad_BanHang.Checked = true;

//    }

//    private void rad_BanHang_CheckedChanged(object sender, EventArgs e)
//    {
//        lbl_doanhso.Visible = true;
//        txt_doanhso.Visible = true;

//        lbl_PCNhienLieu.Visible = false;
//        txt_PCNhienLieu.Visible = false;

//        loaiNV = rad_BanHang.Text;
//    }

//    private void rad_GiaoNhan_CheckedChanged(object sender, EventArgs e)
//    {
//        lbl_doanhso.Visible = false;
//        txt_doanhso.Visible = false;

//        lbl_PCNhienLieu.Visible = true;
//        txt_PCNhienLieu.Visible = true;

//        loaiNV = rad_GiaoNhan.Text;
//    }
//    private void rad_Nam_CheckedChanged(object sender, EventArgs e)
//    {
//        gioiTinh = rad_Nam.Text;
//    }

//    private void rad_Nu_CheckedChanged(object sender, EventArgs e)
//    {
//        gioiTinh = rad_Nu.Text;
//    }

//    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//    {
//    }

//    void clear()
//    {
//        txt_MaNV.Text = "";
//        txt_HoTen.Text = "";
//        txt_DienThoai.Text = "";
//        date_NgayVaoLam.Text = "";
//        txt_doanhso.Text = "";
//        txt_PCNhienLieu.Text = "";
//    }

//    private void btn_Them_Click(object sender, EventArgs e)
//    {
//        clear();
//        txt_MaNV.ReadOnly = false;
//    }

//    private void btn_Luu_Click(object sender, EventArgs e)
//    {
//        cmd = new SqlCommand("insert into NhanVien values('" + txt_MaNV.Text + "','" + txt_HoTen.Text + "', '" + gioiTinh + "', '" + txt_DienThoai.Text + "', '" + date_NgayVaoLam.Value + "', '" + txt_doanhso.Text + "', '" + txt_PCNhienLieu.Text + "')", conn);
//        cmd.ExecuteNonQuery();
//        loadData();
//    }

//    private void btn_Xoa_Click(object sender, EventArgs e)
//    {
//        if (MessageBox.Show("Xac Nhan Xoa", "Xoa Du Lieu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
//        {
//            conn.Close();
//            conn.Open();
//            cmd = new SqlCommand("delete from NhanVien where MaNV = '" + txt_MaNV.Text + "'", conn);
//            cmd.ExecuteNonQuery();
//            loadData();
//        }
//    }

//    private void btn_Sua_Click(object sender, EventArgs e)
//    {
//        conn.Close();
//        conn.Open();
//        cmd = new SqlCommand("update NhanVien set HoTen = '" + txt_HoTen.Text + "', GioiTinh = '" + gioiTinh + "', DienThoai = '" + txt_DienThoai.Text + "', NgayVaoLam = '" + date_NgayVaoLam.Value + "', DoanhSo = '" + txt_doanhso.Text + "', PhuCapNhienLieu = '" + txt_PCNhienLieu.Text + "' where MaNV = '" + txt_MaNV.Text + "'", conn);
//        cmd.ExecuteNonQuery();
//        loadData();
//    }

//    private void btn_SapXep_Click(object sender, EventArgs e)
//    {
//        lv_DSNV.Sort();
//    }

//    private void btn_ThongKe_Click(object sender, EventArgs e)
//    {
//        StringBuilder thongtin = new StringBuilder();
//        string soluongnhanvien = lv_DSNV.Items.Count.ToString();
//        thongtin.AppendLine(soluongnhanvien);
//        thongtin.AppendLine(soluongnhanvien);
//        thongtin.AppendLine("e");
//        MessageBox.Show(thongtin.ToString(), "Thong Ke", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }

//    private void lv_DSNV_SelectedIndexChanged(object sender, EventArgs e)
//    {
//        if (lv_DSNV.SelectedItems.Count > 0)
//        {
//            txt_MaNV.Text = lv_DSNV.SelectedItems[0].Text.ToString();
//            txt_HoTen.Text = lv_DSNV.SelectedItems[0].SubItems[1].Text.ToString();
//            if (lv_DSNV.SelectedItems[0].SubItems[2].Text.ToString() == "Nam")
//            {
//                rad_Nam.Checked = true;
//                rad_Nu.Checked = false;
//            }
//            else
//            {
//                rad_Nam.Checked = false;
//                rad_Nu.Checked = true;
//            }
//            txt_DienThoai.Text = lv_DSNV.SelectedItems[0].SubItems[3].Text.ToString();
//            date_NgayVaoLam.Text = lv_DSNV.SelectedItems[0].SubItems[4].Text.ToString();
//            txt_doanhso.Text = lv_DSNV.SelectedItems[0].SubItems[5].Text.ToString();
//            txt_PCNhienLieu.Text = lv_DSNV.SelectedItems[0].SubItems[6].Text.ToString();
//        }
//    }

//    private void btn_Excel_Click(object sender, EventArgs e)
//    {
//        Excel.Application excelApp = new Excel.Application();
//        Excel.Workbook excelWb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
//        Excel.Worksheet excelWs = excelWb.Worksheets[1];

//        Excel.Range excelRange = excelWs.Cells[1, 1];
//        excelRange.Font.Size = 16;
//        excelRange.Font.Bold = true;
//        excelRange.Font.Color = Color.Blue;
//        excelRange.Value = "DANH MUC SAN PHAM";

//        var catalogs = db.Catalogs.Select(c => new
//        {
//            Code
//        })
//        }
//}


//public partial class Form1 : Form
//{
//    public Form1()
//    {
//        InitializeComponent();
//    }

//    li_Product2Entities db = new li_Product2Entities();
//    private void btn_xem_Click(object sender, EventArgs e)
//    {
//        //dgvSP.DataSource = db.Products.ToList();
//        dgvSP.DataSource = db.Products.Select(p => p).ToList();
//        //dgvSP.DataSource = db.Products.Select(p => new {Code = p.ProductCode, Name = p.ProductName, Price = p.ProdutPrice, CatName = p.Catalog.CatalogName }).ToList();
//        //var productList = from p in db.Products select new { pCode = p.ProductCode, pName = p.ProductName, pPrice = p.ProdutPrice };
//        //dgvSP.DataSource = productList.ToList();
//    }

//    private void btn_them_Click(object sender, EventArgs e)
//    {
//        Product p = new Product();
//        p.ProductName = "USB";
//        p.ProdutPrice = 120000;
//        p.CatalogCode = 2;
//        db.Products.Add(p);
//        db.SaveChanges();
//        btn_xem_Click(sender, e);
//    }

//    private void btn_xoa_Click(object sender, EventArgs e)
//    {
//        int pCode = Convert.ToInt32(dgvSP.Rows[dgvSP.CurrentRow.Index].Cells["ProductCode"].Value.ToString());
//        Product selectedProduct = db.Products.Where(p => p.ProductCode == pCode).SingleOrDefault();
//        db.Products.Remove(selectedProduct);
//        db.SaveChanges();
//        btn_xem_Click(sender, e);
//    }

//    private void btn_sua_Click(object sender, EventArgs e)
//    {
//        DataGridViewRow selectedRow = dgvSP.Rows[dgvSP.CurrentRow.Index];
//        int code = Convert.ToInt32(selectedRow.Cells["ProductCode"].Value.ToString());

//        Product selectedProduct = db.Products.Where(p => p.ProductCode == code).SingleOrDefault();

//        selectedProduct.ProductName = selectedRow.Cells["ProductName"].Value.ToString();
//        selectedProduct.ProdutPrice = float.Parse(selectedRow.Cells["ProdutPrice"].Value.ToString());
//        db.SaveChanges();
//        btn_xem_Click(sender, e);
//    }

//    private void btn_xuat_Click(object sender, EventArgs e)
//    {

//    }

//    private void btn_excel_Click(object sender, EventArgs e)
//    {
//        Excel.Application excelApp = new Excel.Application();
//        Excel.Workbook excelWb = excelApp.Workbooks.Add
//            (Excel.XlWBATemplate.xlWBATWorksheet);
//        Excel.Worksheet excelWs = excelWb.Worksheets[1];

//        Excel.Range excelRange = excelWs.Cells[1, 1];
//        excelRange.Font.Size = 16;
//        excelRange.Font.Bold = true;
//        excelRange.Font.Color = Color.Blue;
//        excelRange.Value = "DANH MỤC SẢN PHẨM";

//        //LẤY DANH MỤC

//        var catalogs = db.Catalogs.Select(c => new { Code = c.CatalogCode, Name = c.CatalogName }).ToList();
//        int row = 2;
//        foreach (var c in catalogs)
//        {
//            excelWs.Range["A" + row].Font.Bold = true;
//            excelWs.Range["A" + row].Value = c.Name;
//            row++;
//            var products = from p in db.Products where p.CatalogCode == c.Code select p;
//            foreach (var p in products)
//            {
//                excelWs.Range["A" + row].Value = p.ProductCode;
//                excelWs.Range["B" + row].ColumnWidth = 50;
//                excelWs.Range["B" + row].Value = p.ProductName;
//                excelWs.Range["C" + row].Value = p.ProdutPrice;
//                row++;
//            }
//        }

//        excelWs.Name = "DanhMucSanPham";
//        excelWs.Activate();

//        //Lưu file
//        SaveFileDialog saveFileDialog = new SaveFileDialog();
//        if (saveFileDialog.ShowDialog() == DialogResult.OK)
//            excelWb.SaveAs(saveFileDialog.FileName);
//        excelApp.Quit();
//    }
//}