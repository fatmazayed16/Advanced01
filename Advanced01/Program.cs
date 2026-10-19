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

            #region Q9
            // What is the 'new()' constraint?
            // It requires the type to have a public parameterless constructor so we can create an object using new T()

            #region Test New Constraint
            ContainerWithNew<Product> container = new ContainerWithNew<Product>();

            Product product01 = container.Create();
            #endregion

            #endregion

            #region Q10
            //What is the interface constraint?
            //It requires the type we use to implement a specific interface.
            // For example, we used the IEntity interface.
            #endregion

            #region Q11
            // What is the base class constraint?
            // It requires the type to be a specific class or a class that inherits from it, meaning the base class or any of its derived classes.
            ContainerWithBaseClass<Dog> container02 = new ContainerWithBaseClass<Dog>();
            Dog dog = container02.Create();
            dog.Name = "Bondok";
            Console.WriteLine(dog.Name);
            // ContainerWithBaseClass<Product>  -> Error cause Product does not inherit from Animal. 

            #endregion

            #region Q12
            //How do you apply multiple constraints?
            //We use where T : and write the required constraints together, separating them with commas. If the new() constraint is included, it must always be the last constraint.

            // // ContainerWithBaseClass demonstrates multiple constraints.

            ContainerWithBaseClass<Dog> container03 = new ContainerWithBaseClass<Dog>();

            Dog dog01 = container03.Create();
            dog.Id = 1;

            Console.WriteLine(dog.Id);

            #endregion

            #region Q13
            //What does the 'default' keyword do in generics?
            //The default keyword returns the default value of a type. For example, it returns 0 for int, false for bool, and null for reference types such as string.
            #endregion

            #region Q14
            // returns default when the index is invalid.

            SafeList<int> numbers = new SafeList<int>();
            numbers.Add(10);
            numbers.Add(20);

            Console.WriteLine(numbers.Get(1));  // 20
            Console.WriteLine(numbers.Get(5));  // 0
            Console.WriteLine(numbers.Get(-1)); //0
            #endregion

            #region Q15
            //Covariance allows a more derived type to be used where a less derived type is expected. The out keyword enables covariance in generic interfaces and delegates by allowing the type parameter to be used as an output type.

            Animal animal = new Dog();

            IEnumerable<Dog> dogs = new List<Dog>();
            IEnumerable<Animal> animals = dogs;
            // Dog inherits from Animal.
            // IEnumerable<out T> supports covariance.
            // Therefore, we can assign an IEnumerable<Dog> to an IEnumerable<Animal> variable.
            // Not all generic types support covariance; the interface or delegate must use the 'out' keyword.

            #endregion

            #region Q16
            //Contravariance allows a less derived type to be used where a more derived type is expected. The in keyword enables contravariance in generic interfaces and delegates by allowing the type parameter to be used as an input type.

            Action<Animal> animalAction = animal => Console.WriteLine("Animal");
            Action<Dog> dogAction = animalAction;

            // Action<in T> supports contravariance.
            // Action<Animal> can be used where Action<Dog> is expected,
            // because a method that accepts any Animal can also accept a Dog.

            dogAction(new Dog());
            #endregion

            #region Q17
            //Covariance (out): بنستخدم نوع مشتق مكان نوع أعم، زي IEnumerable<Dog> مكان IEnumerable<Animal>.
            // Contravariance(in): بنستخدم نوع أعم مكان نوع مشتق، زي Action<Animal> مكان Action< Dog >.
            #endregion

            #region Q18
            //In generic types, static members are shared among all instances of the same closed generic type, but each different type argument has its own separate copy of the static members.
            Counter<int>.Count = 10;
            Counter<string>.Count = 20;

            Console.WriteLine(Counter<int>.Count);    // 10
            Console.WriteLine(Counter<string>.Count); // 20
            #endregion
        }
    }
}
