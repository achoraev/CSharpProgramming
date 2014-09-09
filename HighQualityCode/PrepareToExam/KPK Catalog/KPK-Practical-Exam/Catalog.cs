namespace CatalogOfFreeContent
{
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Catalog : ICatalog
    {
        private MultiDictionary<string, IContent> url;
        private OrderedMultiDictionary<string, IContent> title;

        public Catalog()
        {
            bool allowDuplicateValues = true;
            this.title = new OrderedMultiDictionary<string, IContent>(allowDuplicateValues);
            this.url = new MultiDictionary<string, IContent>(allowDuplicateValues);
        }

        public void Add(IContent content)
        {
            this.title.Add(content.Title, content);
            this.url.Add(content.Url, content);
        }

        public IEnumerable<IContent> GetListContent(string title, int numberOfContentElementsToList)
        {
            IEnumerable<IContent> contentToList = from c in this.title[title] select c;

            return contentToList.Take(numberOfContentElementsToList);
        }

        public int UpdateContent(string oldUrl, string newUrl)
        {
            int elementsCount = 0;

            List<IContent> contentToList = this.url[oldUrl].ToList();

            foreach (CompareContent content in contentToList)
            {
                this.title.Remove(content.Title, content);
                elementsCount++;
            }

            this.url.Remove(oldUrl);

            foreach (IContent content in contentToList)
            {
                content.Url = newUrl;
                this.title.Add(content.Title, content);
                this.url.Add(content.Url, content);
            }

            return elementsCount;
        }
    }
}