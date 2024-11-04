using MVPPetManagement.Models;
using MVPPetManagement.Views;
using MVPPetManagement._Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVPPetManagement.Presenters
{
    public class PetPresenter
    {
        private readonly IPetView view;
        private readonly IPetRepository repository;

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;

            LoadAllPetList();
            this.view.Show();
        }

        private void LoadAllPetList()
        {
            var petList = repository.GetAll().ToList();
            var petBindingSource = new BindingSource { DataSource = petList };
            view.SetPetListBindingSource(petBindingSource);
        }

        private void SearchPet(object sender, EventArgs e)
        {
            var value = view.SearchValue?.ToLower();
            var petList = string.IsNullOrWhiteSpace(value)
                ? repository.GetAll().ToList()
                : repository.GetByValue(value).ToList();

            view.SetPetListBindingSource(new BindingSource { DataSource = petList });
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanViewFields();
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = view.GetCurrentPet();
            view.PetId = pet.Pet_Id.ToString();
            view.PetName = pet.Pet_Name;
            view.PetType = pet.Pet_Type;
            view.PetColour = pet.Pet_Colour;
            view.IsEdit = true;
        }

        private void SavePet(object sender, EventArgs e)
        {
            try
            {
                int petId;
                if (!int.TryParse(view.PetId, out petId))
                {
                    petId = 0; // Gán giá trị mặc định nếu PetId không hợp lệ
                }

                var model = new PetModel
                {
                    Pet_Id = petId,
                    Pet_Name = view.PetName,
                    Pet_Type = view.PetType,
                    Pet_Colour = view.PetColour
                };

                new ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Pet edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Pet added successfully";
                }

                view.IsSuccessful = true;
                LoadAllPetList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        } 

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = view.GetCurrentPet();
                repository.Delete(pet.Pet_Id);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }


        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.PetId = "0000";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }
    }
}
