﻿#pragma checksum "..\..\..\Pages\Step3Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9132E73C5C2980FB44D5DD60F78340A7558CC5CB914F31E375C32D3BC9EEAA1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BolotinTour.Pages;
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


namespace BolotinTour.Pages {
    
    
    /// <summary>
    /// Step3Page
    /// </summary>
    public partial class Step3Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBoxEat;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewService;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slMin;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMin;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slMax;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMax;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSkip;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\Step3Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNext;
        
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
            System.Uri resourceLocater = new System.Uri("/BolotinTour;component/pages/step3page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Step3Page.xaml"
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
            this.CBoxEat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.LViewService = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.slMin = ((System.Windows.Controls.Slider)(target));
            
            #line 54 "..\..\..\Pages\Step3Page.xaml"
            this.slMin.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SlMin_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtMin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.slMax = ((System.Windows.Controls.Slider)(target));
            
            #line 58 "..\..\..\Pages\Step3Page.xaml"
            this.slMax.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SlMax_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtMax = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.BtnSkip = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Pages\Step3Page.xaml"
            this.BtnSkip.Click += new System.Windows.RoutedEventHandler(this.BtnSkip_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnNext = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Pages\Step3Page.xaml"
            this.BtnNext.Click += new System.Windows.RoutedEventHandler(this.BtnNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

