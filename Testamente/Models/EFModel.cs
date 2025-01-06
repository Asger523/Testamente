using System.ComponentModel.DataAnnotations;

namespace Testamente.Models
{
    public class EFModel
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "HEY! DU HAR GLEMT NAME!!! >:(")]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
