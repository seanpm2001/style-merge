﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StyleMerge.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Inputs {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Inputs() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StyleMerge.Tests.Inputs", typeof(Inputs).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///&lt;!DOCTYPE html PUBLIC &quot;-//W3C//DTD XHTML 1.0 Transitional//EN&quot; &quot;http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd&quot;&gt;
        ///&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///&lt;title&gt;&lt;/title&gt;
        ///&lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        ///&lt;meta http-equiv=&quot;Content-Language&quot; content=&quot;en-us&quot; /&gt;
        ///&lt;style type=&quot;text/css&quot; media=&quot;screen&quot;&gt;
        ///	
        ///	/* common
        ///	--------------------------------------------------*/
        ///	
        ///	body {
        ///		margin: 0px;
        ///		padding: 0px;
        ///		color: #fff;
        ///		background: #930; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EmailACIDTest {
            get {
                return ResourceManager.GetString("EmailACIDTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html PUBLIC &quot;-//W3C//DTD HTML 4.01 Transitional//EN&quot; &quot;http://www.w3.org/TR/html4/loose.dtd&quot;&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///This is some content
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string html_with_double_quote_doctype {
            get {
                return ResourceManager.GetString("html_with_double_quote_doctype", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!doctype html&gt;
        ///&lt;html class=&quot;no-js&quot; lang=&quot;&quot;&gt;
        ///    &lt;head&gt;
        ///        &lt;meta charset=&quot;utf-8&quot;&gt;
        ///        &lt;meta http-equiv=&quot;x-ua-compatible&quot; content=&quot;ie=edge&quot;&gt;
        ///        &lt;title&gt;&lt;/title&gt;
        ///        &lt;meta name=&quot;description&quot; content=&quot;&quot;&gt;
        ///        &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
        ///
        ///        &lt;link rel=&quot;apple-touch-icon&quot; href=&quot;apple-touch-icon.png&quot;&gt;
        ///        &lt;!-- Place favicon.ico in the root directory --&gt;
        ///
        ///        &lt;link rel=&quot;stylesheet&quot; href=&quot;css/normalize.css&quot;&gt;
        ///        &lt;link rel=&quot;sty [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HTML5_Boilerplate {
            get {
                return ResourceManager.GetString("HTML5_Boilerplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;style&gt;
        ///html, body{
        ///font-family: Arial, &quot;Helvetica Neue&quot;, Helvetica, sans-serif;
        ///background: background-image: url(&quot;http://foobar.com&quot;);
        ///}
        ///&lt;/style&gt;
        ///&lt;body&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string inlined_url_declarations_should_not_have_spaces_added {
            get {
                return ResourceManager.GetString("inlined_url_declarations_should_not_have_spaces_added", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;style&gt;
        ///html, body{
        ///color: blue;
        ///background: red !important;
        ///}
        ///
        ///a:hover {
        ///display:none !important;
        ///}
        ///&lt;/style&gt;
        ///&lt;body&gt;
        ///&lt;a href=&quot;http://www.example.com&quot;&gt;All out&lt;/a&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string inliner_should_maintain_important_stats {
            get {
                return ResourceManager.GetString("inliner_should_maintain_important_stats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;style type=&quot;text/css&quot;&gt;
        ///        span, a~~TEST_SELECTOR~~, .class1~~TEST_SELECTOR~~ {
        ///            color: orange;
        ///        }
        ///
        ///        div~~TEST_SELECTOR~~, span {
        ///            font-family: Arial;
        ///        }
        ///
        ///        a~~TEST_SELECTOR~~ {
        ///            font-size: 2em;
        ///        }
        ///
        ///        div {
        ///            background: red;
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///    &lt;body&gt;
        ///        &lt;a href=&quot;https://www.postmarkapp.com&quot;&gt;Postmark&lt;/a&gt;
        ///        &lt;span&gt;Color should be red.&lt;/span&gt;
        ///        &lt;div&gt;Color [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Inliner_Should_Support_PseudoClasses {
            get {
                return ResourceManager.GetString("Inliner_Should_Support_PseudoClasses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;style&gt;
        ///        #main {
        ///            background: red;
        ///        }
        ///
        ///        .less-specific, .more-specific {
        ///            /* this should not be applied. */
        ///            background: blue;
        ///        }
        ///
        ///        ul {
        ///            background: green;
        ///            font-family: Arial;
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;div id=&quot;main&quot; class=&quot;less-specific&quot;&gt;
        ///
        ///    &lt;/div&gt;
        ///    &lt;ul class=&quot;more-specific&quot;&gt;&lt;/ul&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string InlinerShouldApplyStylesAccordingToSpecificityValues {
            get {
                return ResourceManager.GetString("InlinerShouldApplyStylesAccordingToSpecificityValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;style&gt;
        ///        .selector1, ul li {
        ///            background: blue;
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;div class=&quot;selector1&quot;&gt;
        ///
        ///    &lt;/div&gt;
        ///    &lt;ul&gt;
        ///        &lt;li&gt;
        ///            This is an element.
        ///        &lt;/li&gt;
        ///    &lt;/ul&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string InlinerShouldApplyStylesForRulesWithMultipleSelectors {
            get {
                return ResourceManager.GetString("InlinerShouldApplyStylesForRulesWithMultipleSelectors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;style&gt;
        ///#target{
        ///    background-color: red;
        ///    width:100px;
        ///}
        ///&lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///&lt;style&gt;
        ///#target{
        ///    background-color: blue;
        ///}
        ///&lt;/style&gt;
        ///&lt;div id=&quot;target&quot;&gt;This is the content.&lt;/div&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string InlinerShouldApplyStylesInDocumentOrder {
            get {
                return ResourceManager.GetString("InlinerShouldApplyStylesInDocumentOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;body&gt;
        ///&lt;script&gt;console.log(&apos;this should be removed.&apos;);&lt;/script&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string InlinerShouldEliminateScriptBlocks {
            get {
                return ResourceManager.GetString("InlinerShouldEliminateScriptBlocks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;style&gt;
        ///        div {
        ///            background: purple;
        ///        }
        ///    &lt;/style&gt;
        ///    &lt;div&gt;
        ///
        ///    &lt;/div&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string InlinerShouldEliminateStyleBlocksWhereAllRulesAreInlined {
            get {
                return ResourceManager.GetString("InlinerShouldEliminateStyleBlocksWhereAllRulesAreInlined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;style&gt;
        ///        div {
        ///            background: blue;
        ///        }
        ///    &lt;/style&gt;
        ///    &lt;style&gt;
        ///        @media (min-width: 768px) {
        ///            div {
        ///                background: red;
        ///            }
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;div&gt;
        ///
        ///    &lt;/div&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string InlinerShouldKeepMediaQueryStylesInStyleBlocks {
            get {
                return ResourceManager.GetString("InlinerShouldKeepMediaQueryStylesInStyleBlocks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///    &lt;head&gt;
        ///        &lt;style&gt;
        ///            div {
        ///                color: #000;
        ///            }
        ///
        ///            #foo
        ///        &lt;/style&gt;
        ///    &lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;div id=&quot;foo&quot;&gt;&lt;/div&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string InlinerShouldSkipInvalidCSSDeclarations {
            get {
                return ResourceManager.GetString("InlinerShouldSkipInvalidCSSDeclarations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;head&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string Malformed_HTML_1 {
            get {
                return ResourceManager.GetString("Malformed_HTML_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 20347238782934sdjalksajk
        ///sadasdjlk
        ///&lt;html&gt;
        ///&lt;body&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string Malformed_HTML_2 {
            get {
                return ResourceManager.GetString("Malformed_HTML_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;style type=&quot;text/css&quot;&gt;
        ///
        ///#link-block{
        ///    background: purple;
        ///}
        ///
        ///@media (max-width: 700px){
        ///    body{
        ///        background: red;
        ///    }
        ///}
        ///&lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///&lt;style type=&quot;text/css&quot;&gt;
        ///#link-block{
        ///    background: green;
        ///}
        ///&lt;/style&gt;
        ///&lt;div id=&quot;link-block&quot;&gt;Hello, world.!&lt;/div&gt;
        ///&lt;script&gt;console.log(&apos;this should not ever appear.&apos;);&lt;/script&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string Specificity_Ordering_Test {
            get {
                return ResourceManager.GetString("Specificity_Ordering_Test", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///&lt;style&gt;
        ///* {
        ///color: purple
        ///}
        ///&lt;/style&gt;
        ///&lt;link href=&quot;./style.css&quot; type=&quot;text/css&quot; rel=&quot;Stylesheet&quot;/&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///&lt;span&gt;ASDF&lt;/span&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string universal_selector_shouldnt_apply_styles_to_head_and_children {
            get {
                return ResourceManager.GetString("universal_selector_shouldnt_apply_styles_to_head_and_children", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE HTML PUBLIC &quot;-//W3C//DTD XHTML 1.0 Strict//EN&quot; &quot;http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd&quot;&gt;
        ///&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=utf-8&quot; /&gt;
        ///    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width&quot; /&gt;
        ///    &lt;style&gt;
        ///        table.facebook td {
        ///            background: #3b5998;
        ///            border-color: #2d4473;
        ///        }
        ///
        ///        table.facebook:hover td {
        ///            background: #2d4473 !important;
        ///        } [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string zurb_example_1 {
            get {
                return ResourceManager.GetString("zurb_example_1", resourceCulture);
            }
        }
    }
}
