namespace LibrarySystem.Models;

public class BookLoan
{
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public int BookId { get; set; }
    public Book? Book { get; set; }

    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}
