using System;
using System.ComponentModel.DataAnnotations;

namespace TheContactManagerApp.Models
{
    public class Manager
    {
        // EF Core will configure the database to generate this value
        public int ManagerId { get; set; }
       
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter a name.")] 
        public string? FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter a name.")]
        public string? LastName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter a phone number.")]
        public string? PhoneNum { get; set; }
       
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter an email.")]
        public string? Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter a category.")]
        // foreign key
        [Range(1, 100000000, ErrorMessage = "Please select a category.")] // make sure value is greater than zero
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
