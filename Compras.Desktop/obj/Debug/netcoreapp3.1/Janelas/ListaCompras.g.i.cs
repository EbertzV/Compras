﻿#pragma checksum "..\..\..\..\Janelas\ListaCompras.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6FF801E70D5F7B8875D43E8F3434D934F1733C64"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Compras.Desktop.Janelas;
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


namespace Compras.Desktop.Janelas {
    
    
    /// <summary>
    /// ListaCompras
    /// </summary>
    public partial class ListaCompras : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 34 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DP_ListaCompras_FiltroDataMinima;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DP_ListaCompras_FiltroDataMaxima;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ListaCompras_FiltroValorMinimo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ListaCompras_FiltroValorMaximo;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG_ListaCompras;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblPgAtual;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_PgAnterior;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\Janelas\ListaCompras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_ProxPg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Compras.Desktop;component/janelas/listacompras.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Janelas\ListaCompras.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 21 "..\..\..\..\Janelas\ListaCompras.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\..\..\Janelas\ListaCompras.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DP_ListaCompras_FiltroDataMinima = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.DP_ListaCompras_FiltroDataMaxima = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.TB_ListaCompras_FiltroValorMinimo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TB_ListaCompras_FiltroValorMaximo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 46 "..\..\..\..\Janelas\ListaCompras.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_ListaCompras_Pesquisar_Handler);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 47 "..\..\..\..\Janelas\ListaCompras.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DG_ListaCompras = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.lblPgAtual = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.Btn_PgAnterior = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\..\..\Janelas\ListaCompras.xaml"
            this.Btn_PgAnterior.Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Btn_ProxPg = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\..\..\Janelas\ListaCompras.xaml"
            this.Btn_ProxPg.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 10:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 67 "..\..\..\..\Janelas\ListaCompras.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DataGridRow_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 11:
            
            #line 98 "..\..\..\..\Janelas\ListaCompras.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

