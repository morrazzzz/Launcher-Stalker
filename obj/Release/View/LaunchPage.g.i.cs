﻿#pragma checksum "..\..\..\View\LaunchPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6F8116FDDEE47CFB0568082FE015939EB8EE37AC69035EB5011DF205640AB3C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CoPLauncher.View;
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


namespace CoPLauncher.View {
    
    
    /// <summary>
    /// LaunchPage
    /// </summary>
    public partial class LaunchPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 76 "..\..\..\View\LaunchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LaunchGameBtn;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\LaunchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownNewVersion;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\LaunchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CheckVersion;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\View\LaunchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar SearchProgressBar;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\View\LaunchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBox_close_launcher;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\View\LaunchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_mode_Stalker;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\View\LaunchPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Keys;
        
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
            System.Uri resourceLocater = new System.Uri("/CoPLauncher;component/view/launchpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\LaunchPage.xaml"
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
            this.LaunchGameBtn = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\View\LaunchPage.xaml"
            this.LaunchGameBtn.Click += new System.Windows.RoutedEventHandler(this.LaunchGameBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DownNewVersion = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.CheckVersion = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.SearchProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 5:
            this.CheckBox_close_launcher = ((System.Windows.Controls.CheckBox)(target));
            
            #line 80 "..\..\..\View\LaunchPage.xaml"
            this.CheckBox_close_launcher.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ComboBox_mode_Stalker = ((System.Windows.Controls.ComboBox)(target));
            
            #line 81 "..\..\..\View\LaunchPage.xaml"
            this.ComboBox_mode_Stalker.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextBox_Keys = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\..\View\LaunchPage.xaml"
            this.TextBox_Keys.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_Keys_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

