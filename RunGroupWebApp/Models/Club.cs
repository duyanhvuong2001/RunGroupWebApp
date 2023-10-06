using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class Club
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
