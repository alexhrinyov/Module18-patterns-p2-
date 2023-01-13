namespace PrototypeTask
{
    internal class ImplementationOne : BaseClass
    {    
        // вызывается конструктор базового класса и присваевает Id полю базового абстрактного класса
        public ImplementationOne(int id): base(id)
        {
            
        }

        public override ImplementationOne Clone()
        {
            return new ImplementationOne(Id);
        }

        
    }
}