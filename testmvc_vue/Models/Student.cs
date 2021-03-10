using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace testmvc_vue.Models
{
    public class Student
    {


        public int StudentId { get; set; }

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Score")]
        public int Score { get; set; }


        [Display(Name = "SchoolId")]
        [DataType(DataType.Text)]
        public string SchoolId { get; set; }


        [Display(Name = "School")]
        [DataType(DataType.Text)]
        public string School { get; set; }




    }
}
