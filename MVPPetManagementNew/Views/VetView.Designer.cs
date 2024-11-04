namespace MVPPetManagement.Views
{
    partial class VetView
    {

        // Các control trên form
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVetList;
        private System.Windows.Forms.TabPage tabPageVetDetail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtVetAddress;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox lat;
        private System.Windows.Forms.TextBox lon;
        private System.Windows.Forms.ComboBox map_type;

        /// <summary>
        /// Thiết lập các điều khiển trên form
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVetList = new System.Windows.Forms.TabPage();
            this.tabPageVetDetail = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtVetAddress = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lat = new System.Windows.Forms.TextBox();
            this.lon = new System.Windows.Forms.TextBox();
            this.map_type = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageVetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVetList);
            this.tabControl1.Controls.Add(this.tabPageVetDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageVetList
            // 
            this.tabPageVetList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageVetList.BackgroundImage")));
            this.tabPageVetList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageVetList.Location = new System.Drawing.Point(4, 22);
            this.tabPageVetList.Name = "tabPageVetList";
            this.tabPageVetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVetList.Size = new System.Drawing.Size(844, 551);
            this.tabPageVetList.TabIndex = 0;
            this.tabPageVetList.Text = "Vet List";
            // 
            // tabPageVetDetail
            // 
            this.tabPageVetDetail.Controls.Add(this.btnBack);
            this.tabPageVetDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageVetDetail.Name = "tabPageVetDetail";
            this.tabPageVetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVetDetail.Size = new System.Drawing.Size(776, 535);
            this.tabPageVetDetail.TabIndex = 1;
            this.tabPageVetDetail.Text = "Vet Detail";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(639, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(650, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtVetAddress
            // 
            this.txtVetAddress.Location = new System.Drawing.Point(140, 20);
            this.txtVetAddress.Name = "txtVetAddress";
            this.txtVetAddress.Size = new System.Drawing.Size(200, 20);
            this.txtVetAddress.TabIndex = 2;
            this.txtVetAddress.Text = "Nha Trang City";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 3;
            // 
            // lat
            // 
            this.lat.Location = new System.Drawing.Point(0, 0);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(100, 20);
            this.lat.TabIndex = 4;
            // 
            // lon
            // 
            this.lon.Location = new System.Drawing.Point(0, 0);
            this.lon.Name = "lon";
            this.lon.Size = new System.Drawing.Size(100, 20);
            this.lon.TabIndex = 5;
            // 
            // map_type
            // 
            this.map_type.FormattingEnabled = true;
            this.map_type.Items.AddRange(new object[] {
            "Map",
            "Satellite",
            "Hybrid",
            "Terrain",
            "Earth"});
            this.map_type.Location = new System.Drawing.Point(380, 90);
            this.map_type.Name = "map_type";
            this.map_type.Size = new System.Drawing.Size(121, 21);
            this.map_type.TabIndex = 6;
            // 
            // VetView
            // 
            this.ClientSize = new System.Drawing.Size(852, 577);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtVetAddress);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lat);
            this.Controls.Add(this.lon);
            this.Controls.Add(this.map_type);
            this.Name = "VetView";
            this.Text = "VetView";
            this.tabControl1.ResumeLayout(false);
            this.tabPageVetDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
