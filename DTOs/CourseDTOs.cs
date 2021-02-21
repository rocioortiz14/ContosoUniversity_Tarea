﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ContosoUniversity.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.DTOs
{
    public class CourseDTOs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }


        [Required(ErrorMessage = "The Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }


        [Required(ErrorMessage = "The Credits is required")]
        [Display(Name = "Credits")]
        public int Credits { get; set; }

      
    }
}
