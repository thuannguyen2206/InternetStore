using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongNet
{
    public partial class viewInfoDevice : Form
    {
        public viewInfoDevice()
        {
            InitializeComponent();
        }

        private void viewInfoDevice_Load(object sender, EventArgs e)
        {
            loadHeaderViewInfoDevice();
            loadInfoDevice();
        }
        void loadHeaderViewInfoDevice()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("STT", 50);
            listView1.Columns.Add("Máy", 50);
            listView1.Columns.Add("Hệ điều hành", 160);
            listView1.Columns.Add("Hãng", 100);
            listView1.Columns.Add("Vi xử lý", 145);
            listView1.Columns.Add("Bộ nhớ RAM (GB)", 100);
        }
        private void loadInfoDevice()
        {
            string query = "select numberDevice , os , producer , processor, memory from INFO_DEVICE";
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            listView1.Clear();
            loadHeaderViewInfoDevice();
            int x = 1;
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(x.ToString());
                item.SubItems.Add(row["numberDevice"].ToString());
                item.SubItems.Add(row["os"].ToString());
                item.SubItems.Add(row["producer"].ToString());
                item.SubItems.Add(row["processor"].ToString());
                item.SubItems.Add(row["memory"].ToString());
                listView1.Items.Add(item);
                x++;
            }
        }
    }
}
