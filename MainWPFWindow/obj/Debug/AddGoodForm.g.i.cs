﻿#pragma checksum "..\..\AddGoodForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1AD10D844C44B5845309424B57749125CD8B9E00C63121113ED1FB20CA502B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MainWPFWindow;
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


namespace MainWPFWindow {
    
    
    /// <summary>
    /// AddGoodForm
    /// </summary>
    public partial class AddGoodForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddGoodButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GoodNameTB;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GoodCategoryCB;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GoodManufacturerCB;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTB;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountTB;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhotoTB;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\AddGoodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowGoodPhotoButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MainWPFWindow;component/addgoodform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddGoodForm.xaml"
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
            this.AddGoodButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AddGoodForm.xaml"
            this.AddGoodButton.Click += new System.Windows.RoutedEventHandler(this.AddGoodButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoodNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GoodCategoryCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.GoodManufacturerCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.PriceTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CountTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PhotoTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ShowGoodPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\AddGoodForm.xaml"
            this.ShowGoodPhotoButton.Click += new System.Windows.RoutedEventHandler(this.ShowGoodPhotoButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

