﻿#pragma checksum "C:\Users\Mila I\Downloads\HotelReservation\HotelReservation\View\UserData.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5152F23FEA3F7770B6E09D93F24FFC14"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservation.View
{
    partial class UserData : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.usrNm = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.btnCatalog = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\View\UserData.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCatalog).Click += this.btnCatalog_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnSignOut = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\View\UserData.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSignOut).Click += this.btnSignOut_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
