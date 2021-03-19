using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testmvc_vue_core.Models
{
    public class TestA
    {

        public int TestAID { get; set; }

        [Display(Name = "Document Code")]
        [Required(ErrorMessage = "DocumentCode_required")]
        [DataType(DataType.Text)]
        [StringLength(15, MinimumLength = 0, ErrorMessage = "DocumentCode_wrong_length")]
        public string DocumentCode { get; set; }
    }
}
