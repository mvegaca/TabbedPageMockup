using System;

using TabbedPageMockup.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TabbedPageMockup.Views
{
    public sealed partial class PivotPage : Page
    {
        public PivotViewModel ViewModel { get; } = new PivotViewModel();

        public PivotPage()
        {
            InitializeComponent();
        }
    }
}
