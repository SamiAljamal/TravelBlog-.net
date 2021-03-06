﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Location
    {
       
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<PersonLocation> PersonLocations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }

    }
}
