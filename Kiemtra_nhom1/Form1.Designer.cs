namespace Kiemtra_nhom1
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_addnhom = new System.Windows.Forms.ToolStripButton();
            this.bt_xoanhom = new System.Windows.Forms.ToolStripButton();
            this.bt_themlienlac = new System.Windows.Forms.ToolStripButton();
            this.bt_xoalienlac = new System.Windows.Forms.ToolStripButton();
            this.tb_search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gv_nhom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_lienlac = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tengoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bds_1 = new System.Windows.Forms.BindingSource(this.components);
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.bds_2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_nhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_lienlac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_addnhom,
            this.bt_xoanhom,
            this.bt_themlienlac,
            this.bt_xoalienlac,
            this.tb_search,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_addnhom
            // 
            this.bt_addnhom.Image = global::Kiemtra_nhom1.Properties.Resources.add1;
            this.bt_addnhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_addnhom.Name = "bt_addnhom";
            this.bt_addnhom.Size = new System.Drawing.Size(116, 24);
            this.bt_addnhom.Text = " Thêm nhóm";
            
            // 
            // bt_xoanhom
            // 
            this.bt_xoanhom.Image = global::Kiemtra_nhom1.Properties.Resources.delete1;
            this.bt_xoanhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_xoanhom.Name = "bt_xoanhom";
            this.bt_xoanhom.Size = new System.Drawing.Size(101, 24);
            this.bt_xoanhom.Text = "Xoá nhóm";
            // 
            // bt_themlienlac
            // 
            this.bt_themlienlac.Image = global::Kiemtra_nhom1.Properties.Resources.add2;
            this.bt_themlienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_themlienlac.Name = "bt_themlienlac";
            this.bt_themlienlac.Size = new System.Drawing.Size(121, 24);
            this.bt_themlienlac.Text = "Thêm liên lạc";
            // 
            // bt_xoalienlac
            // 
            this.bt_xoalienlac.Image = global::Kiemtra_nhom1.Properties.Resources.delete2;
            this.bt_xoalienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_xoalienlac.Name = "bt_xoalienlac";
            this.bt_xoalienlac.Size = new System.Drawing.Size(114, 24);
            this.bt_xoalienlac.Text = "Xoá liên lạc ";
            // 
            // tb_search
            // 
            this.tb_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(155, 24);
            this.toolStripLabel1.Text = "Nhập từ cần tìm kiếm:";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            
            // 
            // gv_nhom
            // 
            this.gv_nhom.AllowUserToAddRows = false;
            this.gv_nhom.AllowUserToDeleteRows = false;
            this.gv_nhom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gv_nhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_nhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gv_nhom.Location = new System.Drawing.Point(0, 30);
            this.gv_nhom.Name = "gv_nhom";
            this.gv_nhom.ReadOnly = true;
            this.gv_nhom.RowHeadersWidth = 51;
            this.gv_nhom.RowTemplate.Height = 24;
            this.gv_nhom.Size = new System.Drawing.Size(287, 566);
            this.gv_nhom.TabIndex = 1;
            this.gv_nhom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TenNhom";
            this.Column1.HeaderText = "Tên nhóm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // gv_lienlac
            // 
            this.gv_lienlac.AllowUserToAddRows = false;
            this.gv_lienlac.AllowUserToDeleteRows = false;
            this.gv_lienlac.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gv_lienlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_lienlac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.gv_lienlac.Location = new System.Drawing.Point(293, 30);
            this.gv_lienlac.Name = "gv_lienlac";
            this.gv_lienlac.ReadOnly = true;
            this.gv_lienlac.RowHeadersWidth = 51;
            this.gv_lienlac.RowTemplate.Height = 24;
            this.gv_lienlac.Size = new System.Drawing.Size(605, 359);
            this.gv_lienlac.TabIndex = 2;
            this.gv_lienlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_lienlac_CellClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "TenGoi";
            this.Column2.HeaderText = "Tên gọi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // lb_tengoi
            // 
            this.lb_tengoi.AutoSize = true;
            this.lb_tengoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tengoi.Location = new System.Drawing.Point(313, 410);
            this.lb_tengoi.Name = "lb_tengoi";
            this.lb_tengoi.Size = new System.Drawing.Size(99, 25);
            this.lb_tengoi.TabIndex = 4;
            this.lb_tengoi.Text = "[Tên gọi]";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số điện thoại:";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(558, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------";
            
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(386, 467);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(0, 17);
            this.lb_diachi.TabIndex = 9;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(386, 510);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(0, 17);
            this.lb_email.TabIndex = 10;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(431, 550);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(0, 17);
            this.lb_sdt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 595);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_tengoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_lienlac);
            this.Controls.Add(this.gv_nhom);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - [LƯƠNG MINH TRƯỜNG]";
         
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_nhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_lienlac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bt_addnhom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton bt_xoanhom;
        private System.Windows.Forms.ToolStripButton bt_themlienlac;
        private System.Windows.Forms.ToolStripButton bt_xoalienlac;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_search;
        private System.Windows.Forms.DataGridView gv_nhom;
        private System.Windows.Forms.DataGridView gv_lienlac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tengoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bds_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.BindingSource bds_2;
    }
}

