namespace PepeGym
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    class Example 
    {
        public Example() 
        {
            // This is a comment in the constructor
            Console.WriteLine("Hello, World!");
        }
        public void Method() 
        {
            // This is a comment in a method
            Console.WriteLine("This is a method.");

            int a = 198;

            string s = "Cambios para la rama develop";
        }
    }
}