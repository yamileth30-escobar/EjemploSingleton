using EjemploSingleton;

Console.WriteLine("Iniciando el proceso de singleton");
//Voy a llamar al metdo statico

SingletonExample1 singleton1 = SingletonExample1.getisntance();
Console.WriteLine(singleton1.GetType() + "" + singleton1.Id);

SingletonExample1 singleton2 = SingletonExample1.getisntance();
Console.WriteLine(singleton2.GetType() + "" + singleton2.Id);
Console.WriteLine(singleton2.nombre);


Console.WriteLine("Finalizando el proceso de singleton");
