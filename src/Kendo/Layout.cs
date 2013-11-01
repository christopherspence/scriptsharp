using System;
using System.Collections.Generic;
using System.Text;

namespace Kendo
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("kendo.Layout")]
    class Layout : Class
    {
        /// <summary>
        /// Renders the View element in the element specified by the selector
        /// </summary>
        /// <param name="container" type="string" >The selector of the container in which the view element will be appended.</param>
        /// <param name="view" type="View" >The view instance that will be rendered.</param>
        public void showIn(string container, View view) { }

        /// <summary>
        /// Returns a reference to the kendo.Layout widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.Layout">The kendo.Layout instance (if present).</returns>
        public void GetKendoLayout() { }

        /// <summary>
        /// Instantiates a kendo.Layout widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public void KendoLayout(object options) { }
    }
}
