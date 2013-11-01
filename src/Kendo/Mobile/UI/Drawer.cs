using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Mobile.UI
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.mobile.ui.Drawer")]
    class Drawer : Class
    {
        /// <summary>
        /// Prepares the Drawer for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public void destroy() {}

         /// <summary>
        /// Hide the Drawer
        /// </summary>
        public void hide() {}

        /// <summary>
        /// Show the Drawer
        /// </summary>
        public void show() {}

        /// <summary>
        /// Returns a reference to the kendo.mobile.ui.Drawer widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.mobile.ui.Drawer">The kendo.mobile.ui.Drawer instance (if present).</returns>
        public static Drawer GetKendoDrawer() { return null; }

        /// <summary>
        /// Instantiates a kendo.mobile.ui.Drawer widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;position — String (default: 'left')
        /// &#10;The position of the drawer. Can be left (default) or right.
        /// &#10;
        /// &#10;title — String 
        /// &#10;The text to display in the Navbar title (if present).
        /// &#10;
        /// &#10;views — Array 
        /// &#10;A list of the view ids on which the drawer will appear. If omitted, the drawer can be revealed on any view in the application.
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoDrawer() {}
}
