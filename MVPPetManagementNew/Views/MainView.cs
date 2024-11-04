using MVPPetManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnPets.Click += delegate { ShowPetView?.Invoke(this, EventArgs.Empty); };
            btnVets.Click += delegate { ShowVetsView?.Invoke(this, EventArgs.Empty); };
            btnOwner.Click += delegate { ShowOwnerView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowPetView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVetsView;

        //sự kiên sau khi click thay đổi màu chữ thành trắng
        private void btn_Click(object sender, EventArgs e)
        {
            btnPets.ForeColor = System.Drawing.Color.White;
        }

        // Sự kiện hover thay đổi màu chữ thành trắng
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            btnPets.ForeColor = System.Drawing.Color.White;
        }
    }
}