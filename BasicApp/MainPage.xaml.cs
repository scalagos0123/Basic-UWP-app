using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BasicApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            StackPanel input_panel = (StackPanel)this.FindName("Input");
            input_panel.Children.Remove((TextBlock)this.FindName("Fail"));

            TextBox uname_in = (TextBox)this.FindName("Username");
            PasswordBox pname_in = (PasswordBox)this.FindName("Password");

            String uname = uname_in.Text;
            String pword = pname_in.Password;

            if (uname == "shaun" && pword == "shaun")
            {
                Frame.Navigate(typeof (Login_Success), uname);
            } else
            {
                TextBlock fail = new TextBlock();
                fail.Name = "Fail";
                fail.Text = "Invalid username and password";
                input_panel.Children.Add(fail);
            }
        }
    }
}
