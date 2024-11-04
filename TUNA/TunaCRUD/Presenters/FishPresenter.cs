using TunaCRUD.Models;
using TunaCRUD.Views;
using System.Linq;

namespace TunaCRUD.Presenters
{
    public class FishPresenter
    {
        private readonly IFishView _view;
        private readonly FishDbContext _context;

        public FishPresenter(IFishView view)
        {
            _view = view;
            _context = new FishDbContext();
            LoadFishData();
        }

        public void LoadFishData()
        {
            var fishList = _context.FishInformations.ToList();
            _view.DisplayFishList(fishList);
        }

        public void AddFish()
        {
            FishInformation fish = _view.GetFishDetails();
            _context.FishInformations.Add(fish);
            _context.SaveChanges();
            LoadFishData();
            _view.ClearInput();
        }

        public void UpdateFish()
        {
            int fishId = _view.GetSelectedFishId();
            var existingFish = _context.FishInformations.Find(fishId);
            if (existingFish != null)
            {
                FishInformation fish = _view.GetFishDetails();
                existingFish.GRNNumber = fish.GRNNumber;
                existingFish.CatchingMethod = fish.CatchingMethod;
                existingFish.CatchArea = fish.CatchArea;
                existingFish.ReceivingDate = fish.ReceivingDate;
                existingFish.CatchDate = fish.CatchDate;
                existingFish.Species = fish.Species;
                existingFish.CollectedBy = fish.CollectedBy;
                existingFish.ReceivedFor = fish.ReceivedFor;
                existingFish.NIC = fish.NIC;
                existingFish.Grade = fish.Grade;
                existingFish.Vessel = fish.Vessel;
                existingFish.DhoniCode = fish.DhoniCode;
                existingFish.Weight = fish.Weight;


                _context.SaveChanges();
                LoadFishData();
                _view.ClearInput();
            }
        }

        public void DeleteFish()
        {
            int fishId = _view.GetSelectedFishId();
            var fish = _context.FishInformations.Find(fishId);
            if (fish != null)
            {
                _context.FishInformations.Remove(fish);
                _context.SaveChanges();
                LoadFishData();
            }
        }
    }
}