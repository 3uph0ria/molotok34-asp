﻿#pragma checksum "..\..\..\Pages\PageReports.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A5E82435F262E97F9E3D578C0A96BF5B3B524F5269C6557762499978AA25A9BD"
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
using Molotok34.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Integration;
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


namespace Molotok34.Pages {
    
    
    /// <summary>
    /// PageReports
    /// </summary>
    public partial class PageReports : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Pages\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBoxUsers;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBoxTypeChart;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.DataVisualization.Charting.Chart ChatPayments;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreateReport;
        
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
            System.Uri resourceLocater = new System.Uri("/Molotok34;component/pages/pagereports.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageReports.xaml"
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
            this.CBoxUsers = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\Pages\PageReports.xaml"
            this.CBoxUsers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UpdateChart);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CBoxTypeChart = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\Pages\PageReports.xaml"
            this.CBoxTypeChart.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UpdateChart);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChatPayments = ((System.Windows.Forms.DataVisualization.Charting.Chart)(target));
            return;
            case 4:
            this.BtnCreateReport = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\PageReports.xaml"
            this.BtnCreateReport.Click += new System.Windows.RoutedEventHandler(this.BtnCreateReport_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
