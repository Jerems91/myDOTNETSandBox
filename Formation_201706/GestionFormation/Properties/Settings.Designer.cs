﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionFormation.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\ADMIN STAGIAIRE\\DOCU" +
            "MENTS\\VISUAL STUDIO 2017\\PROJECTS\\FORMATION_201706\\GESTIONFORMATION\\DATABASE1.MD" +
            "F\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertific" +
            "ate=True")]
        public string C__USERS_ADMIN_STAGIAIRE_DOCUMENTS_VISUAL_STUDIO_2017_PROJECTS_FORMATION_201706_GESTIONFORMATION_DATABASE1_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_ADMIN_STAGIAIRE_DOCUMENTS_VISUAL_STUDIO_2017_PROJECTS_FORMATION_201706_G" +
                    "ESTIONFORMATION_DATABASE1_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf" +
            ";Integrated Security=True")]
        public string Database1ConnectionString {
            get {
                return ((string)(this["Database1ConnectionString"]));
            }
        }
    }
}
