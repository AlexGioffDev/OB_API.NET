using System.ComponentModel.DataAnnotations;
namespace UniversityAPI.Models.DataModels
{

    public enum Level
    {
        Basic,
        Medium,
        Advanced
    }

    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string? Name { get; set; }

        [StringLength(280)]
        public string? ShortDescription { get; set; }

        public string? Description { get; set; }

        public string? PublicObjective { get; set; }

        
        public string Ojectivo { get; set; }

        public string Requirments { get; set; }

        public Level Level { get; set; } = Level.Basic;

    }
}

