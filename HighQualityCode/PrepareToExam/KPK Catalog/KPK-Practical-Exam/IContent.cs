namespace CatalogOfFreeContent
{
    using System;

    public interface IContent : IComparable
    {
        string Title { get; set; }

        string Author { get; set; }

        long Size { get; set; }

        string Url { get; set; }

        Content Type { get; set; }

        string TextRepresentation { get; set; }
    }
}