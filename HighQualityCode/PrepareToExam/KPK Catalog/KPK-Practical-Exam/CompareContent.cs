namespace CatalogOfFreeContent
{
    using System;

    public class CompareContent : IContent, IComparable
    {
        private string url;

        public CompareContent(Content type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)Info.Title];
            this.Author = commandParams[(int)Info.Author];
            this.Size = long.Parse(commandParams[(int)Info.Size]);
            this.Url = commandParams[(int)Info.Url];
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public long Size { get; set; }

        public Content Type { get; set; }

        public string TextRepresentation { get; set; }

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString();
            }
        }

        public int CompareTo(object obj)
        {
            // if (null == obj)
            // {
            //    return 1;
            // }

            // CompareContent otherContent = obj as CompareContent;
            // if (otherContent != null)
            // {
            //    int comparisonResul = this.TextRepresentation.CompareTo(otherContent.TextRepresentation);

            // return comparisonResul;
            // }

            // throw new ArgumentException("Object is not a Content");
            return 0;
        }

        public override string ToString()
        {
            string output = string.Format("{0}: {1}; {2}; {3}; {4}", this.Type.ToString(), this.Title, this.Author, this.Size, this.Url);

            return output;
        }
    }
}