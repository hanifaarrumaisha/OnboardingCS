﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCS.DTO
{
    public class TodoItemDTO
    {
        public Guid TodoId { get; set; }
        [Required]
        public string TodoName { get; set; }
        public bool TodoIsDone { get; set; }
    }
}
