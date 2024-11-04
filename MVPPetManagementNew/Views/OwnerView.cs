using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace MVPPetManagement.Views
{
    public partial class OwnerView : Form, IOwnerView
    {
        private bool isDarkTheme = false; // Biến trạng thái để lưu giao diện sáng/tối

        public OwnerView()
        {
            InitializeComponent();
            ApplyTheme(); // Cập nhật giao diện mặc định (sáng)
            btnClose.Click += (s, e) => this.Close();

        }

        // Sự kiện nút thay đổi avatar
        private void BtnChangeAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        // Sự kiện nút chuyển đổi giao diện sáng/tối
        private void BtnToggleTheme_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ApplyTheme();
        }

        // Phương thức thay đổi giao diện sáng/tối
        private void ApplyTheme()
        {
            if (isDarkTheme)
            {
                this.BackColor = Color.FromArgb(18, 18, 18); // Màu #121212
                this.ForeColor = Color.White;
                btnChangeAvatar.BackColor = Color.FromArgb(28, 28, 28);
                btnChangeAvatar.ForeColor = Color.White;
                btnClose.BackColor = Color.FromArgb(28, 28, 28);
                btnClose.ForeColor = Color.White;
                btnToggleTheme.BackColor = Color.FromArgb(28, 28, 28);
                btnToggleTheme.ForeColor = Color.White;
                btnChangeInfo.BackColor = Color.FromArgb(28, 28, 28);
                btnChangeInfo.ForeColor = Color.White;

                // Thay đổi màu cho các label nếu cần
                lblOwnerName.ForeColor = Color.White;
                lblOwnerAddress.ForeColor = Color.White;
                lblOwnerPhone.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                btnChangeAvatar.BackColor = SystemColors.Control;
                btnChangeAvatar.ForeColor = Color.Black;
                btnClose.BackColor = SystemColors.Control;
                btnClose.ForeColor = Color.Black;
                btnToggleTheme.BackColor = SystemColors.Control;
                btnToggleTheme.ForeColor = Color.Black;
                btnChangeInfo.BackColor = SystemColors.Control;
                btnChangeInfo.ForeColor = Color.Black;

                // Trả lại màu cho các label khi trở về light mode
                lblOwnerName.ForeColor = Color.Black;
                lblOwnerAddress.ForeColor = Color.Black;
                lblOwnerPhone.ForeColor = Color.Black;
            }
        }

    // Sự kiện nút thay đổi thông tin
    private void BtnChangeInfo_Click(object sender, EventArgs e)
        {
            ChangeInformation();
        }

        // Phương thức để thay đổi thông tin chủ sở hữu
        public void ChangeInformation()
        {
            using (Form changeInfoForm = new Form())
            {
                changeInfoForm.Text = "Change Owner Information";
                changeInfoForm.Size = new Size(300, 250);

                // Tạo các trường nhập liệu
                TextBox txtNewName = new TextBox { Location = new Point(20, 20), Width = 200 };
                TextBox txtNewAddress = new TextBox { Location = new Point(20, 60), Width = 200 };
                TextBox txtNewPhone = new TextBox { Location = new Point(20, 100), Width = 200 };

                // Nút để xác nhận thay đổi
                Button btnSubmit = new Button
                {
                    Text = "Submit",
                    Location = new Point(20, 140)
                };
                btnSubmit.Click += (s, args) =>
                {
                    // Cập nhật thông tin mới
                    OwnerName = txtNewName.Text;
                    OwnerAddress = txtNewAddress.Text;
                    OwnerPhone = txtNewPhone.Text;

                    MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changeInfoForm.Close();
                };

                // Thêm các điều khiển vào form thay đổi thông tin
                changeInfoForm.Controls.Add(new Label { Text = "New Name:", Location = new Point(20, 0) });
                changeInfoForm.Controls.Add(txtNewName);
                changeInfoForm.Controls.Add(new Label { Text = "New Address:", Location = new Point(20, 40) });
                changeInfoForm.Controls.Add(txtNewAddress);
                changeInfoForm.Controls.Add(new Label { Text = "New Phone:", Location = new Point(20, 80) });
                changeInfoForm.Controls.Add(txtNewPhone);
                changeInfoForm.Controls.Add(btnSubmit);

                // Hiển thị form thay đổi thông tin
                changeInfoForm.ShowDialog();
            }
        }

        public string OwnerName
        {
            get => txtOwnerName.Text;
            set => txtOwnerName.Text = value;
        }

        public string OwnerAddress
        {
            get => txtOwnerAddress.Text;
            set => txtOwnerAddress.Text = value;
        }

        public string OwnerPhone
        {
            get => txtOwnerPhone.Text;
            set => txtOwnerPhone.Text = value;
        }

        // Singleton pattern cho form OwnerView
        private static OwnerView instance;
        public static OwnerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new OwnerView
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
        private void OpenLink(string v)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = v,
                    UseShellExecute = true // Sử dụng trình duyệt mặc định
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open the link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGithub_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/thinhvu2801");
        }

        

        private void btnLkn_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.linkedin.com/in/v%C5%A9-minh-th%E1%BB%8Bnh-90b726275/");
        }

        private void bthIns_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.instagram.com/");
        }

        private void btnFb_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.facebook.com/");

        }

        private void btnGm_Click(object sender, EventArgs e)
        {
            OpenLink("mailto:minhthinhhero@gmail.com");
        }
    }
}
