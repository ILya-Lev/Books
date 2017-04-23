using System.ComponentModel.DataAnnotations;

namespace Books.Entities
{
	public enum Genre
	{
		[Display(Name = "Non Fiction")]
		NonFiction,
		Action,
		Romance,
		[Display(Name = "Science Fiction")]
		ScienceFiction
	}
}