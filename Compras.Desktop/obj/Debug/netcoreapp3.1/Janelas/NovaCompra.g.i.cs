﻿#pragma checksum "..\..\..\..\Janelas\NovaCompra.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D20B0703AD3ABB4B6675A339C9E53520DFB92616"
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
    /// TelaNovaCompra
    /// </summary>
    public partial class TelaNovaCompra : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Janelas\NovaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG_ItensCompra;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Janelas\NovaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescricao;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Janelas\NovaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtValorUnitario;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Janelas\NovaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantidade;
        
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
            System.Uri resourceLocater = new System.Uri("/Compras.Desktop;component/janelas/novacompra.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Janelas\NovaCompra.xaml"
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
            this.DG_ItensCompra = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.txtDescricao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtValorUnitario = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\..\Janelas\NovaCompra.xaml"
            this.txtValorUnitario.GotFocus += new System.Windows.RoutedEventHandler(this.txtValorUnitario_GotFocus);
            
            #line default
            #line hidden
            
            #line 78 "..\..\..\..\Janelas\NovaCompra.xaml"
            this.txtValorUnitario.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtValorUnitario_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 79 "..\..\..\..\Janelas\NovaCompra.xaml"
            this.txtValorUnitario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtValorUnitario_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtQuantidade = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\..\Janelas\NovaCompra.xaml"
            this.txtQuantidade.GotFocus += new System.Windows.RoutedEventHandler(this.txtQuantidade_GotFocus);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\..\Janelas\NovaCompra.xaml"
            this.txtQuantidade.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtQuantidade_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 92 "..\..\..\..\Janelas\NovaCompra.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AdicionarItem);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 104 "..\..\..\..\Janelas\NovaCompra.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 105 "..\..\..\..\Janelas\NovaCompra.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

