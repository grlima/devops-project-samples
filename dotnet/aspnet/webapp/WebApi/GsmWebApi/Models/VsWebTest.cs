using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GsmWebApi.Models
{
    public class VsWebTest : WebTest
    {
        public string ConfigXml { get; set; }
        public bool IsRetryEnabled { get; set; }
    }
}