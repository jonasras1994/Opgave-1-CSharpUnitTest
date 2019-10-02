using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;

namespace BogTest
{
    [TestClass]
    public class UnitTest1
    {
        private Bog _bog;

        [TestInitialize]
        public void BeforeTest()
        {
            _bog = new Bog("Harry Potter", "J.K. Rowling", 99, "1234567890123");
        }
        [TestMethod]
        public void TestTitle()
        {
            Assert.AreEqual("Harry Potter", _bog.Title);
            _bog.Title = "Ringenes Herre";
            Assert.AreEqual("Ringenes Herre", _bog.Title);

            try
            {
                _bog.Title = "a";
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
               Assert.AreEqual("Title must have at least two characters!", ex.Message);
            }
        }

        [TestMethod]
        public void TestWriter()
        {
            Assert.AreEqual("J.K. Rowling", _bog.Writer);
            _bog.Writer = "J.K.K Tolkien";
            Assert.AreEqual("J.K.K Tolkien", _bog.Writer);

            try
            {
                _bog.Writer = null;
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Writer is empty or null", ex.Message);
            }
        }

        [TestMethod]
        public void TestPages()
        {
            Assert.AreEqual(99, _bog.Pages);
            _bog.Pages = 30;
            Assert.AreEqual(30, _bog.Pages);

            try
            {
                _bog.Pages = 9;
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Pages has to be between 10 and 100 pages", e.Message);
            }
        }

        [TestMethod]
        public void TestIsbn13()
        {
            Assert.AreEqual("1234567890123", _bog.Isbn13);
            _bog.Isbn13 = "8765432167890";
            Assert.AreEqual("8765432167890", _bog.Isbn13);

            try
            {
                _bog.Isbn13 = "123456789012";
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Isbn13 has to be 13 characters", e.Message);
            }

        }
    }
}
