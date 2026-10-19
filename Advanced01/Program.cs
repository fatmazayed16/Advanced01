namespace Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*What is a generic class? Why use generics?
                  A generic class is a class that can work with any data type. It allows you to define a class with a placeholder for the data type, which can be specified when creating an instance of the class. Generics provide type safety, code reusability, and performance benefits by allowing you to create classes and methods that can operate on different data types without the need for casting or boxing.
            */
            #endregion

            #region Q2
            Container<int> intContainer = new Container<int>();
            intContainer.Add(5);
            Console.WriteLine(intContainer.Get()); // Output: 5
            Container<string> stringContainer = new Container<string>();
            stringContainer.Add("hello Ahmed");
            Console.WriteLine(stringContainer.Get()); // Output: hello Ahmed
            #endregion
        }
    }
}
