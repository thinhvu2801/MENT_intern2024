using MVPPetManagement.Models;
using MVPPetManagement.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MVPPetManagement.Presenters
{
    public class PetFoodPresenter
    {
        private readonly IPetFoodView view;
        private readonly BindingSource petFoodBindingSource;
        private List<PetFood> petFoodList;

        public PetFoodPresenter(IPetFoodView view)
        {
            this.view = view;
            petFoodBindingSource = new BindingSource();

            LoadAllPetFood();

            view.SetPetFoodList(petFoodBindingSource);
            view.ProductSelected += OnProductSelected;
        }

        private void LoadAllPetFood()
        {
            // Thêm một vài sản phẩm PetFood mẫu
            petFoodList = new List<PetFood>
            {
                new PetFood(1, "Royal Canin", "High-quality food for cats", 50.0),
                new PetFood(2, "Pedigree", "Premium dog food", 40.0),
                new PetFood(3, "Whiskas", "Delicious cat food", 30.0)
            };
            petFoodBindingSource.DataSource = petFoodList;
        }

        private void OnProductSelected(object sender, EventArgs e)
        {
            var selectedPetFood = petFoodBindingSource.Current as PetFood;
            if (selectedPetFood != null)
            {
                view.ShowPetFoodDetails(selectedPetFood);
            }
        }
    }
}
