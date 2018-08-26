using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace vuecms.Domains
{
    [Table("LunBo")]
    public class LunBo
    {
        public int Id { get; set; }

        public String Url { get; set; }

        public string Link { get; set; }

        public int Sort { get; set; }
    }
}