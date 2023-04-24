﻿using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string? Name { get; set; }
        [Required]
        [StringLength(30)]
        public string? Email { get; set; }

        public List<UserGenre> UserGenres { get; set; }
    }
}
