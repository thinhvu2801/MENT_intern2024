using TunaCRUD.Models;
using System.Collections.Generic;

namespace TunaCRUD.Views
{
    public interface IFishView
    {
        void DisplayFishList(List<FishInformation> fishList);
        FishInformation GetFishDetails();
        void SetFishDetails(FishInformation fish);
        void ClearInput();
        int GetSelectedFishId();
    }
}
