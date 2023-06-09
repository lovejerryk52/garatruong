﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 10;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 11;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 12;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2
                , MessageBoxOptions.ServiceNotification);
            if (result == DialogResult.OK) { this.Close(); }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            switch (e.Node.Text)
            {
                case "Tiếp nhận xe":
                    tabControl1.SelectedIndex = 1;
                    break;
                case "Tra cứu xe":
                    tabControl1.SelectedIndex = 2;
                    break;
                case "Xem danh sách xe":
                    tabControl1.SelectedIndex = 3;
                    break;
                case "Lập phiếu sửa chữa":
                    tabControl1.SelectedIndex = 4;
                    break;
                case "Lập phiếu thu tiền":
                    tabControl1.SelectedIndex = 5;
                    break;
                case "Nhập vật tư phụ tùng":
                    tabControl1.SelectedIndex = 6;
                    break;
                case "Thay đổi quy định":
                    tabControl1.SelectedIndex = 7;
                    break;
                case "Doanh thu":
                    tabControl1.SelectedIndex = 8;
                    break;
                case "Tồn kho":
                    tabControl1.SelectedIndex = 9;
                    break;

            }

        }
    }
}
