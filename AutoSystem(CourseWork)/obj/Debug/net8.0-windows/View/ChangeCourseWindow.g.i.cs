﻿#pragma checksum "..\..\..\..\View\ChangeCourseWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0724C13A6DA20B9677CE0672A4CA23707B434474"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoSystem_CourseWork_.View;
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


namespace AutoSystem_CourseWork_.View {
    
    
    /// <summary>
    /// ChangeCourseWindow
    /// </summary>
    public partial class ChangeCourseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Navbar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Navbar_Panel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Minimize;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Exit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Courses_List;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List_Of_Courses;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List_Of_Tests;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List_Of_Questions;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Courses_Add;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Course_Add_Button;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\View\ChangeCourseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CourseRedactor;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutoSystem(CourseWork);component/view/changecoursewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ChangeCourseWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Navbar = ((System.Windows.Controls.Grid)(target));
            
            #line 24 "..\..\..\..\View\ChangeCourseWindow.xaml"
            this.Navbar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Navbar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Navbar_Panel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.Minimize = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\..\..\View\ChangeCourseWindow.xaml"
            this.Minimize.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Exit = ((System.Windows.Shapes.Path)(target));
            
            #line 27 "..\..\..\..\View\ChangeCourseWindow.xaml"
            this.Exit.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Exit_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Courses_List = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.List_Of_Courses = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.List_Of_Tests = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.List_Of_Questions = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.Courses_Add = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.Course_Add_Button = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.CourseRedactor = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

