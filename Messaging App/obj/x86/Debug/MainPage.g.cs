﻿#pragma checksum "C:\Users\microsoft\Downloads\azure\Messaging App\Messaging App\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FEB1129770567193A44EAC3B6F9BB53B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Messaging_App {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot myPivot;
        
        internal Microsoft.Phone.Controls.PivotItem myChats;
        
        internal Microsoft.Phone.Controls.LongListSelector MainLongListSelector;
        
        internal Microsoft.Phone.Controls.PivotItem myFav;
        
        internal System.Windows.Controls.ListBox myListBox;
        
        internal Microsoft.Phone.Controls.PivotItem myCon;
        
        internal Microsoft.Phone.Controls.LongListSelector AddrBook;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Messaging%20App;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.myPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("myPivot")));
            this.myChats = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("myChats")));
            this.MainLongListSelector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("MainLongListSelector")));
            this.myFav = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("myFav")));
            this.myListBox = ((System.Windows.Controls.ListBox)(this.FindName("myListBox")));
            this.myCon = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("myCon")));
            this.AddrBook = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("AddrBook")));
        }
    }
}

