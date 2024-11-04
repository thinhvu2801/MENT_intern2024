using MVPPetManagement.Models;
using MVPPetManagement.Views;
using Microsoft.EntityFrameworkCore;
using MVPPetManagement._Repositories;
using System;
using CRUDWinFormsMVP.Views;
using System.Windows.Forms;

namespace MVPPetManagement.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string connectionString;

        public MainPresenter(IMainView mainView, string connectionString)
        {
            this.mainView = mainView;
            this.connectionString = connectionString;

            var optionsBuilder = new DbContextOptionsBuilder<PetDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var dbContext = new PetDbContext(optionsBuilder.Options);

            IPetRepository petRepository = new PetRepository(dbContext);
            this.mainView.ShowPetView += (sender, e) => ShowPetsView(petRepository);
            this.mainView.ShowVetsView += (sender, e) => ShowVetsView();
            this.mainView.ShowOwnerView += (sender, e) => ShowOwnerView();
        }

        private void ShowOwnerView()
        {
            var ownerView = OwnerView.GetInstance(mainView as Form);
            ownerView.OwnerName = "Thinh Vu"; 
            ownerView.OwnerAddress = "abc xyz";
            ownerView.OwnerPhone = "098765432";
            ownerView.Show();
        }

        private void ShowPetsView(IPetRepository petRepository)
        {
            // Lấy thể hiện PetView đã tồn tại hoặc tạo mới nếu chưa có
            var petView = PetView.GetInstace(mainView as Form);
            new PetPresenter(petView, petRepository);
            petView.Show(); // Hiển thị PetView
        }
        private void ShowVetsView()
        {
            // Lấy thể hiện VetView đã tồn tại hoặc tạo mới nếu chưa có
            var vetView = VetView.GetInstance(mainView as Form);
            vetView.Show(); // Hiển thị VetView
        }
        //show petfood view
        //private void ShowPetFoodView()
        //{
        //    var petFoodView = PetFoodView.GetInstance(mainView as Form);
        //    petFoodView.Show();
        //}

    }
}
