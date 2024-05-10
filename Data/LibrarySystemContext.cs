using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models;

namespace LibrarySystem.Data
{
    public class LibrarySystemContext : DbContext
    {
        public LibrarySystemContext (DbContextOptions<LibrarySystemContext> options)
            : base(options)
        {
        }

        public DbSet<LibrarySystem.Models.Customer> Customer { get; set; } = default!;
        public DbSet<LibrarySystem.Models.Book> Book { get; set; } = default!;
        public DbSet<LibrarySystem.Models.BookLoan> BookLoans { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for customers
            modelBuilder.Entity<LibrarySystem.Models.Customer>().HasData(
                new LibrarySystem.Models.Customer
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john@example.com",
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new LibrarySystem.Models.Customer
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Email = "jane@example.com",
                    DateOfBirth = new DateTime(1985, 5, 20)
                }
            );

            // Seed data for books
            modelBuilder.Entity<LibrarySystem.Models.Book>().HasData(
                new LibrarySystem.Models.Book
                {
                    Id = 1,
                    Title = "Critique of Pure Reason",
                    Author = "Immanuel Kant",
                    IsReturned = true
                },
                new LibrarySystem.Models.Book
                {
                    Id = 2,
                    Title = "How to Read a Book",
                    Author = "Mortimer J. Adler",
                    IsReturned = false
                }
            );

            modelBuilder.Entity<LibrarySystem.Models.BookLoan>().HasData(
                new LibrarySystem.Models.BookLoan
                {
                    Id = 1,
                    CustomerId = 1,
                    BookId = 2,
                    LoanDate = new DateTime(2023, 5, 1),
                    ReturnDate = null
                }
            );
        }
    }
}
