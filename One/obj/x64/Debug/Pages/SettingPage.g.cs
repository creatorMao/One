﻿#pragma checksum "D:\study\uwpProjects\One\One\Pages\SettingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C25C8F8D2A1C0E839FA62F34B16AA21D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace One.Pages
{
    partial class SettingPage : 
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
                    this.IsTileToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 93 "..\..\..\Pages\SettingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.IsTileToggleSwitch).Toggled += this.SettingToggled;
                    #line default
                }
                break;
            case 2:
                {
                    this.IsToastToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 127 "..\..\..\Pages\SettingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.IsToastToggleSwitch).Toggled += this.SettingToggled;
                    #line default
                }
                break;
            case 3:
                {
                    this.ThemeToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 161 "..\..\..\Pages\SettingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.ThemeToggleSwitch).Toggled += this.SettingToggled;
                    #line default
                }
                break;
            case 4:
                {
                    this.LanguageSwitchComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 186 "..\..\..\Pages\SettingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.LanguageSwitchComboBox).SelectionChanged += this.LanguageSwitchComboBox_SelectionChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.Folder = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 205 "..\..\..\Pages\SettingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Folder).PointerPressed += this.OpenFolder;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 212 "..\..\..\Pages\SettingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.SetNewFolder;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 231 "..\..\..\Pages\SettingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.ReStoreDefaultSetting;
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

