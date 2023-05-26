using _26_5._1;

class program
{
    static void Main(string[] args)
    {
        book book1 = new book("Life of Pi", "micahel", 1996,"Sience Figtion");
        Console.WriteLine(book1.ToString());

        magazine magazine1 = new magazine("Sport","owen",2001,3600);
        Console.WriteLine(magazine1.ToString());

        dvd dvd1 = new dvd("Tom and Jerry", "Bathesa", 1993, "plastic");
        Console.WriteLine(dvd1.ToString());
    }
}