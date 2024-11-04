using System.Collections.Generic;
using MVPPetManagement.Models;

namespace MVPPetManagement._Repositories
{
    public interface IPetRepository
    {
        // Lấy tất cả các thú cưng
        IEnumerable<PetModel> GetAll(); 

        // Lấy thú cưng theo giá trị (Id hoặc tên)
        IEnumerable<PetModel> GetByValue(string value);

        // Thêm thú cưng mới
        void Add(PetModel petModel);

        // Sửa thông tin thú cưng
        void Edit(PetModel petModel);

        // Xóa thú cưng theo Id
        void Delete(int id);
    }
}
