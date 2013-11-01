using System;
using System.Collections.Generic;
using System.Text;

namespace Kendo
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("kendo.FX")]
    class FX : Class
    {
        /// <summary>
        /// Applies the specified animation effect/s to all selected elements and triggers the callback on every element when it completes its animation.
        /// Uses transitions and transformations where available and falls back to jQuery animate where not. kendoAnimate can be used to run one of the provided
        /// animation effects or you can define one yourself, using the same format.
        /// </summary>
        /// <param name="duration" type="bool" >The effect duration (speed) in milliseconds.</param>
        /// <param name="reverse" type="bool" >Whether the effect should play backwards, useful when doing the same animation but with the opposite direction, like opening and closing.</param>
        /// <param name="complete" type="Callback" >Completion callback that should be called after animation completion. It gets fired for every animated element and is passed the said element as its only argument.</param>
        /// <param name="show" type="bool" >Whether the element should be shown before animating.</param>
        /// <param name="hide" type="bool" >Whether the element should be hidden after the animation completes.</param>
        public void kendoAnimate(int duration, bool reverse, Callback complete, bool show, bool hide) { }
        
        /// <summary>
        /// Stops the animation effect running on the specified elements and optionally jumps to the end and clears the animation effect queue.
        /// In browsers that don't support transitions falls back to jQuery stop().This functionality is useful to avoid chaining many effects, causing them to run longer than expected.
        /// </summary>
        /// <param name="gotoEnd" type="bool" >Whether to jump to the animation end position when stopping or just leave the element at its current position.</param>
        public void kendoStop(bool gotoEnd) { }

        /// <summary>
        /// Adds a CSS class to the element, while doing a transition to the new state. If the browser doesn't support transitions,
        /// the method falls back to jQuery addClass();
        /// </summary>
        /// <param name="classes" type="String" >A list of the classes that should be added to the element/s, separated by a space.</param>
        /// <param name="options" type="" >An object containing several additional options, like duration and exclusive.</param>
        public void kendoAddClass(string classes, object options) { }

        /// <summary>
        /// Removes a CSS class from the element, while doing a transition to the new state. If the browser doesn't support transitions,
        /// the method falls back to jQuery removeClass();
        /// </summary>
        /// <param name="classes" type="String" >A list of the classes that should be removed from the element/s, separated by a space.</param>
        /// <param name="options" type="" >An object containing several additional options, like duration and exclusive.</param>
        public void kendoRemoveClass(string classes, object options) { }

        /// <summary>
        /// Toggle a CSS class on the element, based on a flag, while doing a transition to the new state. If the browser doesn't support transitions,
        /// the method falls back to jQuery toggleClass();
        /// </summary>
        /// <param name="classes" type="String" >A list of the classes that should be toggled on the element/s, separated by a space.</param>
        /// <param name="options" type="" >An object containing several additional options, like duration and exclusive.</param>
        /// <param name="toggle" type="Boolean" >A boolean flag to control the toggle - true to add or false to remove the CSS class. If omitted the method will assume the opposite state should be toggled.</param>
        public void kendoToggleClass(string classes, object options, bool toggle) { }

        /// <summary>
        /// Returns a reference to the FX widget, instantiated on the selector.
        /// </summary>
        /// <returns type="FX">The FX instance (if present).</returns>
        public static FX GetKendoFX() { return null; }

        /// <summary>
        /// Instantiates a FX widget based the DOM elements that match the selector.

        /// &#10;Accepts an object with the following configuration options:
        /// &#10;
        /// </summary>
        /// <param name="options" type="Object">
        /// The widget configuration options
        /// </param>
        public static void KendoFX(object options) { }
    }
}
