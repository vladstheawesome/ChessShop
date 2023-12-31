﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ChessShop.Models
{
    public class Category
    {
        [Key]
        public Guid categoryid { get; set; }

        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Display Order")] //Note: CodeLens disabled
        public int displayorder { get; set; }
        
        public decimal code { get; set; }

        public Guid? lastuser { get; set; }

        [StringLength(50)]
        public string lastusername { get; set; }

        public DateTime createdtime { get; set; }

        public DateTime modifiedtime { get; set; }
        public decimal inuse { get; set; }
    }
}
