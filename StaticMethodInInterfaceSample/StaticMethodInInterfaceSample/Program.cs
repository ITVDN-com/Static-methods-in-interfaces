using System;
using System.Reflection;

using DLLibrary.StaticMethodInInterface;

namespace StaticMethodInInterfaceSample
{
    class MyClass : IInterface
    {
        // Статичесикй метод интерфейса не наследуется.
        // Система автодополнения предлагает реализовать интерфейс.        
        //public void Method()
        //{
        //    throw new NotImplementedException();
        //}
    }
    class Program
    {
        static void Main()
        {
            // Напрямую метод - Method - недоступен!
            // IInterface.Method(); 
            // MyClass.Method();    
            
            // Использование рефлексии.

            Type type = typeof(IInterface);

            //MethodInfo method = type.GetMethod("Method", BindingFlags.Static); // Ошибка!
            MethodInfo method = type.GetMethod("Method");
            method.Invoke(null, null);

            // Статичесикй метод интерфейса не наследуется.
            type = typeof(MyClass);

            method = type.GetMethod("Method");

            if (method != null)
                method.Invoke(null, null);
            else
                Console.WriteLine("Метод с именем Method в классе MyClass не найден!");


            // Delay.
            Console.ReadKey();
        }
    }
}
