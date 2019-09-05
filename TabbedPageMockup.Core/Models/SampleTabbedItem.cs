namespace TabbedPageMockup.Core.Models
{
    public class SampleTabbedItem
    {
        // TODO WTS: Remove this class once your pages/features are using your data.
        // It is the model class we use to display data on Tabbed pages.
        public int Index { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public SampleTabbedItem(int index, string header, string content)
        {
            Index = index;
            Header = header;
            Content = content;
        }
    }
}
