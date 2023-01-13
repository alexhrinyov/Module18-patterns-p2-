using Builder_cars_scooters_.Conveyors;

namespace Builder_cars_scooters_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Директор завода
            Director director = new Director();
            // конвейер машин
            Conveyor conveyor = new CarConveyor();
            director.Construct(conveyor);
            director.DisplayProduct(conveyor);
            // переопределяем на конвейер мотоциклов
            conveyor = new MotoConveyor();
            director.Construct(conveyor);
            director.DisplayProduct(conveyor);
        }
    }
}