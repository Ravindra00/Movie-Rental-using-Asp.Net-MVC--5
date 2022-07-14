using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Phone]
        [Required]
        public int Phone { get; set; }
    }
}