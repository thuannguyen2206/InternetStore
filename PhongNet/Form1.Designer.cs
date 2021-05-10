namespace PhongNet
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowMaintenance = new System.Windows.Forms.Button();
            this.btnAllDevice = new System.Windows.Forms.Button();
            this.btnHiring = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnHire = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxTotalPrice = new System.Windows.Forms.TextBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbDevice = new System.Windows.Forms.Label();
            this.txtboxStop = new System.Windows.Forms.TextBox();
            this.txtboxStart = new System.Windows.Forms.TextBox();
            this.lbStop = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbTimeUsing = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnInfoDevice = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(575, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 462);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtboxTotalPrice);
            this.tabPage1.Controls.Add(this.lbTotalPrice);
            this.tabPage1.Controls.Add(this.lbDevice);
            this.tabPage1.Controls.Add(this.txtboxStop);
            this.tabPage1.Controls.Add(this.txtboxStart);
            this.tabPage1.Controls.Add(this.lbStop);
            this.tabPage1.Controls.Add(this.lbStart);
            this.tabPage1.Controls.Add(this.lbTimeUsing);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoạt động";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowMaintenance);
            this.groupBox1.Controls.Add(this.btnAllDevice);
            this.groupBox1.Controls.Add(this.btnHiring);
            this.groupBox1.Controls.Add(this.btnEmpty);
            this.groupBox1.Controls.Add(this.btnHire);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Location = new System.Drawing.Point(0, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoạt động";
            // 
            // btnShowMaintenance
            // 
            this.btnShowMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMaintenance.Location = new System.Drawing.Point(372, 21);
            this.btnShowMaintenance.Name = "btnShowMaintenance";
            this.btnShowMaintenance.Size = new System.Drawing.Size(102, 46);
            this.btnShowMaintenance.TabIndex = 12;
            this.btnShowMaintenance.Text = "Bảo trì";
            this.btnShowMaintenance.UseVisualStyleBackColor = true;
            this.btnShowMaintenance.Click += new System.EventHandler(this.btnShowMaintenance_Click);
            // 
            // btnAllDevice
            // 
            this.btnAllDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllDevice.Location = new System.Drawing.Point(9, 21);
            this.btnAllDevice.Name = "btnAllDevice";
            this.btnAllDevice.Size = new System.Drawing.Size(106, 46);
            this.btnAllDevice.TabIndex = 9;
            this.btnAllDevice.Text = "Tất cả";
            this.btnAllDevice.UseVisualStyleBackColor = true;
            this.btnAllDevice.Click += new System.EventHandler(this.btnAllDevice_Click);
            // 
            // btnHiring
            // 
            this.btnHiring.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHiring.Location = new System.Drawing.Point(136, 21);
            this.btnHiring.Name = "btnHiring";
            this.btnHiring.Size = new System.Drawing.Size(104, 46);
            this.btnHiring.TabIndex = 10;
            this.btnHiring.Text = "Đang thuê";
            this.btnHiring.UseVisualStyleBackColor = true;
            this.btnHiring.Click += new System.EventHandler(this.btnHiring_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.Location = new System.Drawing.Point(256, 21);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(100, 46);
            this.btnEmpty.TabIndex = 11;
            this.btnEmpty.Text = "Trống";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnHire
            // 
            this.btnHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHire.Location = new System.Drawing.Point(66, 73);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(113, 46);
            this.btnHire.TabIndex = 5;
            this.btnHire.Text = "Thuê máy";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(304, 73);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 46);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Trả máy";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "VNĐ";
            // 
            // txtboxTotalPrice
            // 
            this.txtboxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalPrice.Location = new System.Drawing.Point(117, 356);
            this.txtboxTotalPrice.Name = "txtboxTotalPrice";
            this.txtboxTotalPrice.ReadOnly = true;
            this.txtboxTotalPrice.Size = new System.Drawing.Size(211, 24);
            this.txtboxTotalPrice.TabIndex = 13;
            this.txtboxTotalPrice.Text = "0";
            this.txtboxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(6, 359);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(80, 17);
            this.lbTotalPrice.TabIndex = 12;
            this.lbTotalPrice.Text = "Thành tiền:";
            // 
            // lbDevice
            // 
            this.lbDevice.AutoSize = true;
            this.lbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevice.Location = new System.Drawing.Point(204, 54);
            this.lbDevice.Name = "lbDevice";
            this.lbDevice.Size = new System.Drawing.Size(73, 24);
            this.lbDevice.TabIndex = 7;
            this.lbDevice.Text = "Số máy";
            // 
            // txtboxStop
            // 
            this.txtboxStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStop.Location = new System.Drawing.Point(117, 156);
            this.txtboxStop.Name = "txtboxStop";
            this.txtboxStop.ReadOnly = true;
            this.txtboxStop.Size = new System.Drawing.Size(239, 24);
            this.txtboxStop.TabIndex = 4;
            // 
            // txtboxStart
            // 
            this.txtboxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStart.Location = new System.Drawing.Point(117, 98);
            this.txtboxStart.Name = "txtboxStart";
            this.txtboxStart.ReadOnly = true;
            this.txtboxStart.Size = new System.Drawing.Size(239, 24);
            this.txtboxStart.TabIndex = 3;
            // 
            // lbStop
            // 
            this.lbStop.AutoSize = true;
            this.lbStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStop.Location = new System.Drawing.Point(6, 159);
            this.lbStop.Name = "lbStop";
            this.lbStop.Size = new System.Drawing.Size(64, 17);
            this.lbStop.TabIndex = 2;
            this.lbStop.Text = "Kết thúc:";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStart.Location = new System.Drawing.Point(6, 101);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(61, 17);
            this.lbStart.TabIndex = 1;
            this.lbStart.Text = "Bắt đầu:";
            // 
            // lbTimeUsing
            // 
            this.lbTimeUsing.AutoSize = true;
            this.lbTimeUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeUsing.Location = new System.Drawing.Point(376, 13);
            this.lbTimeUsing.Name = "lbTimeUsing";
            this.lbTimeUsing.Size = new System.Drawing.Size(80, 24);
            this.lbTimeUsing.TabIndex = 0;
            this.lbTimeUsing.Text = "00:00:00";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInfoDevice);
            this.tabPage2.Controls.Add(this.btnTotalPrice);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.btnViewHistory);
            this.tabPage2.Controls.Add(this.btnMaintenance);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cài đặt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(386, 6);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(89, 47);
            this.btnTotalPrice.TabIndex = 4;
            this.btnTotalPrice.Text = "Doanh thu";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(6, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 367);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(291, 6);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(89, 47);
            this.btnViewHistory.TabIndex = 2;
            this.btnViewHistory.Text = "Lịch sử";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(101, 6);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(89, 47);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "Bảo trì";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm máy";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 466);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnInfoDevice
            // 
            this.btnInfoDevice.Location = new System.Drawing.Point(196, 6);
            this.btnInfoDevice.Name = "btnInfoDevice";
            this.btnInfoDevice.Size = new System.Drawing.Size(89, 47);
            this.btnInfoDevice.TabIndex = 5;
            this.btnInfoDevice.Text = "Thông tin máy";
            this.btnInfoDevice.UseVisualStyleBackColor = true;
            this.btnInfoDevice.Click += new System.EventHandler(this.btnInfoDevice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 485);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Phòng Net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbStop;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbTimeUsing;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.TextBox txtboxStop;
        private System.Windows.Forms.TextBox txtboxStart;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbDevice;
        private System.Windows.Forms.TextBox txtboxTotalPrice;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnHiring;
        private System.Windows.Forms.Button btnAllDevice;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Button btnShowMaintenance;
        private System.Windows.Forms.Button btnInfoDevice;
    }
}

