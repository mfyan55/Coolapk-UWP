using CoolapkUWP.Control.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CoolapkUWP.Control
{
    public class FirstTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DataTemplate1 { get; set; }
        public DataTemplate DataTemplate2 { get; set; }
        public DataTemplate DataTemplate3 { get; set; }
        public DataTemplate DataTemplate4 { get; set; }
        public DataTemplate DataTemplate5 { get; set; }
        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is FeedViewModel) return DataTemplate1;
            else if (item is UserViewModel) return DataTemplate3;
            else if (item is TopicViewModel) return DataTemplate4;
            else if (item is DyhViewModel) return DataTemplate5;
            return DataTemplate2;
        }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) => SelectTemplateCore(item);
    }
    public class SecondTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DataTemplate0 { get; set; }
        public DataTemplate DataTemplate1 { get; set; }
        public DataTemplate DataTemplate2 { get; set; }
        public DataTemplate DataTemplate3 { get; set; }
        public DataTemplate DataTemplate4 { get; set; }
        public DataTemplate DataTemplate5 { get; set; }
        public DataTemplate DataTemplate6 { get; set; }
        public DataTemplate DataTemplate7 { get; set; }
        public DataTemplate DataTemplate8 { get; set; }
        public DataTemplate DataTemplate9 { get; set; }
        protected override DataTemplate SelectTemplateCore(object item)
        {
            switch ((item as IndexPageViewModel).entityTemplate)
            {
                default: return DataTemplate0;
                case "imageTextGridCard":
                case "imageCarouselCard_1":
                case "imageSquareScrollCard":
                case "iconScrollCard":
                case "imageTextScrollCard":
                case "feedScrollCard": return DataTemplate2;
                case "textCard":
                case "messageCard": return DataTemplate3;
                case "refreshCard": return DataTemplate4;
                case "textLinkListCard": return DataTemplate5;
                case "iconGridCard":
                case "iconMiniGridCard":
                case "iconMiniLinkGridCard":
                case "iconLinkGridCard": return DataTemplate6;
                case "iconTabLinkGridCard": return DataTemplate7;
                case "selectorLinkCard": return DataTemplate8;
                case "imageCard": return DataTemplate9;
            }
        }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) => SelectTemplateCore(item);
    }
    public class ThirdTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DataTemplate0 { get; set; }
        public DataTemplate DataTemplate1 { get; set; }
        public DataTemplate DataTemplate2 { get; set; }
        public DataTemplate DataTemplate3 { get; set; }
        public DataTemplate DataTemplate4 { get; set; }
        public DataTemplate DataTemplate5 { get; set; }
        public DataTemplate DataTemplate6 { get; set; }
        public DataTemplate DataTemplate7 { get; set; }
        public DataTemplate DataTemplate8 { get; set; }
        public DataTemplate DataTemplate9 { get; set; }
        public DataTemplate DataTemplate10 { get; set; }
        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is FeedViewModel f)
            {
                if (f.isQuestionFeed) return DataTemplate6;
                else if (f.showMessage_title) return DataTemplate5;
            }
            else if (item is UserViewModel) return DataTemplate8;
            else switch ((item as IndexPageViewModel).entityType)
                {
                    case "image_1": return DataTemplate1;
                    case "icon":
                    case "iconMiniLink":
                    case "iconLink": return DataTemplate2;
                    case "dyh": return DataTemplate3;
                    case "topic": return DataTemplate4;
                    case "textLink": return DataTemplate7;
                    case "imageSquare": return DataTemplate9;
                    case "imageText": return DataTemplate10;
                }
            return DataTemplate0;
        }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) => SelectTemplateCore(item);
    }
    public class SearchPageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DataTemplate1 { get; set; }
        public DataTemplate DataTemplate2 { get; set; }
        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is AppViewModel) return DataTemplate1;
            return DataTemplate2;
        }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) => SelectTemplateCore(item);
    }
}
