using Kiemtra_nhom1.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtra_nhom1
{
    public partial class Form1 : Form
    {
        string partNhom;
        string partLienLac;
        private List<DS_DanhBa> ds_nhom;
        private List<DS_Chitiet> ds_lienlac;
        public Form1()
        {
            InitializeComponent();
            partNhom = Application.StartupPath + @"\data\db_nhom.data";
            partLienLac = Application.StartupPath + @"\data\db_lienlac.data";
            gv_nhom.AutoGenerateColumns = false;

            ds_nhom = DS_DanhBa.GetListFromFile(partNhom);
            bds_1.DataSource = ds_nhom;
            gv_nhom.DataSource = bds_1;
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var nhomdanhba = (DS_DanhBa)bds_1.Current;
            ds_lienlac = DS_Chitiet.GetListFromFile(partLienLac, nhomdanhba.TenNhom);
            gv_lienlac.AutoGenerateColumns = false;
            bds_2.DataSource = ds_lienlac;
            gv_lienlac.DataSource = bds_2;
        }

        private void Gv_lienlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nhomdanhba = (DS_DanhBa)bds_1.Current;
            ds_lienlac = DS_Chitiet.GetListFromFile(partLienLac, nhomdanhba.TenNhom);
            gv_lienlac.AutoGenerateColumns = false;
            bds_2.DataSource = ds_lienlac;
            gv_lienlac.DataSource = bds_2;
            var chitiet = (DS_Chitiet)bds_2.Current;
            lb_tengoi.Text = chitiet.Tengoi;
            lb_email.Text = chitiet.Email;
            lb_diachi.Text = chitiet.Diachi;
            lb_sdt.Text = chitiet.SDT;
        }
    }
}
