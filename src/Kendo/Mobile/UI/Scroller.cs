using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Mobile.UI
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.mobile.ui.Scroller")]
    class Scroller : Class
    {
        /// <summary>
        /// Prepares the Scroller for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Disables the scrolling of the element.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enables the scrolling of the element after it has been disabled by calling disable.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// Returns the viewport height of the scrollable element.
        /// </summary>
        /// <returns type="Number">the viewport height in pixels.</returns>
        public int height() { return 0; }

        /// <summary>
        /// Indicate that the pull event is handled (i.e. data from the server has been retrieved).
        /// </summary>
        public void pullHandled() {}

        /// <summary>
        /// Scrolls the container to the top.
        /// </summary>
        public void reset() {}

        /// <summary>
        /// Returns the height in pixels of the scroller content.
        /// </summary>
        public int scrollHeight() { return 0;  }

        /// <summary>
        /// Scrolls the container to the specified location. The arguments should be negative numbers.
        /// </summary>
        /// <param name="x" type="Number" >The horizontal offset in pixels to scroll to.</param>
        /// <param name="y" type="Number" >The vertical offset in pixels to scroll to.</param>
        public void scrollTo(int x, int y) { }

        /// <summary>
        /// Returns the width in pixels of the scroller content.
        /// </summary>
        public int scrollWidth() { return 0; }

         /// <summary>
        /// Returns a reference to the kendo.mobile.ui.Scroller widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.mobile.ui.Scroller">The kendo.mobile.ui.Scroller instance (if present).</returns>
        public Scroller GetKendoScroller() { return null; }

        /// <summary>
        /// Instantiates a kendo.mobile.ui.Scroller widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;zoom — Boolean (default: false)
        /// &#10;If set to true, the user can zoom in/out the contents of the widget using the pinch/zoom gesture.
        /// &#10;
        /// &#10;elastic — Boolean (default: true)
        /// &#10;Weather or not to allow out of bounds dragging and easing.
        /// &#10;
        /// &#10;pullOffset — Number (default: 140)
        /// &#10;The threshold below which a releasing the scroller will trigger the pull event.
        /// &#10;Has effect only when the pullToRefresh option is set to true.
        /// &#10;
        /// &#10;pullTemplate — String (default: "Pull to refresh")
        /// &#10;The message template displayed when the user pulls the scroller.
        /// &#10;Has effect only when the pullToRefresh option is set to true.
        /// &#10;
        /// &#10;pullToRefresh — Boolean (default: false)
        /// &#10;If set to true, the scroller will display a hint when the user pulls the container beyond its top limit.
        /// &#10;If a pull beyond the specified pullOffset occurs, a pull event will be triggered.
        /// &#10;
        /// &#10;refreshTemplate — String (default: "Refreshing")
        /// &#10;The message template displayed during the refresh.
        /// &#10;Has effect only when the pullToRefresh option is set to true.
        /// &#10;
        /// &#10;releaseTemplate — String (default: "Release to refresh")
        /// &#10;The message template displayed when the user pulls the scroller below the pullOffset, indicating that pullToRefresh will occur.
        /// &#10;Has effect only when the pullToRefresh option is set to true.
        /// &#10;
        /// &#10;useNative — Boolean (default: false)
        /// &#10;If set to true, the scroller will use the native scrolling available in the current platform. This should help with form issues on some platforms (namely Android and WP8).
        /// &#10;Native scrolling is only enabled on platforms that support it: iOS > 4, Android > 2, WP8. BlackBerry devices do support it, but the native scroller is flaky.
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public void KendoScroller() { }
    }
}
