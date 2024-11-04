using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPetManagement.Views
{
    public interface IOwnerView
    {
        string OwnerName { get; set; }
        string OwnerAddress { get; set; }
        string OwnerPhone { get; set; }

        void Show();  // Hiển thị OwnerView
    }
}
