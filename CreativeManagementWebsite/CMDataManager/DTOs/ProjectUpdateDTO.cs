using System.ComponentModel.DataAnnotations;

namespace CMDataManager.DTOs
{
    public class ProjectUpdateDTO
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string ProjectType { get; set; }

        [Required]
        public bool FinishedProject { get; set; }
    }
}
