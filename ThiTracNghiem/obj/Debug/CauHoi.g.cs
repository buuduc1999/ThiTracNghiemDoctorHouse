﻿#pragma checksum "..\..\CauHoi.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28BA0B948C7099DD0860C0046994BFEC1A8F0AE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
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
using ThiTracNghiem;


namespace ThiTracNghiem {
    
    
    /// <summary>
    /// CauHoi
    /// </summary>
    public partial class CauHoi : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CauHoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CauHoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NoiDungText;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CauHoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AnswerPanel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CauHoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Atext;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CauHoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Btext;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CauHoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Ctext;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\CauHoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Dtext;
        
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
            System.Uri resourceLocater = new System.Uri("/ThiTracNghiem;component/cauhoi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CauHoi.xaml"
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
            
            #line 9 "..\..\CauHoi.xaml"
            ((ThiTracNghiem.CauHoi)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.NoiDungText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.AnswerPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.Atext = ((System.Windows.Controls.RadioButton)(target));
            
            #line 20 "..\..\CauHoi.xaml"
            this.Atext.Checked += new System.Windows.RoutedEventHandler(this.RadioCheck);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btext = ((System.Windows.Controls.RadioButton)(target));
            
            #line 25 "..\..\CauHoi.xaml"
            this.Btext.Checked += new System.Windows.RoutedEventHandler(this.RadioCheck);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Ctext = ((System.Windows.Controls.RadioButton)(target));
            
            #line 30 "..\..\CauHoi.xaml"
            this.Ctext.Checked += new System.Windows.RoutedEventHandler(this.RadioCheck);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Dtext = ((System.Windows.Controls.RadioButton)(target));
            
            #line 35 "..\..\CauHoi.xaml"
            this.Dtext.Checked += new System.Windows.RoutedEventHandler(this.RadioCheck);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

