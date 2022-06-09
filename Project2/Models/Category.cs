using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project2.Models
{
    [Table("CATEGORIES")]
    public partial class Category
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
