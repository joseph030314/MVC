﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Purchase
    {
        [Required]
        [Column(TypeName = "int")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime PurchaseDateTime { get; set; }
        public Guid PurchaseNumber { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal TotalPrice { get; set; }
    }
}
