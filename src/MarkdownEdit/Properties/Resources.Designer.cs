﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarkdownEdit.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MarkdownEdit.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///  &lt;title&gt;Markdown Edit Preview&lt;/title&gt;
        ///  &lt;!-- Don&apos;t delete this X-UA tag. The browser control behaves like IE8 otherwise --&gt;
        ///  &lt;meta http-equiv=&quot;X-UA-Compatible&quot; content=&quot;IE=9&quot;&gt;
        ///  &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html;charset=utf-8&quot; /&gt;
        ///  &lt;style type=&quot;text/css&quot;&gt;
        ///    body {
        ///      font-family: &quot;Century Gothic&quot;, Arial;
        ///      font-size: 15px;
        ///      line-height: 1.5;
        ///      color: #555;
        ///      padding: 0.5pc 0;
        ///      overflow-x: hidden;
        ///      overflow-y: scroll;
        ///      backg [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GithubTemplateHtml {
            get {
                return ResourceManager.GetString("GithubTemplateHtml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keyboard Shortcuts
        ///------------------
        ///
        ///    F1             Show/Hide this help
        ///
        ///    Ctrl+N         New file
        ///    Ctrl+Shift+N   Open new instance
        ///    Ctrl+O         Open file
        ///    Ctrl+Shift+O   Insert file
        ///    Ctrl+S         Save file
        ///    Ctrl+Shift+S   Save file As
        ///    Ctrl+R         Recent files
        ///    Ctrl+E         Export HTML to clipboard
        ///    Ctrl+Shift+E   Export HTML and template to clipboard
        ///    Alt+F4         Exit
        ///
        ///    Ctrl+W         Toggle word wrap
        ///    Ctrl+F7        Toggle spell chec [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Help {
            get {
                return ResourceManager.GetString("Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to =======================================================
        ///= English
        ///=======================================================
        ///
        ///=== Main Window
        ///
        ///tooltip-new-command:              New - Ctrl+N
        ///tooltip-open-command:             Open - Ctrl+O
        ///tooltip-save-command:             Save - Ctrl+S
        ///tooltip-save-as-command:          Save as - Ctrl+Shift+S
        ///tooltip-toggle-settings:          Settings
        ///tooltip-word-count:               Word Count
        ///tooltip-spell-check:              Spell Check - Ctrl+F7
        ///tooltip-word-wr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string local {
            get {
                return ResourceManager.GetString("local", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to now       $DATE(&quot;f&quot;)$ $END$
        ///date      $DATE(&quot;d&quot;)$ $END$
        ///time      $DATE(&quot;t&quot;)$ $END$
        ///
        ///img       ![$alt_text$]($image_url$) $END$
        ///link      [$link_text$]($link_url$) $END$
        ///
        ///tm        &amp;trade;
        ///cp        &amp;copy;
        ///reg       &amp;reg;
        ///.
        /// </summary>
        internal static string Snippets {
            get {
                return ResourceManager.GetString("Snippets", resourceCulture);
            }
        }
    }
}
