using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boardingdata.Models
{
    public class HeaderSliderImage
    {
        public int ID {get;set;}
        public byte[] Image {get;set;}
        public string Title {get;set;}
        public string Desc {get;set;}
    }
}