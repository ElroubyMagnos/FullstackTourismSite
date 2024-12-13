using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boardingdata.Models
{
    public class Travel
    {
        public int ID {get;set;}
        public byte[] Image {get;set;}
        public string City {get;set;}
        public string Country {get;set;}
        public string Desc {get;set;}
    }
}