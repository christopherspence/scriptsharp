using System;
using System.Collections.Generic;
using System.Text;

namespace Kendo
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("kendo.Observable")]
    class Observable : Class
    {
        /// <summary>
        /// Attaches a handler to an event. The handler is executed only once.
        /// </summary>
        /// <param name="eventName" type="String" >The name of the event.</param>
        /// <param name="handler" type="Function" >A function to execute each time the event is triggered. That function should have a single parameter which will contain any event specific data.</param>
        public void one(string eventName, Callback handler) { }

        /// <summary>
        /// Executes all handlers attached to the given event.
        /// </summary>
        /// <param name="eventName" type="String" >The name of the event to trigger.</param>
        /// <param name="eventData" type="Object" >Optional event data which will be passed as an argument to the event handlers.</param>
        public void trigger(string eventName, object eventData) { }

        /// <summary>
        /// Returns a reference to the kendo.Observable widget, instantiated on the selector.
        /// </summary>
        /// <returns type="Observable">The kendo.Observable instance (if present).</returns>
        public static Observable GetKendoObservable() { return null; }

        /// <summary>
        /// Instantiates a kendo.Observable widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoObservable() { }
    }
}
