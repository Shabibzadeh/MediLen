﻿#pragma checksum "D:\__4WebHost\GitHub\SLJs\SLJs\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1095BF312366B8D183C1F0A6B6218DD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace CamGaze {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.WebBrowser browser;
        
        internal System.Windows.Controls.Grid StatusGrid;
        
        internal System.Windows.Controls.Button LobBrowser;
        
        internal System.Windows.Controls.Button OobBrowser;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SLJs;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.browser = ((System.Windows.Controls.WebBrowser)(this.FindName("browser")));
            this.StatusGrid = ((System.Windows.Controls.Grid)(this.FindName("StatusGrid")));
            this.LobBrowser = ((System.Windows.Controls.Button)(this.FindName("LobBrowser")));
            this.OobBrowser = ((System.Windows.Controls.Button)(this.FindName("OobBrowser")));
        }
    }
}

