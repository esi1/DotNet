﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.ComponentModel;

namespace Memberships.Entities
{
   
        [Table("Item")]
        public class Item
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [MaxLength(255)]
            [Required]
            public string Title { get; set; }
            [MaxLength(2048)]
            public string Description { get; set; }
            [MaxLength(1024)]
            public string Url { get; set; }
            [MaxLength(1024)]
            public string ImageUrl { get; set; }
            [AllowHtml]
            public string HTML { get; set; }
            [DefaultValue(0)]
            public int WaitDays { get; set; }
            public string HTMLShort
            {
                get {
                    return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50);
                        }
            }
            public int ItemTypeId { get; set; }
            public int SectionId { get; set; }
            public int PartId { get; set; }
            public bool IsFree { get; set; }
            [DisplayName("Item Types")]
            public ICollection<ItemType> ItemTypes { get; set; }
            [DisplayName("Sections")]
            public ICollection<Section> Sections { get; set; }
            [DisplayName("Parts")]
            public ICollection<Part> Parts { get; set; }

        [NotMapped]
        public string Disabled { get {
                return (ItemTypes == null || ItemTypes.Count <= 0) || 
                          (Sections == null ||  Sections.Count <= 0 ) || 
                          (Parts == null || Parts.Count <= 0 ) ? "disabled" : "";
            } }
    }
}