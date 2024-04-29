using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace offical_winform_quanlybaidang
{
    public partial class FormQuanLy : Form
    {
        public bool isThoat = true;
        public FormQuanLy()
        {
            InitializeComponent();
        }

        public event EventHandler DangXuat;
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void FormQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();     
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isThoat)
            {
                if (MessageBox.Show("Bạn có muốn thoát phần mềm?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
    }
}
