namespace SingletonDBConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionManager con1 = ConnectionManager.connManager;
            con1.UIMenu();
        }
    }
}