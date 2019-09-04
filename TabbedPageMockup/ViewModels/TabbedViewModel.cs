using System.Collections.ObjectModel;
using System.Linq;
using TabbedPageMockup.Helpers;
using TabbedPageMockup.Models;

namespace TabbedPageMockup.ViewModels
{
    public class TabbedViewModel : Observable
    {
        private RelayCommand _addTabCommand;

        public RelayCommand AddTabCommand => _addTabCommand ?? (_addTabCommand = new RelayCommand(AddTab));

        public ObservableCollection<TabbedItem> Tabs { get; } = new ObservableCollection<TabbedItem>()
        {
            new TabbedItem(1, "Item 1", "This is the Item 1 content."),
            new TabbedItem(2, "Item 2", "This is the Item 2 content."),
            new TabbedItem(3, "Item 3", "This is the Item 3 content.")
        };

        public TabbedViewModel()
        {
        }

        private void AddTab()
        {
            int newIndex = Tabs.Max(t => t.Index) + 1;
            Tabs.Add(new TabbedItem(newIndex, $"Item {newIndex}", $"This is the Item {newIndex} content."));
        }
    }
}
