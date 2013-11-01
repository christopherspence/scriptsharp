using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Mobile.UI
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.mobile.ui.Button")]
    class Button : Class
    {
        [ScriptName("badge")]
        [ScriptField]
        public int badge
        {
            get { return 0; }
            set { }
        }

        /// <summary>
        /// Prepares the Button for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Returns a reference to the kendo.mobile.ui.Button widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.mobile.ui.Button">The kendo.mobile.ui.Button instance (if present).</returns>
        public static Button GetKendoButton() { return null; }

        /// <summary>
        /// Instantiates a kendo.mobile.ui.Button widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;badge — String 
        /// &#10;The badge of the button.
        /// &#10;
        /// &#10;icon — String 
        /// &#10;The icon of the button. It can be either one of the built-in icons, or a custom one.
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoButton() { }
    }
}
