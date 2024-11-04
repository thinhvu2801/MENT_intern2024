using MVPPetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPetManagement.Views
{
    public interface IPetFoodView
    {
        void SetPetFoodList(BindingSource petFoodList);
        void ShowPetFoodDetails(PetFood petFood);        
        event EventHandler ProductSelected;             
    }
}
