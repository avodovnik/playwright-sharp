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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Playwright
{
	public class BrowserTypeProxy
	{
		/// <summary>
		/// <para>
		/// Proxy to be used for all requests. HTTP and SOCKS proxies are supported, for example
		/// <c>http://myproxy.com:3128</c> or <c>socks5://myproxy.com:3128</c>. Short form <c>myproxy.com:3128</c>
		/// is considered an HTTP proxy.
		/// </para>
		/// </summary>
		string Server { get; set; }
	
		/// <summary>
		/// <para>
		/// Optional coma-separated domains to bypass proxy, for example <c>".com, chromium.org,
		/// .domain.com"</c>.
		/// </para>
		/// </summary>
		string Bypass { get; set; }
	
		/// <summary><para>Optional username to use if HTTP proxy requires authentication.</para></summary>
		string Username { get; set; }
	
		/// <summary><para>Optional password to use if HTTP proxy requires authentication.</para></summary>
		string Password { get; set; }
	}
}