namespace PhonebookApplication
{
    using System.Collections.Generic;

    interface IPhonebookRepository
    {
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);
        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);
        CompareNames[] ListEntries(int startIndex, int count);

    }
}