using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.ViewModels
{
    public class CustomerFormViewModel 
    {
        //public IEnumerable <MembershipType> MembershipTypes { get; set; }

        
        public int Id { get; set; }

       
        [StringLength(255)]
        [DisplayName("Name *")]
        [Required]
        public string Name { get; set; }

        
        [Required(ErrorMessage ="Please Enter Valid Phone number")]
        [DisplayName("Phone *")]

        public long Phone { get; set; }

        [EmailAddress]
        [Required]
        [DisplayName("Email  *")]

        public string Email { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        //public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage ="Please select at least one membership type")]

        [DisplayName("Membership Type *")]
        public byte MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }

        public MembershipType MembershipType { get; set; }

    }
}