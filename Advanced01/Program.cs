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
            Container<int> intContainer = new();
            intContainer.Add(5);
            Console.WriteLine(intContainer.Get()); // Output: 5
            //Container<string> stringContainer = new();
            //stringContainer.Add("hello Ahmed");
            //Console.WriteLine(stringContainer.Get()); // Output: hello Ahmed
            #endregion

            #region Q3
            /* What are multiple type parameters?
                  * يعني دل م ال generic class يقدر يستقبل parameter واحد لا يقدر يستقل كذا parameter
                  * Pair <int, string>
                  * وده بيسمحلي اني اخزن قيمتين مختلفتين في ال class
             */

            Pair<string , int> pair = new("Ahmed", 1);
            Console.WriteLine($"Value: {pair.Value}, Key: {pair.Key}");
            #endregion

            #region Q4
            //A generic method is a method that can work with different data types using a type parameter, without creating a separate method for each data type.

            int x = 10;
            int y = 20;
            GenericMethod.Swap(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}"); // Output: x: 20, y: 10

            #endregion

            #region Q5
            Console.WriteLine($"Max : {GenericMethod.FindMax(10, 20)}");
            #endregion

            #region Q6
            // A generic Interface is an interface that can work with different data types using a type parameter. It allows you to define a contract for classes that implement the interface, without specifying the data type in advance.

            #endregion

            #region Test
            Repsitory<Product> product = new Repsitory<Product>();
            product.Add(new Product { Id = 1, Name = "Product 1", Price = 100 });
            product.Add(new Product { Id = 2, Name = "Product 2", Price = 200 });
            product.Add(new Product { Id = 3, Name = "Product 3", Price = 300 });

            product.GetAll().ForEach(p => Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}"));

            Console.WriteLine("-----------------Searching for product with ID 2-----------------");
            Product? foundProduct = product.GetById(2);
            Console.WriteLine($"Found Product: {foundProduct?.Name}, Price: {foundProduct?.Price}");

            product.Update (new Product { Id = 2, Name = "Updated Product 2", Price = 250 });
            foundProduct= product.GetById(2);
            Console.WriteLine("------------------After Update product 2 ------------------");
            Console.WriteLine(foundProduct?.Name);
            Console.WriteLine(foundProduct?.Price);

            
            product.Remove(1);
            Console.WriteLine("------------------After remove product 1 ------------------");
            product.GetAll().ForEach(p => Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}"));

            #endregion

            #region Q7
            // What is the 'struct' constraint?
            // The 'struct' constraint is a generic type constraint that restricts the type parameter to value types (structs) only. It ensures that the type used with the generic class or method is a value type, which can help improve performance and memory usage in certain scenarios.

            Container<int> number = new Container<int>();
            number.Value = 10; // This line is valid because int is a value type (struct).

            //Container<string> Names = new Container<string>();
            //Names.Value = "Ahmed"; // This line will cause a compile-time error because string is not a value type (struct).

            #endregion

            #region Q8
            //What is the 'class' constraint?
            // The 'Class' constraint is a generic type constraint that restricts the type parameter to Refrance types (Class) only like string or any class but not int.
            ContainerString<string> Names = new ContainerString<string>();
            Names.Value = "Ahmed"; // This line is valid because string is a ref type (class).
            #endregion
        }
    }
}
