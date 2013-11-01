using System;
using System.Collections.Generic;
using System.Text;

namespace Kendo.Data
{
    class DataSource : Class
    {
        /// <summary>
        /// Appends a data item to the data source.
        /// </summary>
        /// <param name="model" type="Object" >Either a kendo.data.Model instance or JavaScript object containing the data item field values.</param>
        /// <returns type="kendo.data.Model">the data item which is inserted.</returns>
        public void add(object model) { }

        /// <summary>
        /// Gets or sets the aggregate configuration.
        /// </summary>
        /// <param name="value" type="Object" >The aggregate configuration. Accepts the same values as the aggregate option.</param>
        /// <returns type="Array">the current aggregate configuration.</returns>
        public void aggregate(object value) { }

        /// <summary>
        /// Returns the aggregate results.
        /// </summary>
        /// <returns type="Object">the aggregate results. There is a key for every aggregated field.</returns>
        public void aggregates() { }

        /// <summary>
        /// Returns the data item at the specified index. The index is zero-based.
        /// </summary>
        /// <param name="index" type="Number" >The zero-based index of the data item.</param>
        /// <returns type="kendo.data.ObservableObject">the data item at the specified index. Returns undefined if a data item is not found at the specified index.Returns a kendo.data.Model instance if the schema.model option is set.</returns>
        public ObservableObject at(int index) { return null; }

        /// <summary>
        /// Cancels any pending changes in the data source. Deleted data items are restored, new data items are removed and updated data items are restored to their initial state.
        /// </summary>
        /// <param name="model" type="kendo.data.Model" >The optional data item (model). If specified only the changes of this data item will be discarded. If omitted all changes will be discarded.</param>
        public void cancelChanges(Model model) { }

        /// <summary>
        /// Gets or sets the data items of the data source.If the data source is bound to a remote service (via the transport option) the data method will return the service response.
        /// Every item from the response is wrapped in a kendo.data.ObservableObject or kendo.data.Model (if the schema.model option is set).If the data source is bound to a JavaScript array (via the data option) the data method will return the items of that array.
        /// Every item from the array is wrapped in a kendo.data.ObservableObject or kendo.data.Model (if the schema.model option is set).If the data source is grouped (via the group option or the group method) and the serverGrouping is set to true
        /// the data method will return the group items.
        /// </summary>
        /// <param name="value" type="Object" >The data items which will replace the current ones in the data source. If omitted the current data items will be returned.</param>
        /// <returns type="kendo.data.ObservableArray">the data items of the data source. Returns empty array if the data source hasn't been populated with data items via the read, fetch or query methods.</returns>
        public ObservableArray data(object value) { return null; }

        /// <summary>
        /// Reads the data items from a remote service (if the transport option is set) or from a JavaScript array (if the data option is set).
        /// </summary>
        /// <param name="callback" type="Function" >The optional function which is executed when the remote request is finished.  The function context (available via the this keyword) will be set to the data source instance.</param>
        public void fetch(Callback callback) { }

        /// <summary>
        /// Gets or sets the filter configuration.
        /// </summary>
        /// <param name="value" type="Object" >The filter configuration. Accepts the same values as the filter option.</param>
        /// <returns type="Object">the current filter configuration.</returns>
        public object filter(object value) { return null; }

        /// <summary>
        /// Gets the data item (model) with the specified id.
        /// </summary>
        /// <param name="id" type="Object" >The id of the model to look for.</param>
        /// <returns type="kendo.data.Model">the model instance. Returns undefined if a model with the specified id is not found.</returns>
        public Model get(object id) { return null; }

        /// <summary>
        /// Gets the data item (model) with the specified uid.
        /// </summary>
        /// <param name="uid" type="String" >The uid of the model to look for.</param>
        /// <returns type="kendo.data.ObservableObject">the model instance. Returns undefined if a model with the specified uid is not found.</returns>
        public ObservableObject getByUid(string uid) { return null; }

        /// <summary>
        /// Gets or sets the grouping configuration.
        /// </summary>
        /// <param name="value" type="Object" >The grouping configuration. Accepts the same values as the group option.</param>
        /// <returns type="Array">the current grouping configuration.</returns>
        public Array group(object value) { return null; }

        /// <summary>
        /// Cheks if the data itams have changed.
        /// </summary>
        /// <returns type="Boolean">returns true if the data items have changed. Otherwise, false.</
        public bool hasChanges() { return true; }

        /// <summary>
        /// Gets the index of the specified data item.
        /// </summary>
        /// <param name="dataItem" type="kendo.data.ObservableObject" >The target data item.</param>
        /// <returns type="Number">the index of the specified data item. Returns -1 if the data item is not found.</returns>
        public int indexOf(ObservableObject dataITem) { return 0; }

        /// <summary>
        /// Inserts a data item in the data source at the specified index.
        /// </summary>
        /// <param name="index" type="Number" >The zero-based index at which the data item will be inserted.</param>
        /// <param name="model" type="Object" >Either a kendo.data.Model instance or JavaScript object containing the field values.</param>
        /// <returns type="kendo.data.Model">the data item which is inserted.</returns>
        public Model insert(int index, object model) { return null; }

        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        /// <param name="page" type="Number" >The new page.</param>
        /// <returns type="Number">the current page.</returns>
        public int page(int page) { return 0; }

        /// <summary>
        /// Gets or sets the current page size.
        /// </summary>
        /// <param name="size" type="Number" >The new page size.</param>
        /// <returns type="Number">the current page size.</returns>
        public int pageSize(int size) { return 0; }

        /// <summary>
        /// Executes the specified query over the data items. Makes a HTTP request if bound to a remote service.
        /// </summary>
        /// <param name="options" type="" >The query options which should be applied.</param>
        public void query(object options) { }

        /// <summary>
        /// Reads data items from a remote service (if the transport option is set) or from a JavaScript array (if the data option is set).
        /// </summary>
        /// <param name="data" type="Object" >Optional data to pass to the remote service.</param>
        public void read(object data) { }

        /// <summary>
        /// Removes the specified data item from the data source.
        /// </summary>
        /// <param name="model" type="kendo.data.Model" >The data item which should be removed.</param>
        public void remove(Model model) { }

        /// <summary>
        /// Gets or sets the sort order which will be applied over the data items.
        /// </summary>
        /// <param name="value" type="Object" >The sort configuration. Accepts the same values as the sort option.</param>
        /// <returns type="Array">the current sort configuration.</returns>
        public Array sort(object value) { return null; }

        /// <summary>
        /// Saves any data item changes.The sync method will request the remote service if:
        /// </summary>
        public void sync() { }

        /// <summary>
        /// Gets the total number of data items. Uses schema.total if the transport.read option is set.
        /// </summary>
        /// <returns type="Number">the total number of data items. Returns the length of the array returned by the data method if schema.total or transport.read are not set.Returns 0 if the data source hasn't been populated with data items via the read, fetch or query methods.</returns>
        public int total() { return 0;  }

        /// <summary>
        /// Gets the number of available pages.
        /// </summary>
        /// <returns type="Number">the available pages.</returns>
        public int totalPages() { return 0; }

        /// <summary>
        /// Returns the data items which correspond to the current page, filter, sort and group configuration.To ensure that data is available this method should be used within the change event handler or the fetch method.
        /// </summary>
        /// <returns type="kendo.data.ObservableArray">the data items. Returns groups if the data items are grouped (via the group option or the group method).</returns>
        public ObservableArray view() { return null; }

        /// <summary>
        /// Returns a reference to the kendo.data.DataSource widget, instantiated on the selector.
        /// </summary>
        /// <returns type="kendo.data.DataSource">The kendo.data.DataSource instance (if present).</returns>
        public static DataSource GetKendoDataSource() { return null; }

        /// <summary>
        /// Instantiates a kendo.data.DataSource widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// &#10;aggregate — Array 
        /// &#10;The aggregate(s) which are calculated when the data source populates with data. The supported aggregates are "average", "count", "max", "min" and "sum".
        /// &#10;
        /// &#10;autoSync — Boolean (default: false)
        /// &#10;If set to true the data source would automatically save any changed data items by calling the sync method. By default changes are not automatically saved.
        /// &#10;
        /// &#10;batch — Boolean (default: false)
        /// &#10;If set to true the data source will batch CRUD operation requests. For example updating two data items would cause one HTTP request instead of two. By default the data source
        /// &#10;makes a HTTP request for every CRUD operation.
        /// &#10;
        /// &#10;data — Array|String 
        /// &#10;The array of data items which the data source contains. The data source will wrap those items as kendo.data.ObservableObject or kendo.data.Model (if schema.model is set).Can be set to a string value if the schema.type option is set to "xml".
        /// &#10;
        /// &#10;filter — Array|Object 
        /// &#10;The filter(s) which is (are) applied over the data items. By default no filter is applied.
        /// &#10;
        /// &#10;group — Array|Object 
        /// &#10;The grouping configuration of the data source. If set the data items will be grouped when the data source is populated. By default grouping is not applied.
        /// &#10;
        /// &#10;page — Number 
        /// &#10;The page of data which the data source will return when the view method is invoked or request from the remote service.
        /// &#10;
        /// &#10;pageSize — Number 
        /// &#10;The number of data items per page.
        /// &#10;
        /// &#10;schema — Object 
        /// &#10;The configuration used to parse the remote sevice response.
        /// &#10;
        /// &#10;serverAggregates — Boolean (default: false)
        /// &#10;If set to true the data source will leave the aggregate calculation to the remote service. By default the data source calculates aggregates client-side.
        /// &#10;
        /// &#10;serverFiltering — Boolean (default: false)
        /// &#10;If set to true the data source will leave the filtering implementation to the remote service. By default the data source performs filtering client-side.By default the filter is sent to the server following jQuery's conventions.For example the filter { logic: "and", filters: [ { field: "name", operator: "startswith", value: "Jane" } ] } is sent as:Use the parameterMap option to send the filter option in a different format.
        /// &#10;
        /// &#10;serverGrouping — Boolean (default: false)
        /// &#10;If set to true the data source will leave the grouping implementation to the remote service. By default the data source performs grouping client-side.By default the group is sent to the server following jQuery's conventions.For example the group { field: "category", dir: "desc" } is sent as:Use the parameterMap option to send the group option in a different format.
        /// &#10;
        /// &#10;serverPaging — Boolean (default: false)
        /// &#10;If set to true the data source will leave the data item paging implementation to the remote service. By default the data source performs paging client-side.The following options are sent to the server when server paging is enabled:Use the parameterMap option to send the paging options in a different format.
        /// &#10;
        /// &#10;serverSorting — Boolean (default: false)
        /// &#10;If set to true the data source will leave the data item sorting implementation to the remote service. By default the data source performs sorting client-side.By default the sort is sent to the server following jQuery's conventions.For example the sort { field: "age", dir: "desc" } is sent as:Use the parameterMap option to send the paging options in a different format.
        /// &#10;
        /// &#10;sort — Array|Object 
        /// &#10;The sort order which will be applied over the data items. By default the data items are not sorted.
        /// &#10;
        /// &#10;transport — Object 
        /// &#10;The configuration used to load and save the data items. A data source is remote or local based on the way of it retrieves data items.Remote data sources load and save data items from and to a remote end-point (a.k.a. remote service or server). The transport option describes the remote service configuration - URL, HTTP verb, HTTP headers etc.
        /// &#10;The transport option can also be used to implement custom data loading and saving.Local data sources are bound to a JavaScript array via the data option.
        /// &#10;
        /// &#10;type — String 
        /// &#10;If set the data source will use a predefined transport and/or schema. The only supported value is "odata" which supports the OData v.2 protocol.
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoDataSource(object options) { }
    }
}
