using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanhBuoi3
{
	public class Book
	{
		public string ISBN { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public float Price { get; set; }
		public int YearPublished { get; set; }

		public Book(string isbn, string title, string author, float price, int yearPublished)
		{
			ISBN = isbn;
			Title = title;
			Author = author;
			Price = price;
			YearPublished = yearPublished;
		}
		public override string ToString()
		{
			return $"{ISBN} {Title} {Author} {Price} {YearPublished}";
		}
	}
}
