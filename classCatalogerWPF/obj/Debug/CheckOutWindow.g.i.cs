﻿#pragma checksum "..\..\CheckOutWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A66E50D2C2DDB01B0D987378B4B1A7E9"
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
    /// CheckOutWindow
    /// </summary>
    public partial class CheckOutWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal classCatalogerWPF.CheckOutWindow CheckOutWindow1;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label checkoutBookLabel;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label selectedBookLabel;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label studentToCheckoutToLabel;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkOutToTextBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox durationComboBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label durationLabel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox dueDateReminderCheckBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CheckOutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button finalCheckOutButton;
        
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
            System.Uri resourceLocater = new System.Uri("/classCatalogerWPF;component/checkoutwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CheckOutWindow.xaml"
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
            this.CheckOutWindow1 = ((classCatalogerWPF.CheckOutWindow)(target));
            return;
            case 2:
            this.checkoutBookLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.selectedBookLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.studentToCheckoutToLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.checkOutToTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 9 "..\..\CheckOutWindow.xaml"
            this.checkOutToTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.checkOutToTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.durationComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\CheckOutWindow.xaml"
            this.durationComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.durationComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.durationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.dueDateReminderCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\CheckOutWindow.xaml"
            this.dueDateReminderCheckBox.Checked += new System.Windows.RoutedEventHandler(this.dueDateReminderCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.finalCheckOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\CheckOutWindow.xaml"
            this.finalCheckOutButton.Click += new System.Windows.RoutedEventHandler(this.finalCheckOutButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

