using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static PhongNet.addInfoDevice;

namespace PhongNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            create();
            loadHeaderViewHistory();
        }

        private int pricesHire = 10000;//giá thuê 10k/h
        private const int maxDevice = 15;
        private Button[] listB = new Button[maxDevice];//list máy

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(timer_Tick);

            btnAdd.BackColor = Color.LawnGreen;
            btnMaintenance.BackColor = Color.OrangeRed;
            btnViewHistory.BackColor = Color.LightGray;
            btnAllDevice.BackColor = Color.Gold;
            btnEmpty.BackColor = Color.Gold;
            btnHiring.BackColor = Color.Gold;
            btnHire.BackColor = Color.Aquamarine;
            btnReturn.BackColor = Color.Aquamarine;
            btnTotalPrice.BackColor = Color.Goldenrod;
            btnShowMaintenance.BackColor = Color.Gold;
            loadData();
        }

        private void create()
        {
            for (int i = 0; i < maxDevice; i++)
            {
                //tạo button máy
                Button btn = new Button();
                btn.Width = 70;
                btn.Height = 50;
                btn.BackColor = Color.LightGreen;
                listB[i] = btn;
            }
        }

        void loadHeaderViewHistory()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("STT", 30);
            listView1.Columns.Add("Máy", 40);
            listView1.Columns.Add("Giờ vào", 120);
            listView1.Columns.Add("Giờ ra", 120);
            listView1.Columns.Add("Thành tiền", 70);
        }

        public bool addDevice(int device)
        {
            string query = "exec P_insertDevice @number ";
            int result = ConnectionClass.Instance.ExecuteNonQuery(query, new object[] { device });
            return result > 0;//trả về true nếu result > 0

        }
        //thêm máy
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int k = flowLayoutPanel1.Controls.Count;
            if (k >= maxDevice)
            {
                MessageBox.Show("Danh sách máy đã đầy!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            addInfoDevice f2 = new addInfoDevice();
            f2.send(k+1);//gửi số máy qua cho form addInfoDevice để thêm thông tin máy
            f2.ShowDialog();

            if (addDevice(k + 1))
            {
                flowLayoutPanel1.Controls.Add(listB[k]);
                listB[k].Text = string.Format("Máy {0}", (k + 1));
                loadData();
            }
        }
        //load dữ liệu từ database lên
        private void loadData()
        {
            string query = "select * from DEVICE";
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            int k = 0;
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                flowLayoutPanel1.Controls.Add(listB[k]);
                listB[k].Text = string.Format("Máy {0}", (k + 1));
                listB[k].Click += new EventHandler(b_Click);
                if (Convert.ToInt32(row["states"].ToString()) == 0)
                {
                    listB[k].BackColor = Color.LightGreen;
                }
                else if (Convert.ToInt32(row["states"].ToString()) == 1)
                {
                    listB[k].BackColor = Color.Silver;
                }
                else
                {
                    listB[k].BackColor = Color.OrangeRed;
                }
                k++;
            }
        }

        public bool maintenanceDevice()
        {
            string query = "exec P_maintenance @number";
            int result = ConnectionClass.Instance.ExecuteNonQuery(query, new object[] { device });
            return result > 0;
        }
        //bảo trì máy
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            int count = flowLayoutPanel1.Controls.Count;
            if (count > 0 && device > 0)
            {
                if (maintenanceDevice())
                    loadData();
                else
                    MessageBox.Show("Bạn không thể bảo trì máy đang thuê.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //khi máy được click
        int device = 0;
        void b_Click(object sender, EventArgs e)
        {
            Button btn = (System.Windows.Forms.Button)sender;
            if (btn == null)
                MessageBox.Show("Vui lòng hãy chọn máy!", "Thông báo", MessageBoxButtons.OK);
            lbDevice.Text = btn.Text;
            device = Convert.ToInt32((btn.Text.Substring(4)));//cắt lấy số máy

            string query = "select * from DEVICE where numberDevice = " + device;
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row["states"].ToString()) == 1)
                {
                    txtboxStart.Text = row["start"].ToString();
                    btnHire.Enabled = false;
                }
                else if (Convert.ToInt32(row["states"].ToString()) == 2)
                {
                    btnHire.Enabled = false;
                }
                else
                {
                    txtboxStart.Text = "";
                    btnHire.Enabled = true;
                }
            }
        }

        public bool setTimeHire(int num, DateTime t)
        {
            string query = "exec P_setTimeHire @number , @start";
            int result = ConnectionClass.Instance.ExecuteNonQuery(query, new object[] { device, t });
            return result > 0;
        }

        //thuê máy
        private void btnHire_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("Hiện tại không có máy! Vui lòng thêm máy để thực hiện thao tác.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (device == 0)
            {
                MessageBox.Show("Bạn chưa chọn máy! Vui lòng chọn máy để thực hiện thao tác.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DateTime t = DateTime.Now;
            if (setTimeHire(device, t))
            {
                loadData();
                txtboxStart.Text = t.ToString();
                btnHire.Enabled = false;
            }
        }
        //trả máy
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (device > 0 && listB[device - 1].BackColor == Color.Silver)
            {
                DateTime sto = DateTime.Now;
                DateTime sta = new DateTime();
                string query = "";
                query = "select start from DEVICE where numberDevice = " + device;
                sta = Convert.ToDateTime(ConnectionClass.Instance.ExecuteScalar(query));
                getTime(sta, sto);
                double price = totalPrice();
                txtboxTotalPrice.Text = price.ToString();
                txtboxStop.Text = sto.ToString();
                if (MessageBox.Show(string.Format("Bạn muốn thanh toán {0} với số tiền là {1} VNĐ?", lbDevice.Text, price.ToString()), "Thanh toán", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    query = "exec P_setTimeReturn @number , @stop , @price ";
                    int result = ConnectionClass.Instance.ExecuteNonQuery(query, new object[] { device, sto, price });
                    loadData();
                    device = 0;
                    btnHire.Enabled = true;
                    txtboxStart.Text = "";
                }
                txtboxStop.Text = "";
                txtboxTotalPrice.Text = "0";
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn máy hoặc máy bạn chọn đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //tính thời gian mà khách thuê máy
        string hours = "0", minutes = "0";
        private void getTime(DateTime start, DateTime stop)
        {
            TimeSpan result = new TimeSpan();
            result = stop - start;
            hours = result.Hours.ToString();
            minutes = result.Minutes.ToString();
        }
        //thanh toán
        private double totalPrice()
        {
            double h, m;
            h = Convert.ToDouble(hours);
            m = Convert.ToDouble(minutes);
            int price = Convert.ToInt32((h + m / 60) * pricesHire);
            return price;
        }

        int hour = 0;
        int minute = 0;
        int second = 0;
        string kq = "";
        private void timer_Tick(object sender, EventArgs e)
        {
            ++second;
            if (second == 60)
            {
                second = 0;
                ++minute;
                if (minute == 60)
                {
                    minute = 0;
                    ++hour;
                }
            }
            if (hour < 10)
                kq = "0" + hour + ":";
            else
                kq = hour + ":";
            if (minute < 10)
                kq = kq + "0" + minute + ":";
            else
                kq = kq + minute + ":";
            if (second < 10)
                kq = kq + "0" + second;
            else
                kq = kq + second;
            lbTimeUsing.Text = kq;
        }
        //hiện tất cả máy
        private void btnAllDevice_Click(object sender, EventArgs e)
        {
            string query = "select states from DEVICE";
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            int i = 0;
            foreach (DataRow item in table.Rows)
            {
                listB[i].Visible = true;
                i++;
            }
        }
        //hiện máy đang thuê
        private void btnHiring_Click(object sender, EventArgs e)
        {
            string query = "select states from DEVICE";
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            int i = 0;
            foreach (DataRow item in table.Rows)
            {
                if (Convert.ToInt32(item["states"].ToString()) == 1)
                    listB[i].Visible = true;
                else
                    listB[i].Visible = false;
                i++;
            }
        }
        //hiện máy trống
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            string query = "select states from DEVICE";
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            int i = 0;
            foreach (DataRow item in table.Rows)
            {
                if (Convert.ToInt32(item["states"].ToString()) == 0)
                    listB[i].Visible = true;
                else
                    listB[i].Visible = false;
                i++;
            }
        }
        //hiện máy đang bảo trì
        private void btnShowMaintenance_Click(object sender, EventArgs e)
        {
            string query = "select states from DEVICE";
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            int i = 0;
            foreach (DataRow item in table.Rows)
            {
                if (Convert.ToInt32(item["states"].ToString()) == 2)
                    listB[i].Visible = true;
                else
                    listB[i].Visible = false;
                i++;
            }
        }
        //tổng doanh thu
        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            string query = "select SUM(price) from ACTIVE";
            object result = ConnectionClass.Instance.ExecuteScalar(query);
            MessageBox.Show("Tống doanh thu hiện tại là: " + result.ToString() + " VNĐ", "Thông báo");
        }

        public void viewHistory()
        {
            //truy vấn lấy bảng dữ liệu được sắp xếp theo id => sắp xếp máy vừa trả sẽ hiển thị lên trên
            string query = "select numberDevice , starts , stops , price from ACTIVE order by id desc";
            DataTable table = new DataTable();
            table = ConnectionClass.Instance.ExecuteQuery(query);
            listView1.Clear();
            loadHeaderViewHistory();
            int x = 1;
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(x.ToString());
                item.SubItems.Add(row["numberDevice"].ToString());
                item.SubItems.Add(row["starts"].ToString());
                item.SubItems.Add(row["stops"].ToString());
                item.SubItems.Add(row["price"].ToString());
                listView1.Items.Add(item);
                x++;
            }
        }
        //xem lịch sử
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            viewHistory();
        }
        //xem thông tin phần cứng máy 
        private void btnInfoDevice_Click(object sender, EventArgs e)
        {
            viewInfoDevice f3 = new viewInfoDevice();
            f3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

    }
}
