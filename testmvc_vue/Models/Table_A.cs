using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testmvc_vue.Models
{

    //[Table("table_a", Schema ="public")]
    public class Table_A
    {
        //[Column("table_aid")]
        public int table_AID { get; set; }

        //[Column("col1")]
        [Display(Name = "Col1")]
        public string Col1 { get; set; }


        //[Column("col2")]
        [Display(Name = "Col2")]
        public string Col2 { get; set; }


        //[Column("col3")]
        [Display(Name = "Col3")]
        public string Col3 { get; set; }


        //[Column("col4")]
        [Display(Name = "Col4")]
        public string Col4 { get; set; }
    }
}
