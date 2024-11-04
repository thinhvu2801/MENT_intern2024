using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;

namespace MVPPetManagement.Views
{
    public partial class VetView : Form
    {
        private WebView2 webViewMap;
        public VetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageVetDetail); // mở/tắt tab
            btnClose.Click += (s, e) => this.Close();

            // Initialize the WebView2 control
            webViewMap = new WebView2();
            webViewMap.Dock = DockStyle.Fill;
            tabPageVetDetail.Controls.Add(webViewMap);
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnBack.Click += (s, e) => SwitchToListTab();
            tabPageVetList.Click += (s, e) => ShowMap(); // hiển thị bản đồ
        }

        private void SwitchToDetailTab(string title)
        {
            tabControl1.TabPages.Remove(tabPageVetList); // Chuyển tab chi tiết
            tabControl1.TabPages.Add(tabPageVetDetail); // Hiển thị tab chứa bản đồ
            tabPageVetDetail.Text = title;
        }

        private void SwitchToListTab()
        {
            tabControl1.TabPages.Remove(tabPageVetDetail); // Quay lại danh sách
            tabControl1.TabPages.Add(tabPageVetList);
        }

        // Phương thức hiển thị bản đồ dựa trên địa chỉ hoặc tọa độ
        private void ShowMap()
        {
            string[] types = new string[] { "m", "k", "h", "p", "e" }; // Các loại bản đồ
            string url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1}",
                types[0], VetAddress); // Lấy địa chỉ từ TextBox (hoặc có thể là tọa độ)

            // Nếu checkbox được chọn, lấy tọa độ thay vì địa chỉ
            if (checkBox1.Checked)
            {
                url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1},{2}",
                    types[0], lat.Text, lon.Text);
            }

            // Hiển thị bản đồ trong WebView2 control
            webViewMap.Source = new Uri(url);
            SwitchToDetailTab("Vet Location");
        }

        // Property để lấy/đặt địa chỉ của Vet
        public string VetAddress
        {
            get => txtVetAddress.Text;
            set => txtVetAddress.Text = value;
        }

        private static VetView instance;
        public static VetView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new VetView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        // Event khi thay đổi checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtVetAddress.Enabled = false;
                lat.Enabled = true;
                lon.Enabled = true;
            }
            else
            {
                txtVetAddress.Enabled = true;
                lat.Enabled = false;
                lon.Enabled = false;
            }
        }

    }
}
