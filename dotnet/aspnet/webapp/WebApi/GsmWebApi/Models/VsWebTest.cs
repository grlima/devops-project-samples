using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GsmWebApi.Models
{
    public class VsWebTest : WebTest
    {
        [Required]
        public string ConfigXml { get; set; }
        public bool IsRetryEnabled { get; set; }
    }
}