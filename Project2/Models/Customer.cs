using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project2.Models
{
    [Table("CUSTOMERS")]
    public partial class Customer
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("FIRSTNAME")]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [Column("LASTNAME")]
        [StringLength(50)]
        public string Lastname { get; set; }
    }
}
