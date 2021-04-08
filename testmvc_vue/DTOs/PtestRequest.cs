using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testmvc_vue.DTOs
{
    public class PtestRequest
    {
        public int table_BID { get; set; }

        [Required]
        public string Col1 { get; set; }

        public string Col2 { get; set; }

        public string Col3 { get; set; }

        public string Col4 { get; set; }
    }
}
