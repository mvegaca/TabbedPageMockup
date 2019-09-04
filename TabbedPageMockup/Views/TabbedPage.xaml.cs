using System;

using TabbedPageMockup.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TabbedPageMockup.Views
{
    public sealed partial class TabbedPage : Page
    {
        public TabbedViewModel ViewModel { get; } = new TabbedViewModel();

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
