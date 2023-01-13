namespace PrototypeTask
{
    abstract class BaseClass
    {
        public int Id { get; }
        public BaseClass(int id)
        {
            Id = id;
        }
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Id}");
        }
        public abstract BaseClass Clone();
    }
}