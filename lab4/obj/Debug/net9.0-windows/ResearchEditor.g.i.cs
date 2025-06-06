﻿#pragma checksum "..\..\..\ResearchEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72720C25FB3FBF4544BE7BCC8764B64B20257CB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace lab4 {
    
    
    /// <summary>
    /// ResearchEditor
    /// </summary>
    public partial class ResearchEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrganizationNameBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResearchTopicBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ContractValueBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ContractDatePicker;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PublicationsListBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPublicationButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditPublicationButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\ResearchEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeletePublicationButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/lab4;component/researcheditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ResearchEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OrganizationNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ResearchTopicBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ContractValueBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ContractDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.PublicationsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.AddPublicationButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\ResearchEditor.xaml"
            this.AddPublicationButton.Click += new System.Windows.RoutedEventHandler(this.AddPublicationButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EditPublicationButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\ResearchEditor.xaml"
            this.EditPublicationButton.Click += new System.Windows.RoutedEventHandler(this.EditPublicationButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DeletePublicationButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\ResearchEditor.xaml"
            this.DeletePublicationButton.Click += new System.Windows.RoutedEventHandler(this.DeletePublicationButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 52 "..\..\..\ResearchEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OKButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

