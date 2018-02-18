﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prj_Soap.Models
{
    public class Soap
    {
        [Key]
        [StringLength(15)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(250)]
        public string ItemContent { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public bool IsInStock { get; set; }

        public string ImageUrl { get; set; }

        public DateTime UploadTime { get; set; }
    }
}