﻿#pragma checksum "..\..\..\..\Windows\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "377DD349079C7BC856EA876C3FEFF11CB995FBC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MechanicApp;
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


namespace MechanicApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost Host;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid ButtonSP;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button1;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button2;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PageBrowser;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Chip ProfileChip;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGraphs;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel EnterLogs;
        
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
            System.Uri resourceLocater = new System.Uri("/MechanicApp;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\MainWindow.xaml"
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
            this.Host = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 2:
            this.ButtonSP = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            case 3:
            this.MainBtn = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Windows\MainWindow.xaml"
            this.MainBtn.Click += new System.Windows.RoutedEventHandler(this.MainBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button1 = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Windows\MainWindow.xaml"
            this.Button1.Click += new System.Windows.RoutedEventHandler(this.OrdersBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button2 = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\Windows\MainWindow.xaml"
            this.Button2.Click += new System.Windows.RoutedEventHandler(this.StarsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PageBrowser = ((System.Windows.Controls.Frame)(target));
            return;
            case 7:
            this.ProfileChip = ((MaterialDesignThemes.Wpf.Chip)(target));
            
            #line 92 "..\..\..\..\Windows\MainWindow.xaml"
            this.ProfileChip.Click += new System.Windows.RoutedEventHandler(this.ProfileChip_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnGraphs = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            
            #line 117 "..\..\..\..\Windows\MainWindow.xaml"
            ((MaterialDesignThemes.Wpf.PopupBox)(target)).Opened += new System.Windows.RoutedEventHandler(this.PopupBox_Opened);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EnterLogs = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

