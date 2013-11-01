using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Kendo.Data
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("kendo.Node")]
    class Node : Class
    {
        /// <summary>
        /// Appends a new item to the children data source, and initializes it if necessary.
        /// </summary>
        /// <param name="model" type="Object" >The data for the new item</param>
        public void append(object model) { }

        /// <summary>
        /// Gets the current nesting level of the node within the data source.
        /// </summary>
        /// <returns type="Number">the zero based level of the node.</returns>
        public int level() { return 0; }

        /// <summary>
        /// Loads the child nodes in the child data source, supplying the id of the Node to the request.
        /// </summary>
        public void load() { }

        /// <summary>
        /// Gets or sets the loaded flag of the Node. Setting the loaded flag to false allows reloading of child items.
        /// </summary>
        public void loaded() { }

        /// <summary>
        /// Gets the parent node.
        /// </summary>
        /// <returns type="kendo.data.Node">the parent of the node; null if the node is a root node or doesn't have a parent.</returns>
        public Node parentNode() { return null; }

        /// <summary>
        /// Returns a reference to the kendo.data.Node widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.data.Node">The kendo.data.Node instance (if present).</returns>
        public Node GetKendoNode() { return null; }

        /// <summary>
        /// Instantiates a kendo.data.Node widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public void KendoNode(object options) { }
    }
}
