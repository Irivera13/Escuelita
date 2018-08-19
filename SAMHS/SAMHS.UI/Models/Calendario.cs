using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAMHS.UI.Models
{
    public class Calendario
    {

        public int EventID { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime? end { get; set; }

        public string ThemeColor { get; set; }

        public bool IsFullDay { get; set; }

    }
}