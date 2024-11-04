using MVPPetManagement.Models;
using MVPPetManagement.Presenters;
using System;
using System.Windows.Forms;

namespace MVPPetManagement.Views
{
    public partial class PetFoodView : Form, IPetFoodView
    {
        public event EventHandler ProductSelected;

        public PetFoodView()
        {
            InitializeComponent();
            var presenter = new PetFoodPresenter(this);
        }

        // Cài đặt danh sách sản phẩm
        public void SetPetFoodList(BindingSource petFoodList)
        {
            listBoxProducts.DataSource = petFoodList;
            listBoxProducts.DisplayMember = "Name";
            listBoxProducts.SelectedIndexChanged += (s, e) => ProductSelected?.Invoke(this, EventArgs.Empty);
        }

        // Hiển thị chi tiết sản phẩm
        public void ShowPetFoodDetails(PetFood petFood)
        {
            txtName.Text = petFood.Name;
            txtDescription.Text = petFood.Description;
            txtPrice.Text = petFood.Price.ToString();
        }

        private void InitializeComponent()
        {
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 12);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(200, 394);
            this.listBoxProducts.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(250, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(250, 50);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 100);
            this.txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(250, 170);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // PetFoodView
            // 
            this.ClientSize = new System.Drawing.Size(899, 558);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "PetFoodView";
            this.Text = "Pet Food Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
