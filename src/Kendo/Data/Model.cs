using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Data
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.Model")]
    class Model : ObservableObject
    {
        /// <summary>
        /// Determines if the specified field is editable or not.
        /// </summary>
        /// <param name="field" type="String" >The field to check.</param>
        /// <returns type="Boolean">true if the field is editable; false otherwise.</returns>
        public bool editable(string field) { return true; }

        /// <summary>
        /// Checks if the Model is new or not. The id field is used to determine if a model instance is new or existing one.
        /// If the value of the field specified is equal to the default value (specifed through the fields configuration) the model is considered as new.
        /// </summary>
        /// <returns type="Boolean">true if the model is new; false otherwise.</returns>
        public bool isNew() { return true; }

        /// <summary>
        /// Returns a reference to the kendo.data.Model widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.data.Model">The kendo.data.Model instance (if present).</returns>
        public static Model GetKendoModel() { return null; }

        /// <summary>
        /// Instantiates a kendo.data.Model widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoModel(object options) {}
    }
}
