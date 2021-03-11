using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testmvc_vue.Models
{
    public class Table_B
    {
        public int table_BID { get; set; }

        [Display(Name = "Col1")]
        public string Col1 { get; set; }


        [Display(Name = "Col2")]
        public string Col2 { get; set; }


        [Display(Name = "Col3")]
        public string Col3 { get; set; }


        [Display(Name = "Col4")]
        public string Col4 { get; set; }
    }
}



