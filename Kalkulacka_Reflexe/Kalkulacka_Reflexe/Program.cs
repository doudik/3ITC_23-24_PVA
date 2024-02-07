using System.Reflection;

namespace Kalkulacka_Reflexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Kalkulacka);

            object instance = Activator.CreateInstance(type);

            MethodInfo[] metodyVKalkulacce = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance);
            //MethodInfo method = type.GetMethod("Secti");
            //Console.WriteLine(type.InvokeMember("Secti", BindingFlags.InvokeMethod, null, instance, new object[] { 2, 68 }));

            Console.WriteLine("Metody v třídě 'Kalkulačka:'");
            foreach (MethodInfo method in metodyVKalkulacce)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}