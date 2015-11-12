using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.DevAwesome.Models
{
    public class Retailer
    {
        [Column("RetailerId")]
        [Key]
        public int Id { get; set; }

        public ICollection<RetailerRole> RetailerRoles { get; set; }
    }
}
