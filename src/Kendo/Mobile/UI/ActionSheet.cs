using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

using jQueryApi;

namespace Kendo.Mobile.UI
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.mobile.ui.ActionSheet")]
    class ActionSheet : Class
    {
        /// <summary>
        /// Close the ActionSheet.
        /// </summary>
        public void close() { }

        /// <summary>
        /// Prepares the ActionSheet for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Open the ActionSheet.
        /// </summary>
        /// <param name="target" type="jQuery" >(optional) The target element of the ActionSheet, available in the callback methods.Notice The target element is mandatory on tablets, as the ActionSheet widget positions itself relative to opening element when a tablet is detected.</param>
        /// <param name="context" type="Object" >(optional) The context of the ActionSheet, available in the callback methods.</param>
        public void open(jQuery target, object context) { }

        /// <summary>
        /// Returns a reference to the kendo.mobile.ui.ActionSheet widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.mobile.ui.ActionSheet">The kendo.mobile.ui.ActionSheet instance (if present).</returns>
        public ActionSheet GetKendoActionSheet() { return null; }

        /// <summary>
        /// Instantiates a kendo.mobile.ui.ActionSheet widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;cancel — String (default: "Cancel")
        /// &#10;The text of the cancel button.
        /// &#10;
        /// &#10;popup — Object 
        /// &#10;The popup configuration options (tablet only).
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public void KendoActionSheet() { }
    }
}
