namespace TabbedPageMockup.Models
{
    public class TabbedItem
    {
        public int Index { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public TabbedItem(int index, string header, string content)
        {
            Index = index;
            Header = header;
            Content = content;
        }
    }
}
