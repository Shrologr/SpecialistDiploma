﻿#pragma checksum "..\..\StatisticsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F19A8A5E2A5BF5F8E85757B47E540ADB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PersonalUIElement;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;
using ZedGraph;


namespace WpfDiploma {
    
    
    /// <summary>
    /// StatisticsWindow
    /// </summary>
    public partial class StatisticsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CircularSpeedTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StraightSpeedTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RotationPeriodTextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CalculationTimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CellWidthTextBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PointNumberSlider;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PointSizeSlider;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker PointColorPicker;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PersonalUIElement.PersonalUIElement uiElement;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost GraphHost;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ZedGraph.ZedGraphControl GraphControl;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StartStopGrid;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartPauseButton;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image StartPauseImage;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopButton;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveDataButton;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadDataButton;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveGraphDataButton;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadGraphDataButton;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SavePictureButton;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadPictureButton;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\StatisticsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfDiploma;component/statisticswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StatisticsWindow.xaml"
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
            
            #line 10 "..\..\StatisticsWindow.xaml"
            ((WpfDiploma.StatisticsWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CircularSpeedTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.StraightSpeedTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RotationPeriodTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CalculationTimeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CellWidthTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PointNumberSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 8:
            this.PointSizeSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 9:
            this.PointColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            case 10:
            this.uiElement = ((PersonalUIElement.PersonalUIElement)(target));
            return;
            case 11:
            this.GraphHost = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 12:
            this.GraphControl = ((ZedGraph.ZedGraphControl)(target));
            
            #line 107 "..\..\StatisticsWindow.xaml"
            this.GraphControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GraphControl_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.StartStopGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.StartPauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\StatisticsWindow.xaml"
            this.StartPauseButton.Click += new System.Windows.RoutedEventHandler(this.StartPauseButton_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.StartPauseImage = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            this.StopButton = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\StatisticsWindow.xaml"
            this.StopButton.Click += new System.Windows.RoutedEventHandler(this.StopButton_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.SaveDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\StatisticsWindow.xaml"
            this.SaveDataButton.Click += new System.Windows.RoutedEventHandler(this.SaveDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.LoadDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\StatisticsWindow.xaml"
            this.LoadDataButton.Click += new System.Windows.RoutedEventHandler(this.LoadDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.SaveGraphDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\StatisticsWindow.xaml"
            this.SaveGraphDataButton.Click += new System.Windows.RoutedEventHandler(this.SaveGraphDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.LoadGraphDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\StatisticsWindow.xaml"
            this.LoadGraphDataButton.Click += new System.Windows.RoutedEventHandler(this.LoadGraphDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.SavePictureButton = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\StatisticsWindow.xaml"
            this.SavePictureButton.Click += new System.Windows.RoutedEventHandler(this.SavePictureButton_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.LoadPictureButton = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\StatisticsWindow.xaml"
            this.LoadPictureButton.Click += new System.Windows.RoutedEventHandler(this.LoadPictureButton_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\StatisticsWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

