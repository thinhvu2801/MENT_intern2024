using System.ComponentModel.DataAnnotations;

namespace MVPPetManagement.Models
{
    public class PetModel
    {
        [Key]
        public int Pet_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Pet_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Pet_Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Pet_Colour { get; set; }
    }
}
