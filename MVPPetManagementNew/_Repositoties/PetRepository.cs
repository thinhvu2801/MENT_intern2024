using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MVPPetManagement.Models;

namespace MVPPetManagement._Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly PetDbContext _context;

        public PetRepository(PetDbContext context)
        {
            _context = context;
        }

        public void Add(PetModel petModel)
        {
            _context.Pet.Add(petModel);
            _context.SaveChanges();
        }

        public void Delete(int petId)
        {
            var pet = _context.Pet.SingleOrDefault(p => p.Pet_Id == petId);
            if (pet != null)
            {
                _context.Pet.Remove(pet); // Xóa thực thể khỏi DbSet
                _context.SaveChanges();    // Lưu thay đổi vào cơ sở dữ liệu
            }
        }
        //public void Update(PetModel updatedPet)
        //{
        //    var pet = _context.Pet.SingleOrDefault(p => p.Pet_Id == updatedPet.Pet_Id);
        //    if (pet != null)
        //    {
        //        pet.Pet_Name = updatedPet.Pet_Name;
        //        pet.Pet_Type = updatedPet.Pet_Type;
        //        pet.Pet_Colour = updatedPet.Pet_Colour;

        //        _context.SaveChanges(); // Lưu thay đổi
        //    }
        //}
        

        public void Edit(PetModel petModel)
        {
            var existingEntity = _context.Pet.Local.FirstOrDefault(p => p.Pet_Id == petModel.Pet_Id);

            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _context.Pet.Attach(petModel);
            _context.Entry(petModel).State = EntityState.Modified;
            _context.SaveChanges();
        }


        public IEnumerable<PetModel> GetAll()
        {
            return _context.Pet.AsNoTracking().ToList();
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            return _context.Pet
                           .AsNoTracking()
                           .Where(p => p.Pet_Name.Contains(value) || p.Pet_Id.ToString() == value)
                           .ToList();
        }



    }
}