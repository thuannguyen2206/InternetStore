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
    public partial class addInfoDevice : Form
    {
        public addInfoDevice()
        {
            InitializeComponent();
            send = new sendNumberDevice(getValue);//con trỏ tới hàm getValue
        }
        int device = 0;
        //khai báo delegate
        public delegate void sendNumberDevice(int number);
        public sendNumberDevice send;

        private void getValue(int number)
        {
            this.device = number;
        }
        public void addInfo()
        {
            int ram = 0;
            ram = Convert.ToInt32(txtboxRAM.Text);
            string query = "exec P_insertInfoDevice @number , @os , @producer , @processor , @memory";
            int result = ConnectionClass.Instance.ExecuteNonQuery(query, new object[] { device, txtboxOS.Text, cbProducer.Text, txtboxProcessor.Text, ram });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addInfo();
            this.Close();
        }

        private void addInfoDevice_Load(object sender, EventArgs e)
        {
            cbProducer.Items.Add("Asus");
            cbProducer.Items.Add("Dell");
            cbProducer.Items.Add("Hp");
            cbProducer.Items.Add("Gateway");
            cbProducer.Items.Add("Lenovo");
            cbProducer.Items.Add("Acer");
            cbProducer.Items.Add("Apple");
            cbProducer.Items.Add("Khác");
        }
    }
}
