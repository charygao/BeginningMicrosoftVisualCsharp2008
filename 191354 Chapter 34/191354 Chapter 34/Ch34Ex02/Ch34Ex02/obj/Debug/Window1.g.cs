﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39462CD4EE2E09256ED5DE1BAC303C43"
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


namespace Ch34Ex02 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Window1.xaml"
        internal System.Windows.Controls.Grid contentGrid;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Window1.xaml"
        internal System.Windows.Shapes.Rectangle clickMeRectangle;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button clickMeButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBlock outputText;
        
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
            System.Uri resourceLocater = new System.Uri("/Ch34Ex02;component/window1.xaml", System.UriKind.Relative);
            
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
            
            #line 6 "..\..\Window1.xaml"
            ((Ch34Ex02.Window1)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            
            #line 6 "..\..\Window1.xaml"
            ((Ch34Ex02.Window1)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            
            #line 6 "..\..\Window1.xaml"
            ((Ch34Ex02.Window1)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.contentGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 8 "..\..\Window1.xaml"
            this.contentGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Window1.xaml"
            this.contentGrid.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.clickMeRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 9 "..\..\Window1.xaml"
            this.clickMeRectangle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\Window1.xaml"
            this.clickMeRectangle.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clickMeButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Window1.xaml"
            this.clickMeButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Window1.xaml"
            this.clickMeButton.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Generic_MouseDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Window1.xaml"
            this.clickMeButton.Click += new System.Windows.RoutedEventHandler(this.clickMeButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.outputText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
