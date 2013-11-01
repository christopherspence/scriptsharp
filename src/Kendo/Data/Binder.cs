using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Data
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.Binder")]
    class Binder : Class
    {
        /// <summary>
        /// Invoked by the Kendo UI MVVM framework when the bound view model value is changed. The binder should update the UI (HTML element or Kendo UI widget) to reflect the view model change.
        /// </summary>
        public void refresh() { }

        /// <summary>
        /// Returns a reference to the kendo.data.Binder widget, instantiated on the selector.
        /// </summary>
        /// <returns type="Binder">The kendo.data.Binder instance (if present).</returns>
        public static Binder GetKendoBinder() { return null; }

        /// <summary>
        /// Instantiates a kendo.data.Binder widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoBinder() { }
    }
}
