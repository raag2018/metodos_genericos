
using metodos_genericos;

static void imprimirArreglo<E>(E[] arregloEntrada){
    foreach ( E elemento in arregloEntrada){
        Console.WriteLine( elemento );
    }
}
// crea arreglos de tipo int, double and char
 int[] arregloInt = { 1, 2, 3, 4, 5, 6 };
 double[] arregloDouble = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
 char[] arregloChar = { 'H', 'O', 'L', 'A' };
 Console.WriteLine("El arreglo arregloInt contiene:");
 imprimirArreglo(arregloInt); // pasa un arreglo int como argumento
 Console.WriteLine("El arreglo arregloDouble contiene:");
 imprimirArreglo(arregloDouble); // pasa un arreglo double como argumento
 Console.WriteLine("El arreglo arregloChar contiene:");
 imprimirArreglo(arregloChar); // pasa un arreglo char como argumento
IRepository<Product> repository = new ProductRepository();

var product = new Product { Id = 1, Name = "Laptop", Price = 999.99m };
repository.Add(product);

var retrievedProduct = repository.Get(1);
Console.WriteLine($"Retrieved: {retrievedProduct.Name}, {retrievedProduct.Price}");

var allProducts = repository.GetAll();
foreach (var p in allProducts){
    Console.WriteLine($"Product: {p.Name}, {p.Price}");
}