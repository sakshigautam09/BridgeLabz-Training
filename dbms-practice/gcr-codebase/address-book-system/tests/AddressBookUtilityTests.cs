using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AddressBookSystem.Tests
{
    [TestClass]
    public class AddressBookUtilityTests
    {
        private AddressBookUtilityImpl addressBook;

        [TestInitialize]
        public void Setup()
        {
            // Create a fresh AddressBookUtilityImpl before each test
            addressBook = new AddressBookUtilityImpl();
        }

        // -------------------- CRUD TESTS --------------------
        [TestMethod]
        public void AddContact_ShouldIncreaseCount()
        {
            addressBook.AddContactManually(new Contact(
                "John", "Doe", "123 St", "City", "State", "12345", "1234567890", "john@test.com"));

            var allContacts = addressBook.GetAllContacts();
            Assert.AreEqual(1, allContacts.Count);
            Assert.AreEqual("John", allContacts[0].GetFirstName());
        }

        [TestMethod]
        public void AddDuplicateContact_ShouldCatchException()
        {
            var contact = new Contact("Jane", "Doe", "Addr", "City", "State", "12345", "123", "jane@test.com");
            addressBook.AddContactManually(contact);

            bool exceptionThrown = false;
            try
            {
                addressBook.AddContactManually(contact);
            }
            catch (AddressBookException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown, "Expected AddressBookException for duplicate contact.");
        }

        [TestMethod]
        public void EditContact_ShouldUpdateDetails()
        {
            var contact = new Contact("Alice", "Smith", "Addr", "City", "State", "54321", "111111", "alice@test.com");
            addressBook.AddContactManually(contact);

            bool result = addressBook.EditContactManually("Alice", newPhone: "999999", newEmail: "alice@new.com");
            var edited = addressBook.GetAllContacts()[0];

            Assert.IsTrue(result);
            Assert.AreEqual("999999", edited.GetPhoneNumber());
            Assert.AreEqual("alice@new.com", edited.GetEmail());
        }

        [TestMethod]
        public void DeleteContact_ShouldRemoveContact()
        {
            var contact = new Contact("Bob", "Brown", "Addr", "City", "State", "11111", "2222", "bob@test.com");
            addressBook.AddContactManually(contact);

            bool deleted = addressBook.DeleteContactManually("Bob", "Brown");
            Assert.IsTrue(deleted);
            Assert.AreEqual(0, addressBook.GetAllContacts().Count);
        }

        // -------------------- SEARCH/COUNT --------------------
        [TestMethod]
        public void ViewPersonsByCityOrState_ShouldReturnCorrectContacts()
        {
            addressBook.AddContactManually(new Contact("Tom", "Lee", "Addr", "MetroCity", "StateX", "00001", "123", "tom@test.com"));
            addressBook.AddContactManually(new Contact("Jerry", "Lee", "Addr", "MetroCity", "StateX", "00002", "456", "jerry@test.com"));

            var filtered = addressBook.ViewPersonsByCityOrStateManually("MetroCity");
            Assert.AreEqual(2, filtered.Count);
        }

        [TestMethod]
        public void CountPersonsByCityOrState_ShouldReturnCorrectCount()
        {
            addressBook.AddContactManually(new Contact("Tom", "Lee", "Addr", "MetroCity", "StateX", "00001", "123", "tom@test.com"));
            addressBook.AddContactManually(new Contact("Jerry", "Lee", "Addr", "MetroCity", "StateX", "00002", "456", "jerry@test.com"));

            int count = addressBook.CountPersonsByCityOrStateManually("MetroCity");
            Assert.AreEqual(2, count);
        }

        // -------------------- SORTING --------------------
        [TestMethod]
        public void SortContactsByName_ShouldSortAlphabetically()
        {
            addressBook.AddContactManually(new Contact("Zara", "Alpha", "Addr", "City", "State", "111", "123", "zara@test.com"));
            addressBook.AddContactManually(new Contact("Aaron", "Beta", "Addr", "City", "State", "222", "456", "aaron@test.com"));

            addressBook.SortContactsByNameManually();
            var all = addressBook.GetAllContacts();

            Assert.AreEqual("Aaron", all[0].GetFirstName());
            Assert.AreEqual("Zara", all[1].GetFirstName());
        }

        // -------------------- EDGE CASES --------------------
        [TestMethod]
        public void DeleteNonExistentContact_ShouldCatchException()
        {
            bool exceptionThrown = false;
            try
            {
                addressBook.DeleteContactManually("NonExist", "Person");
            }
            catch (AddressBookException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown, "Expected AddressBookException for deleting non-existent contact.");
        }

        [TestMethod]
        public void SearchNonExistentPerson_ShouldReturnEmpty()
        {
            var results = addressBook.ViewPersonsByCityOrStateManually("Nowhere");
            Assert.AreEqual(0, results.Count);
        }
    }
}
