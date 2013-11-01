using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;


namespace Kendo.Mobile.UI
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.mobile.View")]
    class View : Class 
    {
        /// <summary>
        /// Prepares the View for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Retrieves the current content holder of the View - this is the content element if the View is stretched or the scroll container otherwise.
        /// </summary>
        public View contentElement() { return null; }

        /// <summary>
        /// Returns a reference to the kendo.mobile.ui.View widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.mobile.ui.View">The kendo.mobile.ui.View instance (if present).</returns>
        public static View GetKendoView() { return null; }

        /// <summary>
        /// Instantiates a kendo.mobile.ui.View widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;model — String (default: null)
        /// &#10;The MVVM model to bind to. If a string is passed, The view will try to resolve a reference to the view model variable in the global scope.
        /// &#10;
        /// &#10;reload — Boolean (default: false)
        /// &#10;Applicable to remote views only. If set to true, the remote view contents will be reloaded from the server (using Ajax) each time the view is navigated to.
        /// &#10;
        /// &#10;stretch — Boolean (default: false)
        /// &#10;If set to true, the view will stretch its child contents to occupy the entire view, while disabling kinetic scrolling.
        /// &#10;Useful if the view contains an image or a map.
        /// &#10;
        /// &#10;title — String 
        /// &#10;The text to display in the NavBar title (if present) and the browser title.
        /// &#10;
        /// &#10;useNativeScrolling — Boolean (default: false)
        /// &#10;If set to true, the view will use the native scrolling available in the current platform. This should help with form issues on some platforms (namely Android and WP8).
        /// &#10;Native scrolling is only enabled on platforms that support it: iOS > 4, Android > 2, WP8. BlackBerry devices do support it, but the native scroller is flaky.
        /// &#10;
        /// &#10;zoom — Boolean (default: false)
        /// &#10;If set to true, the user can zoom in/out the contents of the view using the pinch/zoom gesture.
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoView() { }
    }
}
