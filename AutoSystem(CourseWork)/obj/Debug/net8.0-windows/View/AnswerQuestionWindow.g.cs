﻿#pragma checksum "..\..\..\..\View\AnswerQuestionWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48496F51CFEB7BCAA4B37E03089FCF25DC1796DE"
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
    /// AnswerQuestionWindow
    /// </summary>
    public partial class AnswerQuestionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\AnswerQuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Navbar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\AnswerQuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Navbar_Border;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\AnswerQuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Navbar_Panel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\AnswerQuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Minimize;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\AnswerQuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Exit;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\AnswerQuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Text_Of_Window;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\AnswerQuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Answer_Question_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoSystem(CourseWork);component/view/answerquestionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AnswerQuestionWindow.xaml"
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
            
            #line 21 "..\..\..\..\View\AnswerQuestionWindow.xaml"
            this.Navbar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Navbar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Navbar_Border = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.Navbar_Panel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.Minimize = ((System.Windows.Controls.Image)(target));
            
            #line 24 "..\..\..\..\View\AnswerQuestionWindow.xaml"
            this.Minimize.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Exit = ((System.Windows.Shapes.Path)(target));
            
            #line 25 "..\..\..\..\View\AnswerQuestionWindow.xaml"
            this.Exit.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Exit_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Text_Of_Window = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.Answer_Question_Button = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

