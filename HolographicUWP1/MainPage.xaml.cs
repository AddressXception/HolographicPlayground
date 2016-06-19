using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HolographicUWP1
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

        /// <summary>
        /// https://msdn.microsoft.com/en-us/windows/uwp/layout/show-multiple-views
        /// https://forums.hololens.com/discussion/250/how-to-switch-from-2d-xaml-view-to-3d-holographic-view-directx
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DirectX_OnClick(object sender, RoutedEventArgs e)
        {
            var directX = new AppViewSource();

            CoreApplicationView newView = CoreApplication.CreateNewView(directX);
            ApplicationView newAppView = null;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                newAppView = ApplicationView.GetForCurrentView();
                CoreWindow.GetForCurrentThread().Activate();
            });

            await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newAppView.Id);
        }

        private void MonoGame_OnClick(object sender, RoutedEventArgs e)
        {
            var monoGame = new MonoGameViewSource();
            throw new NotImplementedException();
        }

        private void UrhoSharp_OnClick(object sender, RoutedEventArgs e)
        {
            var urho = new UrhoSharpViewSource();
            throw new NotImplementedException();
        }
    }
}
