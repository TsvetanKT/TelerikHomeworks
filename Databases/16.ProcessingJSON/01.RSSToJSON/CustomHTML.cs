namespace RSSToJSON
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CustomHTML
    {
        private const string ItemTemplate = "<li><a href=\"{0}\">[{1}] {2} ({3})</a></li>";

        public string GenerateHtml(IEnumerable<Unit> listItems)
        {
            var html = new StringBuilder();

            html.AppendLine("<ul>");

            foreach (var item in listItems)
            {
                html.AppendFormat(
                    ItemTemplate,
                    item.Link,
                    item.Category,
                    item.Title,
                    item.PubDate.ToShortDateString());
            }

            html.AppendLine("<ul>");
            return html.ToString();
        }
    }
}
