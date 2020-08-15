using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShopManagementSystem.Models
{
    public class Service
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Tag { get; set; }

        public byte[] Picture { get; set; }



    }
}
