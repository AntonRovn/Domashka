class Program
{
    //Program to show logical operations, primitive data types
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your gender, Type M for Man,  W for Woman");
        char gender = Console.ReadLine()[0];
        if ((gender == 'M') || (gender == 'W'))
        {
            if (gender == ('W'))
            {
                string result = (age < 40) ? "Hello Miss. " : "Hello Mrs.";
                Console.WriteLine(result + name);
            }
            else
                Console.WriteLine("Hello Mister " + name);
        }
        else
        {
            Console.WriteLine("Error. Type M for Man,  W for Woman");




        }
    }
}