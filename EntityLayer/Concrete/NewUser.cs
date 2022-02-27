using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class NewUser
    {
        [Key]
        public int NewUserID { get; set; }
        public string NewUserName { get; set; }
        public string NewUserSurname { get; set; }
        public int NewUserPhoneNumber { get; set; }
        public string NewUserMail { get; set; }
        public string NewUserPassword { get; set; }
        public string NewUserImage { get; set; }
        public string NewUserComment { get; set; }
        public bool NewUserStatus { get; set; }

        


    }
}
