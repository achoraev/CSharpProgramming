namespace CatalogOfFreeContent
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

    public enum comt
    {
        AddBook,
        AddMovie, 
		AddSong,
        AddApplication,
        Update, 
		Find,
    }
    public enum ct
    {
        Kniga,
        Film,
        Muzika,
        Prilozenie,
    }

    public enum acpi
    {
        Title = 0,
        Author,
        Size,
        Url,
    }
}