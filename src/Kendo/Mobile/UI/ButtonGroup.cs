using System;
using System.Collections.Generic;
using System.Text;

using jQueryApi;

namespace Kendo.Mobile.UI
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.mobile.ui.ButtonGroup")]
    class ButtonGroup : Class
    {
        /// <summary>
        /// Introduced in Q1 2013 SP Sets a badge on one of the ButtonGroup buttons with the specified value. If invoked without parameters, returns the button's current badge value. Set the value to false to remove the badge.
        /// </summary>
        /// <param name="button" type="Object" >The target button specified either as a jQuery selector/object or as an button index.</param>
        /// <param name="value" type="Object" >The target value to be set or false to be removed.</param>
        /// <returns type="String|kendo.mobile.ui.Button">the badge value if invoked without parameters, otherwise the ButtonGroup object.</returns>
        public int badge(object button, object value) { return 0; }

        /// <summary>
        /// Get the currently selected Button.
        /// </summary>
        /// <returns type="jQuery">the jQuery object representing the currently selected button.</returns>
        public jQuery current() { return 0; }

        /// <summary>
        /// Prepares the ButtonGroup for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Select a Button.
        /// </summary>
        /// <param name="li" type="Object" >LI element or index of the Button.</param>
        public void select(object li) { }

        /// <summary>
        /// Returns a reference to the kendo.mobile.ui.ButtonGroup widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.mobile.ui.ButtonGroup">The kendo.mobile.ui.ButtonGroup instance (if present).</returns>
        public static ButtonGroup GetKendoButtonGroup() { return null; }

        /// <summary>
        /// Instantiates a kendo.mobile.ui.ButtonGroup widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;index — Number 
        /// &#10;Defines the initially selected Button (zero based index).
        /// &#10;
        /// &#10;selectOn — String (default: default "down")
        /// &#10;Sets the DOM event used to select the button. Accepts "up" as an alias for touchend, mouseup and MSPointerUp vendor specific events.By default, buttons are selected immediately after the user presses the button (on touchstart or mousedown or MSPointerDown, depending on the mobile device).
        /// &#10;However, if the widget is placed in a scrollable view, the user may accidentally press the button when scrolling. In such cases, it is recommended to set this option to "up".
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public void KendoButtonGroup() { }
    }
}
