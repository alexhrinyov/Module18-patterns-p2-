namespace PrototypeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass myObject = new ImplementationOne(4789);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(5556);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    }
}