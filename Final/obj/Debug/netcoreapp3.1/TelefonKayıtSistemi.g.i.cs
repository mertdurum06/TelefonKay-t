﻿#pragma checksum "..\..\..\TelefonKayıtSistemi.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D51BDDB3A499A01CCE2557F9C5C2EC8A9D5D9999"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using Final;
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


namespace Final {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox markalist;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox modellist;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox renklist;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox fiyatlist;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox marka;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox model;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox renk;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fiyat;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ürünkayıt;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\..\TelefonKayıtSistemi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button getir;
        
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
            System.Uri resourceLocater = new System.Uri("/Final;V1.0.0.0;component/telefonkay%c4%b1tsistemi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TelefonKayıtSistemi.xaml"
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
            this.markalist = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.modellist = ((System.Windows.Controls.ListBox)(target));
            
            #line 34 "..\..\..\TelefonKayıtSistemi.xaml"
            this.modellist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged_2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.renklist = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.fiyatlist = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.marka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.model = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.renk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.fiyat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 132 "..\..\..\TelefonKayıtSistemi.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 154 "..\..\..\TelefonKayıtSistemi.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ürünkayıt = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            
            #line 243 "..\..\..\TelefonKayıtSistemi.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 13:
            this.getir = ((System.Windows.Controls.Button)(target));
            
            #line 313 "..\..\..\TelefonKayıtSistemi.xaml"
            this.getir.Click += new System.Windows.RoutedEventHandler(this.getir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

