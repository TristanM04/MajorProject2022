﻿#pragma checksum "..\..\..\TestHomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E535E929DD51F7BB72FC5643C0CE1A6787663586"
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
        
        
        #line 224 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Workout;
        
        #line default
        #line hidden
        
        
        #line 246 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chat;
        
        #line default
        #line hidden
        
        
        #line 265 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Settings;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 344 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleBox;
        
        #line default
        #line hidden
        
        
        #line 371 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionBox;
        
        #line default
        #line hidden
        
        
        #line 397 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DurationBox;
        
        #line default
        #line hidden
        
        
        #line 423 "..\..\..\TestHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddWorkOutBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MajorProject2022;V1.0.0.0;component/testhomepage.xaml", System.UriKind.Relative);
            
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
            
            #line 230 "..\..\..\TestHomePage.xaml"
            this.Workout.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Workout_MouseEnter);
            
            #line default
            #line hidden
            
            #line 231 "..\..\..\TestHomePage.xaml"
            this.Workout.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Workout_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Chat = ((System.Windows.Controls.Button)(target));
            
            #line 252 "..\..\..\TestHomePage.xaml"
            this.Chat.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Chat_MouseEnter);
            
            #line default
            #line hidden
            
            #line 253 "..\..\..\TestHomePage.xaml"
            this.Chat.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Chat_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Settings = ((System.Windows.Controls.Button)(target));
            
            #line 271 "..\..\..\TestHomePage.xaml"
            this.Settings.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Settings_MouseEnter);
            
            #line default
            #line hidden
            
            #line 272 "..\..\..\TestHomePage.xaml"
            this.Settings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Settings_MouseLeave);
            
            #line default
            #line hidden
            
            #line 273 "..\..\..\TestHomePage.xaml"
            this.Settings.Click += new System.Windows.RoutedEventHandler(this.Settings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 322 "..\..\..\TestHomePage.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TitleBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 347 "..\..\..\TestHomePage.xaml"
            this.TitleBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TitleBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DescriptionBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 374 "..\..\..\TestHomePage.xaml"
            this.DescriptionBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.DescriptionBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DurationBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 400 "..\..\..\TestHomePage.xaml"
            this.DurationBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.DurationBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddWorkOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 429 "..\..\..\TestHomePage.xaml"
            this.AddWorkOutBtn.Click += new System.Windows.RoutedEventHandler(this.AddWorkOutBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

