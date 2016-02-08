using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //var button = new Button
            //{ Background = new SolidColorBrush(Colors.PeachPuff) };

            //var stackPanel = new StackPanel { Orientation = Orientation.Horizontal };
            //stackPanel.Children.Add(new SymbolIcon { Symbol = Symbol.Save });
            //stackPanel.Children.Add(new TextBlock { Text = "Save", Margin = new Thickness { Left = 5 } });

            //button.Content = stackPanel;

            //myGrid.Children.Add(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myText.Text = "Inner Button Clicked";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myText.Text = "Outer Button Clicked";
        }
    }
}
