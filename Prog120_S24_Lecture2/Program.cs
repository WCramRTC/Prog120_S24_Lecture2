namespace Prog120_S24_Lecture2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Console.ReadLine();

            // Asked for the users name
            Console.Write("Enter your name: ");
            // string variable to hold value that is being returned from Console.ReadLine();
            string userName = Console.ReadLine();

            // Ask for the date
            Console.Write("What is the date? ");
            string userDate = Console.ReadLine();
            // $ - String Interpolation
            // $"{placeholder}"

            // Ask for the class
            Console.Write("What is the class? ");
            string userClass = Console.ReadLine();

            // William Cram
            // 04 04 2024
            // Programming 1
            Console.WriteLine("// " + userName);
            Console.WriteLine($"//  {userDate}");
            Console.WriteLine($"// {userClass}");

            //Console.WriteLine("// " + userName);
            //Console.WriteLine($"//  {DateTime.Now.ToLongDateString()}");
            //Console.WriteLine($"// {userClass}");
            // $ 
            // @

            // Console.ReadKey();

        } // End of Main

          // Will Cram
          //  04 04 24
          // Programming 1
        public static void StringExample()
        {
            // Variables
            // type
            // string, bool, int, double
            // String - A collection of characters
            // A string is defined with double quotes

            // Declaring and initializing a variable
            // equal sign, = , assignment operator
            string teachersName = "Will";

            // Declare a variable
            // Naming convention for variables
            string futureProgrammer;
            string favoriteGame = "Tears of the Kingdom";

            string x, q, y, XX, t, u;

            // Declaring multiple variables of the same type in one line
            string student1, student2, student3;

            // Cannot use a variable before it's been declared
            string bestWindInstrument;
            bestWindInstrument = "Flute";


            Console.Write("Hello, ");
            Console.WriteLine(teachersName);

            teachersName = "Hoang";

            Console.Write("Hello, ");
            Console.WriteLine(teachersName);

            // Debugger
            // git commit -m "Update"
            // Concatenate
            // Adding two strings together to form one long string
            string firstName = "Will";
            string lastName = "Cram";


            Console.Write(firstName + " " + lastName);

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            firstName = "Vitalli";
            lastName = "Bobyr";
            fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            // Console.ReadLine()
        } // End of String Example

        // public static void Name() { }
        public static void Practice()
        {
            Console.WriteLine("Benny Goodman");
            Console.WriteLine("--------------");
            Console.WriteLine("Where and When");
            Console.WriteLine("Sing, Sing, Sing");

            // Console.WriteLine()
            // Console.Write()

            // Curly Brace

            // Error
            // Compile Time Error

            // Comments
        } // End of practice

    } // end of class

} // end of namespace
