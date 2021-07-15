﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCS.Models
{
    public class Label
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LabelId { get; set; }
        [Required]
        public string LabelName { get; set; }
        //public List<TodoItem> Todos { get; set; } // ini bikin error LabelId ga ada di TodoItem
    }
}
