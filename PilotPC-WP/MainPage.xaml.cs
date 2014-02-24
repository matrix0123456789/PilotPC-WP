using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PilotPC_WP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Image_Tap_1(object sender, GestureEventArgs e)
        {
            if (menu.Height == 77)
                menu.Height = LayoutRoot.ActualHeight * .9;
            else
                menu.Height = 77;
        }
    }
}