using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("kendo.Color")]
    class Color : Class
    {
        /// <summary>
        /// Computes the relative luminance between two colors.
        /// </summary>
        /// <returns type="int">The relative luminance.</returns>
        public int diff() { return 0; }

        /// <summary>
        /// Compares two color objects for equality.
        /// </summary>
        /// <returns type="bool">returns true if the two colors are the same. Otherwise, false</returns>
        public bool equals() { return true; }

        [ScriptAlias("$.fn.getKendoColor")]
        public static Color GetKendoColor() { return null; }

        [ScriptAlias("$.fn.kendoColor")]
        public static void KendoColor(object options) { }
    }
}
