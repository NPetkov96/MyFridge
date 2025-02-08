﻿using System.ComponentModel.DataAnnotations;

namespace MyFridge.Data.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public double Quantity { get; set; }

        public string? Notes { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
