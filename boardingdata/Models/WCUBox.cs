using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace boardingdata.Models
{
    public class WCUBox
    {
        public int ID {get;set;}
        [MaxLength(50)]
        public string Title {get;set;}
        [MaxLength(500)]
        public string Desc {get;set;}
        public string IconIDFA {get;set;}
    }
}