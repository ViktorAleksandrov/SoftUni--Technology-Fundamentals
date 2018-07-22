﻿namespace TodoList.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        public string Comments { get; set; }
    }
}