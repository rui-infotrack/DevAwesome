using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.DevAwesome.Models
{
    public class Login
    {
        [Column("LoginId")]
        [Key]
        public int Id { get; set; }

        public ICollection<LoginRole> LoginRoles { get; set; }
    }
}
