﻿#pragma checksum "..\..\AuthentificationForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DBFAE3C3150D83AA85F175421A48A5B95EB11C4A8E1BCF7E648CFB5D17D43A9B"
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
    /// AuthentificationForm
    /// </summary>
    public partial class AuthentificationForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AuthentificationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PasswordLB;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AuthentificationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTB;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AuthentificationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordPB;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AuthentificationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AcceptButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AuthentificationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateAccountButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AuthentificationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordTB;
        
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
            System.Uri resourceLocater = new System.Uri("/MainWPFWindow;component/authentificationform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthentificationForm.xaml"
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
            this.PasswordLB = ((System.Windows.Controls.Label)(target));
            
            #line 31 "..\..\AuthentificationForm.xaml"
            this.PasswordLB.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PasswordLB_MouseDown);
            
            #line default
            #line hidden
            
            #line 31 "..\..\AuthentificationForm.xaml"
            this.PasswordLB.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.PasswordLB_MouseUp);
            
            #line default
            #line hidden
            
            #line 31 "..\..\AuthentificationForm.xaml"
            this.PasswordLB.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PasswordLB_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PasswordPB = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.AcceptButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\AuthentificationForm.xaml"
            this.AcceptButton.Click += new System.Windows.RoutedEventHandler(this.AcceptButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreateAccountButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\AuthentificationForm.xaml"
            this.CreateAccountButton.Click += new System.Windows.RoutedEventHandler(this.CreateAccountButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordTB = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

