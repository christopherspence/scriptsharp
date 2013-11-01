using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("Kendo.Router")]
    class Router : Class
    {
        /// <summary>
        /// Activates the router binding to the URL fragment part changes.
        /// </summary>
        public void start() { }

        /// <summary>
        /// 
        /// </summary>
        public void Example() { }

        /// <summary>
        /// Specifies a callback for the given route. The route definition can contain bound parameters, optional segments, and route globbing.
        /// The parsed parts of the URL are passed as parameters to the route callback.
        /// </summary>
        /// <param name="route" type="String" >The route definition.</param>
        /// <param name="callback" type="Callback" >The callback to be executed when the route is matched.</param>
        public void route(string route, Callback callback) { }

        /// <summary>
        /// Navigates to the given route.
        /// </summary>
        /// <param name="route" type="String" >The route to navigate to.</param>
        /// <param name="silent" type="Boolean" >If set to true, the router callbacks will not be called.</param>
        public void navigate(string route, bool silent) { }

        /// <summary>
        /// Unbinds the router instance listeners from the URL fragment part changes.
        /// </summary>
        public void destroy() { }

         /// <summary>
        /// Returns a reference to the kendo.Router widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.Router">The kendo.Router instance (if present).</returns>
        public static Router GetKendoRouter() { return null; }

        /// <summary>
        /// Instantiates a kendo.Router widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public void KendoRouter(object options) {}
    }
}
