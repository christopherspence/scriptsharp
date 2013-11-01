using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Data
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.data.ObservableArray")]
    class ObservableArray : Class
    {
        /// <summary>
        /// Attaches an event handler for the specified event.
        /// </summary>
        /// <param name="eventName" type="String" >The name of the event.</param>
        /// <param name="handler" type="Function" >The function which will be invoked when the event is raised.</param>
        public void bind(string eventName, Callback handler) { }

        /// <summary>
        /// Joins all items of an ObservableArray into a string. Equivalent of
        /// Array.prototype.join.
        /// </summary>
        /// <param name="separator" type="String" >Specifies the string to separate each item of the array. If omitted the array items are separated with a comma (,)</param>
        public string join(string separator) { return null; }
        
        /// <summary>
        /// Gets the parent of the array if such parent exists.
        /// </summary>
        /// <returns type="kendo.data.ObservableObject">the parent of the array; undefined if the array is not nested and doesn't have a parent.</returns>
        public ObservableObject parent() { return null; }

        /// <summary>
        /// Removes the last item from an array and returns that item. Equivalent of Array.prototype.pop.
        /// </summary>
        /// <returns type="Object">the item which was removed.</returns>
        public object pop() { return null; }

        /// <summary>
        /// Appends the given items to the array and returns the new length of the array. Equivalent of Array.prototype.push.
        /// The new items are wrapped as ObservableObject if they are complex objects.
        /// </summary>
        /// <returns type="Number">the new length of the array.</returns>
        public int push() { return 0; }

        /// <summary>
        /// Returns a one-level deep copy of a portion of an array. Equivalent of
        /// Array.prototype.slice.
        /// The result of the slice method is not an instance of ObvservableArray. It is a regular JavaScript Array object.
        /// </summary>
        /// <param name="begin" type="Number" >Zero-based index at which to begin extraction.</param>
        /// <param name="end" type="Number" >Zero-based index at which to end extraction. If end is omitted, slice extracts to the end of the sequence.</param>
        public Array slice(int begin, int end) { return null; }

        /// <summary>
        /// Changes an ObservableArray, by adding new items while removing old items. Equivalent of
        /// Array.prototype.splice
        /// </summary>
        /// <param name="index" type="Number" >Index at which to start changing the array. If negative, will begin that many elements from the end.</param>
        /// <param name="howMany" type="Number" >An integer indicating the number of items to remove. If set to 0, no items are removed. In this case, you should specify at least one new item.</param>
        /// <returns type="Array">containing the removed items. The result of the splice method is not an instance of ObvservableArray.</returns>
        public Array splice(int index, int howMany) { return null; }

        /// <summary>
        /// Removes the first item from an ObvservableArray and returns that item. Equivalent of Array.prototype.shift.
        /// </summary>
        /// <returns type="Object">the item which was removed.</returns>
        public object shift() { return null; }

        /// <summary>
        /// Returns a JavaScript Array which represents the contents of the ObservableArray.
        /// </summary>
        public Array toJSON() { return null; }

        /// <summary>
        /// Adds one or more items to the beginning of an ObservableArray and returns the new length.  Equivalent of Array.prototype.unshift.
        /// </summary>
        /// <returns type="Number">the new length of the array.</returns>
        public int unshift() { return 0; }

        /// <summary>
        /// Returns a reference to the kendo.data.ObservableArray widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.data.ObservableArray">The kendo.data.ObservableArray instance (if present).</returns>
        public static ObservableArray GetKendoObservableArray() { return null; }

        /// <summary>
        /// Instantiates a kendo.data.ObservableArray widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoObservableArray(object options) { }

    }
}
