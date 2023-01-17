using Microsoft.AspNetCore.Identity;

namespace ToDoWebApp.Models

{
    public class ToDoUser : IdentityUser
    {
        public string? FirstName { get; set; }  
        public string? LastName { get; set;}

    }
}
