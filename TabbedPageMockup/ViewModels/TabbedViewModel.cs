using System.Collections.ObjectModel;
using System.Linq;
using TabbedPageMockup.Helpers;
using TabbedPageMockup.Core.Models;

namespace TabbedPageMockup.ViewModels
{
    public class TabbedViewModel : Observable
    {
        private RelayCommand _addTabCommand;

        public RelayCommand AddTabCommand => _addTabCommand ?? (_addTabCommand = new RelayCommand(AddTab));

        public ObservableCollection<SampleTabbedItem> Tabs { get; } = new ObservableCollection<SampleTabbedItem>()
        {
            new SampleTabbedItem(1, "Item 1", "This is the Item 1 content."),
            new SampleTabbedItem(2, "Item 2", "This is the Item 2 content."),
            new SampleTabbedItem(3, "Item 3", "This is the Item 3 content.")
        };

        public TabbedViewModel()
        {
        }

        private void AddTab()
        {
            int newIndex = Tabs.Any() ? Tabs.Max(t => t.Index) + 1 : 1;
            Tabs.Add(new SampleTabbedItem(newIndex, $"Item {newIndex}", $"This is the Item {newIndex} content."));
        }
    }
}
