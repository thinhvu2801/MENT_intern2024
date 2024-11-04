using MVPPetManagement.Models;
using MVPPetManagement.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class PetView : Form, IPetView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        // Constructor
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += (s, e) => this.Close();
        }

        public bool IsEdit
        {
            get => isEdit;
            set => isEdit = value;
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Add new pet";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Edit pet";
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            button1.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.TabPages.Add(tabPagePetList);
            };
            // Delete
            btnDelete.Click += delegate
            {
                if (dataGridView.CurrentRow != null)
                {
                    var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Lấy Pet_Id từ dòng được chọn trong DataGridView
                        int petId = (int)dataGridView.CurrentRow.Cells["Pet_Id"].Value;

                        // Gọi hàm DeletePet với Pet_Id được lấy từ DataGridView
                        DeleteEvent?.Invoke(petId, EventArgs.Empty);
                        MessageBox.Show(Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a pet to delete.");
                }
            };

        }

        // Properties
        public string PetId { get => txtPetId.Text; set => txtPetId.Text = value; }
        public string PetName { get => txtPetName.Text; set => txtPetName.Text = value; }
        public string PetType { get => txtPetType.Text; set => txtPetType.Text = value; }
        public string PetColour { get => txtPetColour.Text; set => txtPetColour.Text = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView.DataSource = petList;
            dataGridView.Columns["Pet_Id"].HeaderText = "ID Pet";
            dataGridView.Columns["Pet_Name"].HeaderText = "Tên Pet";
            dataGridView.Columns["Pet_Type"].HeaderText = "Loại Pet";
            dataGridView.Columns["Pet_Colour"].HeaderText = "Màu sắc Pet";
        }

        private static PetView instance;
        public static PetView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView
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

        public PetModel GetCurrentPet()
        {
            if (dataGridView.CurrentRow != null)
            {
                return (PetModel)dataGridView.CurrentRow.DataBoundItem;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
