﻿#pragma checksum "C:\Users\alber\source\repos\proyecto_uwp\proyecto_uwp\partidos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E86B621C69074BE52783F2D901DEE94F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto_uwp
{
    partial class partidos : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // partidos.xaml line 11
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // partidos.xaml line 12
                {
                    this.comboEquipo1 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.comboEquipo1).SelectionChanged += this.comboEquipo1_SelectionChanged;
                }
                break;
            case 4: // partidos.xaml line 13
                {
                    this.botonVolver = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.botonVolver).Click += this.clickVolver;
                }
                break;
            case 5: // partidos.xaml line 14
                {
                    this.comboEquipo2 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.comboEquipo2).SelectionChanged += this.comboEquipo2_SelectionChanged;
                }
                break;
            case 6: // partidos.xaml line 15
                {
                    this.guardarPartido = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.guardarPartido).Click += this.guardarPartido_Click;
                }
                break;
            case 7: // partidos.xaml line 16
                {
                    this.textoAlert = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // partidos.xaml line 17
                {
                    this.goles_locales = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // partidos.xaml line 18
                {
                    this.goles_visitante = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
