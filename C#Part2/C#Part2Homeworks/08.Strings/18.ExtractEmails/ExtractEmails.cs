using System;
using System.Text.RegularExpressions;
// Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class ExtractEmails
{
    static void Main()
    {
        string text =
        @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
	Fusce viverra, erat nec volutpat convallis, lectus arcu interdum justo, 
	in suscipit lacus dolor at ante. Quisque quis lacus arcu.Pellentesque 
	Impad1945@superrito.com consectetur elementum sem Broure256@armyspy.com, sed vehicula sapien.
	Aliquamfermentum pellentesque urna at egestas. Morbi eu dui auctor, fermentum 
	ZThaters32@rhyta.com nulla nec, posuere lacus. Curabitur nisl sem, 
	semper eu vehicula ut,pharetra a nisl. 
	Vestibulum RArly1960@gustr.com bibendum nisl in massa hendrerit, nec pharetradui vehicula. 
	Aread101@cuvox.de Nunc volutpat turpis vitae eros pharetra semper. 
	Morbivitae ante sed nisi consequat posuere. Dered1934@superrito.com 
	Suspendisse consectetur posuereconvallis. Ut vitae hendrerit sapien, eu hendrerit leo. 
	In felis purus, QMances6060@einrot.comdictum et turpis ac, lacinia 
	SDaunt1960@gustr.com suscipit purus. Duis id ipsum interdum,consequat quam non, ultrices mauris. 
	Etiam tincidunt blandit tortor.";

        MatchCollection matchList = Regex.Matches(text, @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"); 
        foreach (Match sentence in matchList)
        {
            Console.WriteLine(sentence);
        }
    }
}