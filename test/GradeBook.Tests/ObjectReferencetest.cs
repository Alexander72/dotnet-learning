using System;
using Xunit;

namespace GradeBook.Tests
{
    public class ObjectReferencetest
    {
        [Fact]
        public void TestStringPassingAsAnArgument()
        {
            string alex = "alex";
            string upperCased = ToUperCase(alex);

            Assert.Equal("alex", alex);
            Assert.Equal("ALEX", upperCased);
        }

        private string ToUperCase(string s)
        {
            return s.ToUpper();
        }

        [Fact]
        public void TestPassingSimpleTypes()
        {
            int x = GetInt();

            SetInt(x);
            Assert.Equal(3, x);

            SetIntByReference(ref x);
            Assert.Equal(42, x);

            SetIntByOutput(out int z);
            Assert.Equal(42, z);
        }

        private void SetInt(int x)
        {
            x = 42;
        }
           

        private void SetIntByReference(ref int x)
        {
            x = 42;
        }
           

        private void SetIntByOutput(out int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void TestDifferrentReferences()
        {
            GradeBook book1 = new GradeBook("book 1");
            GradeBook book2 = new GradeBook("book 2");

            Assert.Same("book 1", book1.name);
            Assert.Same("book 2", book2.name);
        }

        [Fact]
        public void TestChangeDataByReference()
        {
            GradeBook book = new GradeBook("book 1");
            
            this.SetName(book, "new name");
            Assert.Same("new name", book.name);

            this.CreateNewBookAndSetName(book, "new name 1");
            Assert.Same("new name", book.name);

            this.CreateNewBookAndSetNameByReference(ref book, "new name 2");
            Assert.Same("new name 2", book.name);

            this.CreateNewBookAndSetNameByOutput(out GradeBook newBook, "new name 3");
            Assert.Same("new name 3", newBook.name);
        }

        private void SetName(GradeBook book, string name)
        {
            book.name = name;
        }

        private void CreateNewBookAndSetName(GradeBook book, string name)
        {
            book = new GradeBook(name);
        }

        private void CreateNewBookAndSetNameByReference(ref GradeBook book, string name)
        {
            book = new GradeBook(name);
        }

        private void CreateNewBookAndSetNameByOutput(out GradeBook book, string name)
        {
            book = new GradeBook(name);
        }

        [Fact]
        public void TestSameObjects()
        {
            GradeBook book1 = new GradeBook("book 1");
            GradeBook book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
    }
}
