﻿using System.ComponentModel.DataAnnotations;

namespace Demo_pr.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 8)]
        public string? SubjectName { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 2)]
        public string? SubjectCode { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        public virtual List<Exam>? Exams { get; set; }
    }
}
