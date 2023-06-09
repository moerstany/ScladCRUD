﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScladCRUD.Models
{
    [Table("product1")]
    public partial class Product1
    {
        public Product1()
        {
            Catalog1 = new HashSet<Catalog1>();
            Order1 = new HashSet<Order1>();
        }

        [Key]
        [Column("id_product")]
        public int IdProduct { get; set; }
        [Required]
        [Column("product_name")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        [Column("articul")]
        [StringLength(50)]
        public string Articul { get; set; }
        [Column("cost")]
        public int Cost { get; set; }
        [Column("product_pic")]
        [StringLength(900)]
        public string ProductPic { get; set; }
        [Column("margin")]
        public int Margin { get; set; }

        [InverseProperty("IdProductNavigation")]
        public virtual ICollection<Catalog1> Catalog1 { get; set; }
        [InverseProperty("IdProductNavigation")]
        public virtual ICollection<Order1> Order1 { get; set; }
    }
}