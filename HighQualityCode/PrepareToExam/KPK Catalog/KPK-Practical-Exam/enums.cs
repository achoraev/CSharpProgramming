namespace CatalogOfFreeContent
{

    public enum Commands
    {
        AddBook,
        AddMovie,
        AddSong,
        AddApplication,
        Update,
        Find,
    }

    public enum Content
    {
        Book,
        Movie,
        Song,
        Application,
    }

    public enum Info
    {
        Title = 0,
        Author,
        Size,
        Url,
    }
}