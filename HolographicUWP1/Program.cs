using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;

namespace HolographicUWP1
{
    class Program1
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        [MTAThread]
        private static void Main()
        {
            global::Windows.UI.Xaml.Application.Start((p) => new App());

            //var exclusiveViewApplicationSource = new AppViewSource();
            //CoreApplication.Run(exclusiveViewApplicationSource);
        }
    }
}
