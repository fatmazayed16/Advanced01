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

            #region Q3
            /* What are multiple type parameters?
                  * يعني دل م ال generic class يقدر يستقبل parameter واحد لا يقدر يستقل كذا parameter
                  * Pair <int, string>
                  * وده بيسمحلي اني اخزن قيمتين مختلفتين في ال class
             */

            Pair<string , int> pair = new Pair<string, int>("Ahmed", 1);
            Console.WriteLine($"Value: {pair.Value}, Key: {pair.Key}");
            #endregion

            #region Q4
            //A generic method is a method that can work with different data types using a type parameter, without creating a separate method for each data type.

            int x = 10;
            int y = 20;
            GenericMethod.Swap(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}"); // Output: x: 20, y: 10

            #endregion
        }
    }
}
