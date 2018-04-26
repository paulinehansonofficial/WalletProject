using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DigWalProj.Models
{
    public class Advertisement
    {
        [Key]
        public int adId { get; set; }

        public string projectId { get; set; }

        public string adName { get; set; }

        public string adDescription { get; set; }
    }
}
