using System;

namespace ObligatoriskOpgave
{
    public class Bog
    {
        public Bog _bog;

        public string _title;
        public string _writer;
        public int _pages;
        public string _isbn13;


        public string Title
        {
            get { return _title; }
            set
            {
                CheckTitle(value);
                _title = value;
            }
        }

        public string Writer
        {
            get { return _writer; }
            set
            {
                CheckWriter(value);
                _writer = value;
            }
        }

        public int Pages
        {
            get { return _pages; }
            set
            {
                CheckPages(value);
                _pages = value;
            }
        }

        public string Isbn13
        {
            get { return _isbn13; }
            set
            {   CheckIsbn13(value);
                _isbn13 = value;
            }
        }
        public Bog(string title, string writer, int pages, string isbn13)
        {
            CheckTitle(title);
            CheckWriter(writer);
            CheckPages(pages);
            CheckIsbn13(isbn13);
            Title = title;
            Writer = writer;
            Pages = pages;
            Isbn13 = isbn13;
        }

        public void CheckTitle(string title)
        {
            if (title.Length < 2)
            {
                throw new ArgumentException("Title must have at least two characters!");
            }
        }

        public void CheckWriter(string writer)
        {
            if (string.IsNullOrWhiteSpace(writer))
            {
                throw new ArgumentException("Writer is empty or null");
            }
        }

        public void CheckPages(int pages)
        {
            if (pages < 10 || pages > 100)
            {
                throw new ArgumentException("Pages has to be between 10 and 100 pages");
            }
        }

        public void CheckIsbn13(string isbn13)
        {
            if (isbn13.Length != 13)
            {
                throw  new ArgumentException("Isbn13 has to be 13 characters");
            }
        }
    }
}
