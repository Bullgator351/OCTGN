﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Octgn.Data.Properties {
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
    public class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Octgn.Data.Properties.Resource1", typeof(Resource1).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to begin transaction;
        ///
        ///pragma auto_vacuum=1;
        ///pragma default_cache_size=2000;
        ///pragma encoding=&apos;UTF-8&apos;;
        ///pragma page_size=1024;
        ///
        ///CREATE TABLE [dbinfo] (
        ///  [version] INTEGER NOT NULL
        ///);
        ///
        ///INSERT INTO dbinfo([version]) VALUES(1);
        ///
        ///CREATE TABLE [games] (
        ///  [id] INTEGER PRIMARY KEY AUTOINCREMENT, 
        ///  [filename] TEXT NOT NULL ON CONFLICT FAIL, 
        ///  [version] TEXT NOT NULL, 
        ///  [card_width] INTEGER, 
        ///  [card_height] INTEGER, 
        ///  [card_back] TEXT, 
        ///  [deck_sections] TEXT, 
        ///  [shared_deck_sections] TEXT,
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string MakeDatabase {
            get {
                return ResourceManager.GetString("MakeDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string UpdateDatabase {
            get {
                return ResourceManager.GetString("UpdateDatabase", resourceCulture);
            }
        }
    }
}
