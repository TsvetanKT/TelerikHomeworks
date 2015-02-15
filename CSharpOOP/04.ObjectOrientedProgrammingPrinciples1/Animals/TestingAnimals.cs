using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    //03.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
    //  All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. 
    //  Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and 
    //  calculate the average age of each kind of animal using a static method (you may use LINQ).
    class TestingAnimals
    {
        public static void Speak (Animal animal)
        {
            Console.WriteLine("{0} is an {2} and says {1}",animal.Name , animal.MakeSound(),animal.GetType());
        }
        static void AvarageAgeCalculator (IList<Animal> list)
        {
            decimal avarageDog = 0, avarageKitten = 0, avarageTomcat = 0, avarageFrog = 0;
            decimal dogs = 0, kittens = 0, tomcats = 0, frogs = 0;

            foreach (var animal in list)
            {
                if (animal is Tomcat)
                {
                    avarageTomcat = avarageTomcat + animal.Age;
                    tomcats++;
                }
                if (animal is Kitten)
                {
                    avarageKitten = avarageKitten + animal.Age;
                    kittens++;
                }
                if (animal is Dog)
                {
                    avarageDog = avarageDog + animal.Age;
                    dogs++;
                }
                if (animal is Frog)
                {
                    avarageFrog = avarageFrog + animal.Age;
                    frogs++;
                }
            }

            Console.WriteLine("Avarage ages :");
            Console.WriteLine("Tomcats : {0}", avarageTomcat/tomcats);
            Console.WriteLine("Kittens : {0}", avarageKitten/kittens);
            Console.WriteLine("Dogs : {0}", avarageDog/dogs);
            Console.WriteLine("Frogs : {0}", avarageFrog/frogs);

        }

        static void Main()
        {
            Console.WriteLine("03.Testing Animals");

            Tomcat koko = new Tomcat("Koko", 5);
            Kitten joanna = new Kitten("Joanna", 3);
            Tomcat joko = new Tomcat("Joko", 15);
            Kitten mima = new Kitten("Mima", 6);
            Dog joe = new Dog("Joe", 8, "male");
            Dog moe = new Dog("Moe", 16, "male");
            Dog pepa = new Dog("Pepa", 6, "female");
            Frog gosho = new Frog("Gosho", 8, "male");
            Frog lusi = new Frog("Lusi", 33, "female");

            List<Animal> animals = new List<Animal> {koko,joanna,joko,mima,joe,moe,pepa,gosho,lusi };

            foreach (var animal in animals)
            {
                Speak(animal);
            }

            Console.WriteLine();

            AvarageAgeCalculator(animals);

        }
    }
}
