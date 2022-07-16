using System.ComponentModel.DataAnnotations;
namespace UniversityAPI.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int ID { get; set; }


        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }

        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedAt { get; set; }

        public Boolean isDeleted { get; set; } = false;
    }
}

