// Updated by XamlIntelliSenseFileGenerator 02/03/2020 21:26:56
#pragma checksum "..\..\..\NovaCompra.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "499E0F267CA71741C856B587EC1A30EE195F34A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Desktop;
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


namespace Desktop
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Desktop;component/novacompra.xaml", System.UriKind.Relative);

#line 1 "..\..\..\NovaCompra.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.CadastrarCompra = ((System.Windows.Controls.Button)(target));

#line 10 "..\..\..\NovaCompra.xaml"
                    this.CadastrarCompra.Click += new System.Windows.RoutedEventHandler(this.CadastrarCompra_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.TBDescricaoCompra = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.DPDataCompra = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 4:
                    this.GridItens = ((System.Windows.Controls.Grid)(target));
                    return;
                case 5:
                    this.Itens = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 6:
                    this.Btn_NovoItem = ((System.Windows.Controls.Button)(target));

#line 23 "..\..\..\NovaCompra.xaml"
                    this.Btn_NovoItem.Click += new System.Windows.RoutedEventHandler(this.CadastrarItem_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.LbDescricaoItem = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.TB_DescricaoItem = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:
                    this.TB_ValorUnitarioItem = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 10:
                    this.TB_QtdItem = ((System.Windows.Controls.TextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

