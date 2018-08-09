using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAMHS.UI.Models
{
    public class User
    {
        public int User_id { get; set; }

        public string User_name { get; set; }

        public int User_type { get; set; }

        public string User_password { get; set; }

        public string User_email { get; set; }

        public string User_secure_question_1 { get; set; }

        public string User_secure_question_2 { get; set; }

        public string User_secure_question_3 { get; set; }

    }
}