using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Data
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.ObservableObject")]
    class ObservableObject : Class
    {
        /// <summary>
        /// Attaches a handler to an event. Examples and more info can be found in the bind section of the
        /// kendo.Observable API reference.
        /// </summary>
        public void bind() { }

        /// <summary>
        /// Gets the value of the specified field.
        /// </summary>
        /// <param name="name" type="String" >The name of the field whose value is going to be returned.</param>
        /// <returns type="Object">the value of the specified field.</returns>
        public object get(string name) { return null; }

        /// <summary>
        /// Gets the parent of the object if such parent exists.
        /// </summary>
        /// <returns type="ObservableObject">the parent of the object; undefined if the object is not nested and doesn't have a parent.</returns>
        public ObservableObject parent() { return null; }

        /// <summary>
        /// Sets the value of the specified field.
        /// </summary>
        /// <param name="name" type="String" >The name of the field whose value is going to be returned.</param>
        /// <param name="value" type="Object" >The new value of the field.</param>
        public void set(string name, object value) { }

        /// <summary>
        /// Creates a plain JavaScript object which contains all fields of the ObservableObject.
        /// </summary>
        /// <returns type="Object">which contains only the fields of the ObservableObject.</returns>
        public object toJSON() { return null; }

        /// <summary>
        /// Returns a reference to the kendo.data.ObservableObject widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.data.ObservableObject">The kendo.data.ObservableObject instance (if present).</returns>
        public static ObservableObject GetKendoObservableObject() { return null; }

        /// <summary>
        /// Instantiates a kendo.data.ObservableObject widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoObservableObject(object options) { }
    }
}
