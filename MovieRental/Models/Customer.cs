using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Email { get; set; }
        
        public long Phone { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public virtual MembershipType MembershipType { get; set; }
        [ForeignKey("MembershipType")]
        public byte MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }

    }
}