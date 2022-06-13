using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Models
{
    public class MemberEditVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string ImgURL { get; set; }
    }
}
