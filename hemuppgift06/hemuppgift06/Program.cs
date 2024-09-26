using System.Threading.Tasks;

namespace hemuppgift06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uppgift01-02
            /*
            Person person = new Person("", "", -1);

            person.GetFullName();
            */
            //uppgift03
            /*
            Book book = new Book();

            book.GetBookInfo();
            */
            //uppgift04
            /*
            Rectangle rectangle = new Rectangle(10.3, 17.6);
            {
                Console.WriteLine($"width: {rectangle.Width}\nheight: {rectangle.Height}\narea: {rectangle.Area}");
            }
            */
            //uppgift05
            /*
            Task task = new Task(Colour.green, Priority.low);
            Task task02 = new Task(Colour.yellow, Priority.medium);
            Task task03 = new Task(Colour.red, Priority.high);

            task.PrintDescription();
            task02.PrintDescription();
            task03.PrintDescription();
            */
            //uppgift06
            /*
            User admin = new User(UserRole.admin);
            User moderator = new User(UserRole.moderator);
            User user = new User(UserRole.user);
            User guest = new User(UserRole.guest);

            admin.PrintRoleMessage();
            moderator.PrintRoleMessage();
            user.PrintRoleMessage();
            guest.PrintRoleMessage();
            */
        }
    }
}
