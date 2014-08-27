namespace CatalogOfFreeContent
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Wintellect.PowerCollections;
		
	public class ca : ICatalog
    {
        private MultiDictionary<string, IContent> url;
        private OrderedMultiDictionary<string, IContent> title;

        public ca()
        {
            bool allowDuplicateValues = true;
            this.title = new OrderedMultiDictionary<string, IContent>(allowDuplicateValues);
            this.url = new MultiDictionary<string, IContent>(allowDuplicateValues);
        }

        public void Add(IContent content)
        {
            this.title.Add(content.Title, content);
            this.url.Add(content.URL, content);
        }

        public IEnumerable<IContent> GetListContent(string title, Int32 numberOfContentElementsToList)
        {
            IEnumerable<IContent> contentToList = from c in this.title[title] select c;

            return contentToList.Take(numberOfContentElementsToList);
        }

        public Int32 UpdateContent(string old, string newUrl)
        {
            Int32 theElements = 0;

            List<IContent> contentToList = this.url[old].ToList();

            foreach (co content in contentToList)
            {
                this.title.Remove(content.Title, content);
                theElements++; //increase updatedElements
            }
            this.url.Remove(old);
            
            foreach (IContent content in contentToList)
            {
				content.URL = newUrl;
                this.title.Add(content.Title, content);
                this.url.Add(content.URL, content);
            }

            return theElements;
        }
    }   		
}