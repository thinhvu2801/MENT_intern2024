using System;
using System.Windows.Forms;
using TunaCRUD.Models;
using TunaCRUD.Presenters;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace TunaCRUD.Views
{
    public partial class FishInformationForm : Form, IFishView
    {
        private FishPresenter _presenter;

        public FishInformationForm()
        {
            InitializeComponent();
            _presenter = new FishPresenter(this);
        }

        public void DisplayFishList(System.Collections.Generic.List<FishInformation> fishList)
        {
            dataGridViewFish.DataSource = fishList;
        }

        public FishInformation GetFishDetails()
        {
            return new FishInformation
            {
                GRNNumber = comboBox1.SelectedItem?.ToString(),
                CatchingMethod = comboBoxMethod.SelectedItem?.ToString(),
                CatchArea = txtArea.Text,
                ReceivingDate = dateTimeReceive.Value,
                CatchDate = dateTimeCatch.Value,
                Species = comboBoxSpecies.SelectedItem?.ToString(),
                CollectedBy = txtCollected.Text,
                ReceivedFor = comboBoxReceived.SelectedItem?.ToString(),
                NIC = txtNIC.Text,
                Grade = comboBoxGrade.SelectedItem?.ToString(),
                Vessel = comboVesselTop.SelectedItem?.ToString(),
                DhoniCode = txtDhoniCode.Text,
                Weight = decimal.Parse(txtWeight.Text),
            };
        }

        public void SetFishDetails(FishInformation fish)
        {
            txtGRNNumber.Text = fish.GRNNumber;
            comboBoxMethod.Text = fish.CatchingMethod;
            txtArea.Text = fish.CatchArea;
            dateTimeReceive.Value = fish.ReceivingDate;
            dateTimeCatch.Value = fish.CatchDate;
            comboBoxSpecies.Text = fish.Species;
            txtCollected.Text = fish.CollectedBy;
            comboBoxReceived.Text = fish.ReceivedFor;
            txtNIC.Text = fish.NIC;
            comboBoxGrade.Text = fish.Grade;
            comboVesselTop.Text = fish.Vessel;
            txtDhoniCode.Text = fish.DhoniCode;
            txtWeight.Text = fish.Weight.ToString();
        }

        public void ClearInput()
        {
            txtGRNNumber.Clear();
            txtArea.Clear();
            txtCollected.Clear();
            txtNIC.Clear();
            txtDhoniCode.Clear();
            txtWeight.Clear();
        }

        public int GetSelectedFishId()
        {
            if (dataGridViewFish.CurrentRow != null)
            {
                return (int)dataGridViewFish.CurrentRow.Cells["FishID"].Value;
            }
            return -1;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _presenter.UpdateFish();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter.DeleteFish();
        }

        private void dataGridViewFish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FishInformation fish = (FishInformation)dataGridViewFish.Rows[e.RowIndex].DataBoundItem;
                SetFishDetails(fish);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddFish();
        }

        private void buttonHold_Click(object sender, EventArgs e)
        {
            //view the data to edit
            _presenter.LoadFishData();
        }
    }
}
