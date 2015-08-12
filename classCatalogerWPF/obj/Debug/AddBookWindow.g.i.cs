﻿#pragma checksum "..\..\AddBookWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7AEE384C0847AF739FFABD80BFD248D6"
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


namespace classCatalogerWPF {
    
    
    /// <summary>
    /// AddBookWindow
    /// </summary>
    public partial class AddBookWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal classCatalogerWPF.AddBookWindow addABookWindow;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authorTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox coAuthorTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editorTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dateTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pagesTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox isbn10TextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox isbn13TextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBookButton;
        
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
            System.Uri resourceLocater = new System.Uri("/classCatalogerWPF;component/addbookwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddBookWindow.xaml"
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
            this.addABookWindow = ((classCatalogerWPF.AddBookWindow)(target));
            return;
            case 2:
            this.titleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.authorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.coAuthorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.editorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dateTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.pagesTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.isbn10TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.isbn13TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.addBookButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

