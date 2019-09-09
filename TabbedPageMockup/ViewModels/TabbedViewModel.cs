﻿using System.Collections.ObjectModel;
using System.Linq;
using TabbedPageMockup.Helpers;
using TabbedPageMockup.Models;
using WinUI = Microsoft.UI.Xaml.Controls;

namespace TabbedPageMockup.ViewModels
{
    public class TabbedViewModel : Observable
    {
        private RelayCommand _addTabCommand;
        private RelayCommand<WinUI.TabViewTabCloseRequestedEventArgs> _closeTabCommand;

        public RelayCommand AddTabCommand => _addTabCommand ?? (_addTabCommand = new RelayCommand(AddTab));

        public RelayCommand<WinUI.TabViewTabCloseRequestedEventArgs> CloseTabCommand => _closeTabCommand ?? (_closeTabCommand = new RelayCommand<WinUI.TabViewTabCloseRequestedEventArgs>(CloseTab));

        public ObservableCollection<TabViewItemData> Tabs { get; } = new ObservableCollection<TabViewItemData>()
        {
            new TabViewItemData()
            {
                Index = 1,
                Header = "Item Martin 1",
                // In this sample the content shown in the Tab is a string, set the content to the model you want to show
                Content = "This is the content Sibille for Item 1."
            },
            new TabViewItemData()
            {
                Index = 2,
                Header = "Item Martin 2",
                Content = "This is the content Sibille for Item 2."
            },
            new TabViewItemData()
            {
                Index = 3,
                Header = "Item Martin 3",
                Content = "This is the content Sibille for Item 3."
            }
        };

        public TabbedViewModel()
        {
        }

        private void AddTab()
        {
            int newIndex = Tabs.Any() ? Tabs.Max(t => t.Index) + 1 : 1;
            Tabs.Add(new TabViewItemData()
            {
                Index = newIndex,
                Header = $"Item Martin {newIndex}",
                Content = $"This is the content Sibille for Item {newIndex}"
            });
        }

        private void CloseTab(WinUI.TabViewTabCloseRequestedEventArgs args)
        {
            if (args.Item is TabViewItemData item)
            {
                Tabs.Remove(item);
            }
        }
    }
}
