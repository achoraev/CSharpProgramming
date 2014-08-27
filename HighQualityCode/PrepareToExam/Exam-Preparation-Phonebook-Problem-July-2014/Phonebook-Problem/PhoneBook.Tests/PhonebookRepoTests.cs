namespace PhoneBook.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PhonebookApplication;
    using System.Collections.Generic;

    [TestClass]
    public class PhonebookRepoTests
    {
        [TestMethod]
        public void TestMethodAddPhones()
        {
            var newPhonebook = new PhonebookRepository();
            string[] numbers = {"(+359) 899777236"};                   
            newPhonebook.AddPhone("KALINA", numbers);

            Assert.AreEqual(1, numbers.Length);
            Assert.IsTrue(newPhonebook.AddPhone("KALINA", numbers) == false);
        }
    }
}
