using Exercise1;
using Exercise2;
using System.Collections.Generic;
using static System.Console;

Console.WriteLine("Exercise 1 Test Program.....");

// Create an instance of the Library class called "myLibrary"
var libarary = new Library("myLibrary", new List<Book>());

//Add a few books to the library using the AddBook() method
libarary.AddBook(new Book("book1", "Author1", 1992));
libarary.AddBook(new Book("book2", "Author2", 1992));
libarary.AddBook(new Book("book3", "Author3", 1992));

//Display the list of books in the library using the DisplayBooks() method.
libarary.DisplayBooks();
WriteLine("-----------------------------------------");

//Borrow a book using the BorrowBook() method.
libarary.BorrowBook("book1");
WriteLine("-----------------------------------------");

//Display the library's book list again to check the book's status.
libarary.DisplayBooks();
WriteLine("-----------------------------------------");

//Return the borrowed book using the ReturnBook() method.
libarary.ReturnBook("book1");
WriteLine("-----------------------------------------");

//Display the book list again to check the book's status.
libarary.DisplayBooks();
WriteLine("-----------------------------------------");

//Search for a specific book using the FindBook() method and display its information.
var searchedBook = libarary.FindBook("book1");
WriteLine(searchedBook.ToString());

Console.WriteLine("Exercise 2 Test Program......");

var company = new Company();
company.Name = "Company A";
company.Employees = new List<Employee>();

var employeeA = new Employee("Employee A", 100);
employeeA.CalculateSalary(8);
company.AddEmployee(employeeA);

var employeeB = new Employee("Employee B", 200);
employeeB.CalculateSalary(8);
company.AddEmployee(employeeB); ;

var managerA = new Manager("Manager A", 500, 500);
managerA.CalculateSalary(8);
company.AddEmployee(managerA);

company.DisplayEmployees();

