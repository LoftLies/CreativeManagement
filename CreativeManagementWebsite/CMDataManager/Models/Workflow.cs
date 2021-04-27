using System.ComponentModel.DataAnnotations;

namespace CMDataManager.Models
{
    public class Workflow
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Project ParentProject { get; set; }

    }
}
