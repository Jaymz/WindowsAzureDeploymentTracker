﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeploymentTracker.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\DTD\\Logs")]
        public string DeploymentLogPath {
            get {
                return ((string)(this["DeploymentLogPath"]));
            }
            set {
                this["DeploymentLogPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\DTD\\TFS")]
        public string TFSWorkingPath {
            get {
                return ((string)(this["TFSWorkingPath"]));
            }
            set {
                this["TFSWorkingPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string MaxSessionsPermitted {
            get {
                return ((string)(this["MaxSessionsPermitted"]));
            }
            set {
                this["MaxSessionsPermitted"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\\Data\\DeploymentTrackerLocalDB.sdf; password=hello123")]
        public string DeploymentTrackerLocalDBConnectionString {
            get {
                return ((string)(this["DeploymentTrackerLocalDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\DTD\\AppLogs")]
        public string ApplicationLogPath {
            get {
                return ((string)(this["ApplicationLogPath"]));
            }
            set {
                this["ApplicationLogPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public string NumberOfTries {
            get {
                return ((string)(this["NumberOfTries"]));
            }
            set {
                this["NumberOfTries"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://windows.azure.com/download/publishprofile.aspx?wa=wsignin1.0")]
        public string AzurePublishSettingsDownloadLink {
            get {
                return ((string)(this["AzurePublishSettingsDownloadLink"]));
            }
            set {
                this["AzurePublishSettingsDownloadLink"] = value;
            }
        }
    }
}
