using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

using jQueryApi;

namespace Kendo
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("kendo.View")]
    class View : Class
    {
        /// <summary>
        /// Removes the View element from the DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Renders the view contents. Accepts a jQuery selector (or jQuery object) to which the contents will be appended.
        /// Alternatively, the render method can be called without parameters in order to retrieve the View element for manual insertion/further manipulation.
        /// </summary>
        /// <param name="container" type="jQuery" >(optional) the element in which the view element will be appended.</param>
        /// <returns type="jQuery">the view element.</returns>
        public jQuery render(jQuery container) { return null; }

        /// <summary>
        /// Returns a reference to the kendo.View widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.View">The kendo.View instance (if present).</returns>
        public static View GetKendoView() { return null; }

        /// <summary>
        /// Instantiates a kendo.View widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;tagName — String (default: "div")
        /// &#10;The tag used for the root element of the view.
        /// &#10;
        /// &#10;wrap — Boolean (default: true)
        /// &#10;If set to false, the view will not wrap its contents in a root element. In that case, the view element will point to the root element in the template.
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public void KendoView(object options) { }
    }
}
