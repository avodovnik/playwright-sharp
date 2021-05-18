/*
 * MIT License
 *
 * Copyright (c) Microsoft Corporation.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 *
 * ------------------------------------------------------------------------------ 
 * <auto-generated> 
 * This code was generated by a tool at:
 * /utils/doclint/generateDotnetApi.js
 * 
 * Changes to this file may cause incorrect behavior and will be lost if 
 * the code is regenerated. 
 * </auto-generated> 
 * ------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Playwright
{
    /// <summary>
    /// <para>
    /// Selectors can be used to install custom selector engines. See <a href="./selectors.md">Working
    /// with selectors</a> for more information.
    /// </para>
    /// </summary>
    public partial interface ISelectors
    {
        /// <summary>
        /// <para>An example of registering selector engine that queries elements based on a tag name:</para>
        /// <code>
        /// using var playwright = await Playwright.CreateAsync();<br/>
        /// // Script that evaluates to a selector engine instance.<br/>
        /// await playwright.Selectors.RegisterAsync("tag", @"{<br/>
        /// // Returns the first element matching given selector in the root's subtree.<br/>
        /// query(root, selector) {<br/>
        ///     return root.querySelector(selector);<br/>
        ///   },<br/>
        ///   // Returns all elements matching given selector in the root's subtree.<br/>
        ///   queryAll(root, selector) {<br/>
        ///     return Array.from(root.querySelectorAll(selector));<br/>
        ///   }<br/>
        /// }");<br/>
        /// <br/>
        /// await using var browser = await playwright.Chromium.LaunchAsync();<br/>
        /// var page = await browser.NewPageAsync();<br/>
        /// await page.SetContentAsync("&lt;div&gt;&lt;button&gt;Click me&lt;/button&gt;&lt;/div&gt;");<br/>
        /// // Use the selector prefixed with its name.<br/>
        /// var button = await page.QuerySelectorAsync("tag=button");<br/>
        /// // Combine it with other selector engines.<br/>
        /// await page.ClickAsync("tag=div &gt;&gt; text=\"Click me\"");<br/>
        /// // Can use it in any methods supporting selectors.<br/>
        /// int buttonCount = await page.EvalOnSelectorAllAsync&lt;int&gt;("tag=button", "buttons =&gt; buttons.length");
        /// </code>
        /// </summary>
        /// <param name="name">
        /// Name that is used in selectors as a prefix, e.g. <c>{name: 'foo'}</c> enables <c>foo=myselectorbody</c>
        /// selectors. May only contain <c>[a-zA-Z0-9_]</c> characters.
        /// </param>
        /// <param name="script">Script that evaluates to a selector engine instance.</param>
        /// <param name="scriptPath">Instead of specifying <paramref name="script"/>, gives the file name to load from.</param>
        /// <param name="contentScript">
        /// Whether to run this selector engine in isolated JavaScript environment. This environment
        /// has access to the same DOM, but not any JavaScript objects from the frame's scripts.
        /// Defaults to <c>false</c>. Note that running as a content script is not guaranteed
        /// when this engine is used together with other registered engines.
        /// </param>
        Task RegisterAsync(string name, string script = null, string scriptPath = null, bool? contentScript = default);
    }
}
