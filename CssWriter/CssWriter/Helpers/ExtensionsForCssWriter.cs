﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CssWriter.Helpers
{
    public static class ExtensionsForCssWriter
    {
        public static CssStatement Css(this string selector, params Func<string, string>[] decdeclarations)
        {
            return new CssStatement
            {
                Selectors = new[] { "H1" },
                Declarations = new Dictionary<string, string> {
                    {"font-size", "12pt" },
                    {"line-height", "10pt" }
                }
            };
        }
    }
}