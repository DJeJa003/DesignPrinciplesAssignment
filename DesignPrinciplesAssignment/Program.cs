using static DesignPrinciplesAssignment.User;

namespace DesignPrinciplesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design principles assignment: See assignment.cs files for assignments");

            //SRP
            User user = new User("John", "test");
            UserRepository userRepository = new UserRepository();

            userRepository.SaveUser(user);
        }
    }
}
