using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Data
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.data.SchedulerEvent")]
    class SchedulerEvent : Class 
    {
        /// <summary>
        /// Returns a reference to the kendo.data.SchedulerEvent widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.data.SchedulerEvent">The kendo.data.SchedulerEvent instance (if present).</returns>
        public static SchedulerEvent GetKendoSchedulerEvent() { return null; }

        /// <summary>
        /// Instantiates a kendo.data.SchedulerEvent widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;description — String (default: "")
        /// &#10;The optional event description.
        /// &#10;
        /// &#10;end — Date 
        /// &#10;The date at which the scheduler event ends. The end date is mandatory.
        /// &#10;
        /// &#10;endTimezone — String (default: undefined)
        /// &#10;The timezone of the end date. If not specified the timezone will be used.The complete list of the supported timezones is available in the List of IANA time zones Wikipedia page.
        /// &#10;
        /// &#10;id — String|Number|Object 
        /// &#10;The mandatory unique identifier of the event.
        /// &#10;
        /// &#10;isAllDay — Boolean (default: false)
        /// &#10;If set to true the event is "all day". By default events are not all day.
        /// &#10;
        /// &#10;recurrenceException — String (default: undefined)
        /// &#10;The recurrence exceptions. A list of colon separated dates formatted using the yyyyMMddTHHmmssZ format string.
        /// &#10;
        /// &#10;recurrenceId — String|Number|Object (default: undefined)
        /// &#10;The id of the recurrence parent event. Required for events that are recurrence exceptions.
        /// &#10;
        /// &#10;recurrenceRule — String (default: undefined)
        /// &#10;The recurrence rule describing the recurring pattern of the event. The format follows the iCal specification.
        /// &#10;
        /// &#10;start — Date 
        /// &#10;The date at which the scheduler event starts. The start date is mandatory.
        /// &#10;
        /// &#10;startTimezone — String (default: undefined)
        /// &#10;The timezone of the start date. If not specified the timezone will be used.The complete list of the supported timezones is available in the List of IANA time zones Wikipedia page.
        /// &#10;
        /// &#10;title — String (default: "")
        /// &#10;The title of the event which is displayed by the scheduler widget.
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void SchedulerEvent() { }
    }
}
