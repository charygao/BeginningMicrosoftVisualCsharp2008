﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "068F3204C59765D8D50D8A3723158F88"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
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


namespace Ch34Ex01 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Window1.xaml"
        internal System.Windows.Media.Animation.BeginStoryboard Spin_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Window1.xaml"
        internal System.Windows.Shapes.Ellipse ellipse5;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Window1.xaml"
        internal System.Windows.Shapes.Ellipse ellipse1;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Window1.xaml"
        internal System.Windows.Shapes.Ellipse ellipse2;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Window1.xaml"
        internal System.Windows.Shapes.Ellipse ellipse3;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Window1.xaml"
        internal System.Windows.Shapes.Ellipse ellipse4;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button goButton;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button toggleButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Ch34Ex01;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Spin_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.ellipse5 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 3:
            this.ellipse1 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 4:
            this.ellipse2 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            this.ellipse3 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 6:
            this.ellipse4 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 7:
            this.goButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.toggleButton = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\Window1.xaml"
            this.toggleButton.Click += new System.Windows.RoutedEventHandler(this.toggleButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
