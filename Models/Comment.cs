﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OWEBAPI.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName ="nvarchar(1000)")]
        public string content { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime date { get; set; }
    }
}
