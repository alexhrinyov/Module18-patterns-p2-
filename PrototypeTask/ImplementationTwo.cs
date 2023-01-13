namespace PrototypeTask
{
    internal class ImplementationTwo : BaseClass
    {
       

        public ImplementationTwo(int id):base(id)
        {
          
        }

        public override ImplementationTwo Clone()
        {
            return new ImplementationTwo(Id);
        }

       
    }
}