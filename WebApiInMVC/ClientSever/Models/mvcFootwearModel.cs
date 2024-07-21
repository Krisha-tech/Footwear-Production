using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientSever.Models
{
    public class mvcFootwearModel
    {
        public int FootwearID { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string FootwearCetogory { get; set; }
        public string FootwearType { get; set; }
        public string FootwearBrand { get; set; }
        public Nullable<int> Price { get; set; }
    }
}