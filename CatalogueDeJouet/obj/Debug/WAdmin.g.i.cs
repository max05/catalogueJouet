﻿#pragma checksum "..\..\WAdmin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C9AC2D0BE5F5E8A909AA8123E32BB538"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CatalogueDeJouet {
    
    
    /// <summary>
    /// WAdmin
    /// </summary>
    public partial class WAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\WAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GCommande;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\WAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition liFirstLine;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\WAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition liOtherLine;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition liEnfant;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition liJouet;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition liPère;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lBienvenue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CatalogueDeJouet;component/wadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GCommande = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.liFirstLine = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.liOtherLine = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 4:
            this.liEnfant = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 5:
            this.liJouet = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 6:
            this.liPère = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 7:
            this.lBienvenue = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

