﻿#pragma checksum "C:\Users\microsoft\Downloads\azure\Messaging App\Messaging App\ChatPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C058D01717A96B41CED3A8E6F195A54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
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
    
    
    public partial class ChatPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Primitives.Popup popupAddCourse;
        
        internal System.Windows.Controls.TextBox txtCourseDetails;
        
        internal System.Windows.Controls.Button SendButton;
        
        internal System.Windows.Controls.Button cancelButton;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.ItemsControl ChatList;
        
        internal Coding4Fun.Toolkit.Controls.ChatBubbleTextBox txtMessage;
        
        internal System.Windows.Controls.Button btnSend;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Messaging%20App;component/ChatPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.popupAddCourse = ((System.Windows.Controls.Primitives.Popup)(this.FindName("popupAddCourse")));
            this.txtCourseDetails = ((System.Windows.Controls.TextBox)(this.FindName("txtCourseDetails")));
            this.SendButton = ((System.Windows.Controls.Button)(this.FindName("SendButton")));
            this.cancelButton = ((System.Windows.Controls.Button)(this.FindName("cancelButton")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.ChatList = ((System.Windows.Controls.ItemsControl)(this.FindName("ChatList")));
            this.txtMessage = ((Coding4Fun.Toolkit.Controls.ChatBubbleTextBox)(this.FindName("txtMessage")));
            this.btnSend = ((System.Windows.Controls.Button)(this.FindName("btnSend")));
        }
    }
}

