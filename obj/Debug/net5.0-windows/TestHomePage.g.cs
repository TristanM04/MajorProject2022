﻿#pragma checksum "..\..\..\TestHomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0B5E7D4C1F8FA61168A78B617F1960B76E950F9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MajorProject2022;
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


namespace MajorProject2022 {
    
    
    /// <summary>
    /// TestHomePage
    /// </summary>
    public partial class TestHomePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 223 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Workout;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chat;
        
        #line default
        #line hidden
        
        
        #line 264 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Settings;
        
        #line default
        #line hidden
        
        
        #line 316 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleBox;
        
        #line default
        #line hidden
        
        
        #line 343 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionBox;
        
        #line default
        #line hidden
        
        
        #line 369 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DurationBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MajorProject2022;component/testhomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TestHomePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\TestHomePage.xaml"
            ((MajorProject2022.TestHomePage)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Workout = ((System.Windows.Controls.Button)(target));
            
            #line 229 "..\..\..\TestHomePage.xaml"
            this.Workout.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Workout_MouseEnter);
            
            #line default
            #line hidden
            
            #line 230 "..\..\..\TestHomePage.xaml"
            this.Workout.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Workout_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Chat = ((System.Windows.Controls.Button)(target));
            
            #line 251 "..\..\..\TestHomePage.xaml"
            this.Chat.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Chat_MouseEnter);
            
            #line default
            #line hidden
            
            #line 252 "..\..\..\TestHomePage.xaml"
            this.Chat.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Chat_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Settings = ((System.Windows.Controls.Button)(target));
            
            #line 270 "..\..\..\TestHomePage.xaml"
            this.Settings.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Settings_MouseEnter);
            
            #line default
            #line hidden
            
            #line 271 "..\..\..\TestHomePage.xaml"
            this.Settings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Settings_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TitleBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 319 "..\..\..\TestHomePage.xaml"
            this.TitleBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.EmailBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DescriptionBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 346 "..\..\..\TestHomePage.xaml"
            this.DescriptionBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DurationBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 372 "..\..\..\TestHomePage.xaml"
            this.DurationBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Password_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
