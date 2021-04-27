using System.ComponentModel.DataAnnotations;

namespace CMDataManager.Models
{
    public class Step
    {
        [Key]
        public int Id { get; set; }

        public Workflow UsedInWorfklow { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public StepState StateOfStep { get; set; }
    }

    public enum StepState
    {
        ToDo,
        Doing,
        Done,
        Skipped
    }
}
