namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      Book book = new Book("Class Four");
      book.AddGrade(12.23);
      book.AddGrade(12.9);
      book.AddGrade(2.5);
      book.AddGrade(10);
      book.AddGrade(7.9);
      book.AddGrade(10.8);
      // statistics 
      book.showStatistics();
    }
  }
}
