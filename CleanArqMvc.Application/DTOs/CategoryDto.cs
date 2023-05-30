﻿using System.ComponentModel.DataAnnotations;

namespace CleanArqMvc.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

    }
}
