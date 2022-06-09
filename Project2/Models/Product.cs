using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project2.Models
{
    [Keyless]
    [Table("PRODUCTS")]
    public partial class Product
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [Column("NAME_")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("DESCRIPTION_")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("CATEGORYID")]
        public int Categoryid { get; set; }
        [Column("COST")]
        public int? Cost { get; set; }
        [Column("PRICE")]
        public int? Price { get; set; }
        [Column("IMAGE_")]
        [StringLength(50)]
        public string Image { get; set; }

        [ForeignKey(nameof(Categoryid))]
        public virtual Category Category { get; set; }
    }
}
