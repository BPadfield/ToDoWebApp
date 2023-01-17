using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ToDoWebApp.Models;

namespace todo.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [StringLength(150, MinimumLength = 3)]
        [Required]
        public string? Description { get; set; }
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DateDue { get; set; }
        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        = DateTime.Now;

        //Foreign Key
        //[Required]
        public ToDoUser? IdentityUser { get; set; }
    }
}
