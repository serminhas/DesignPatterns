namespace DesignPatterns.AbstractFactoryDP
{
    using Models;
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string factoryType);
        public static AnimalFactory CreateAnimalFactory(string animalType)
        {
            if (animalType.Equals("Sea")) { return new SeaAnimalFactory(); }
            else { return new LandAnimalFactory(); }
           
        }
        
    }

    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Shark")) { return new Shark(); }
            else if(animalType.Equals("Octopus")) { return new Octopus(); }
            else { return null; }
        }
    }
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog")) { return new Dog(); }
            else if (animalType.Equals("Cat")) { return new Cat(); }
            else if (animalType.Equals("Lion")) { return new Lion(); }
            else { return null; }
        }
    }
}
