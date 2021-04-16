using System.ComponentModel.DataAnnotations;

namespace CMDataManager.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public string ProjectType { get; set; }

        [Required]
        public bool FinishedProject { get; set; }
    }
}
