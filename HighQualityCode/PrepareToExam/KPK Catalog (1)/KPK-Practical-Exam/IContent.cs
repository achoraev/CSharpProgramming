namespace CatalogOfFreeContent
{
	using System;

    public interface IContent : IComparable
    {
        string Title { get; set; }

        string Author { get; set; }

        Int64 Size { get; set; }

        string URL { get; set; }

        ct Type { get; set; }

        string TextRepresentation { get; set; }
    }
}