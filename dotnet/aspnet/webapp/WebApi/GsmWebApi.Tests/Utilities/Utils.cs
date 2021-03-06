﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GsmWebApi.Tests.Utilities
{
    public static class Utils
    {
        public static string GetFileContents(string fileName)
        {
            var asm = Assembly.GetExecutingAssembly();
            var resource = string.Format("GsmWebApi.Tests.TestData.{0}", fileName);
            using (var stream = asm.GetManifestResourceStream(resource))
            {
                if (stream != null)
                {
                    var reader = new StreamReader(stream);
                    return reader.ReadToEnd();
                }
            }

            throw new Exception(string.Format("Could not retrieve resource {0}", resource));
        }
    }
}
