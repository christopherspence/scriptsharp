// Class1.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;

namespace KendoUI
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("kendo.Class")]
    public class Class
    {
        /// <summary>
        /// Binds to a widget event.
        /// </summary>
        /// <param name="event" type="String">The event name</param>
        /// <param name="callback" type="Callback">The callback to be executed when the event is triggered.</param>
        public void bind(string eventName, Callback callback) {}

        /// <summary>
        /// Unbinds a callback from a widget event.
        /// </summary>
        /// <param name="event" type="String">The event name</param>
        /// <param name="callback" type="Callback">The callback to be removed.</param>
        public void unbind(string eventName, Callback callback) {}

        /// <summary>
        /// Returns a reference to the kendo.Class widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.Class">The kendo.Class instance (if present).</returns>
        [ScriptAlias("$.fn.getKendoClass")]
        public static Class getKendoClass() 
        {
            return null;
        }

        [ScriptAlias("$.fn.kendoClass")]
        public static void kendoClass(object options) { }

    }
}
