﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScladCRUD.Models
{
    [Table("catalog1")]
    public partial class Catalog1
    {
        [Key]
        [Column("id_catalog")]
        public int IdCatalog { get; set; }
        
       
        [Column("price")]
        public int Price { get; set; }

        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }

        [ForeignKey("Product1")]
        [Column("id_product")]
        public int? IdProduct { get; set; }

        [InverseProperty("Catalog1")]
        public virtual Product1 IdProductNavigation { get; set; }
        public Product1 Product1 { get; set; }
    }
}