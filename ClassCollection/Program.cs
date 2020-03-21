using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //3,1---///////////////////////////////////////////////////////
            Person person = new Person();
            person.Age = 10;
            Person person2 = PersonHandler.CreatPerson(30, "Ahmad", "Al Hafar", 188, 115);

            /*Creat UnitTest to test all actions

            //3,2---///////////////////////////////////////////////////////
            Dog dog1, dog2, dog3, dog4;
            AddValueListofDogs(out dog1, out dog2, out dog3, out dog4);
            //dogs.Add(dog1);, dog2, dog3, dog4);
            //dogs.Add(new Horse());// it must be list of Animal

            //3,3---///////////////////////////////////////////////////////
            WriteStatsForListofChild();
            WriteStatsAndPrintHelloImFather(dog1, dog2, dog3, dog4);
            TestPrintHelloImFAther(dog2, dog3, dog4);
            TestUseFatherOrCHild();

            //3,4---///////////////////////////////////////////////////////
            */
            PrintUEMessage();
            PrintCustomUEMessage();
            //F:11 Use one name action with different way depending on needs
            //F:12 It is logical behavior to define the action depending on class indentifation 
            /*
             * interface support multiple inheritance ... Absract Not
             * interface does'nt contains (Data Member, cunstructors)... Abstrac does
             * Interface contains only incomplete member ... Abstract contain Both
             */

            Console.ReadLine();

        }
        private static void PrintCustomUEMessage()
        {
            List<UserError> usererros = new List<UserError>();
            usererros.Add(new CustomClassUEMessage1());
            usererros.Add(new CustomClassUEMessage2());
            usererros.Add(new CustomClassUEMessage3());
            usererros.Add(new CustomClassUEMessage2());
            usererros.Add(new CustomClassUEMessage1());
            usererros.Add(new CustomClassUEMessage3());
            
            foreach (UserError usererr in usererros)
            {
                Console.WriteLine(usererr.UEMessage());
            }
        }

        private static void PrintUEMessage()
        {
            List<UserError> usererros = new List<UserError>();
            usererros.Add(new Custom());
            usererros.Add(new Custom());
            usererros.Add(new Custom());
            usererros.Add(new TextInputError());
            usererros.Add(new TextInputError());
            usererros.Add(new TextInputError());
            foreach (UserError usererr in usererros)
            {
                Console.WriteLine(usererr.UEMessage());
            }
        }

        private static void TestUseFatherOrCHild()
        {
            Animal testuseSonMethod = new Dog();
            Dog testuseFatherMethod = new Dog();

            string test1 = testuseSonMethod.PrintHelloImFather();
            string test2 = testuseFatherMethod.PrintHelloImSon();
            testuseSonMethod.Stats();
        }

        private static void TestPrintHelloImFAther(Dog dog2, Dog dog3, Dog dog4)
        {
            Animal dog11 = new Dog(3.5, 12, "male", "German Shepherd");
            Animal dog22 = new Dog(); dog2.DogKind = "Bulldog";
            Animal dog33 = new Dog(); dog3.DogKind = "Golden Retriever";
            Animal dog44 = new Dog(); dog4.DogKind = "Poodle";

            List<Animal> dogs22 = new List<Animal>() { dog11, dog22, dog33, dog44 };
            foreach (Dog dog in dogs22)
            {
                Console.WriteLine(dog.PrintHelloImFather());
            }
        }

        private static void WriteStatsAndPrintHelloImFather(Dog dog1, Dog dog2, Dog dog3, Dog dog4)
        {
            List<Dog> dogs = new List<Dog>() { dog1, dog2, dog3, dog4 };
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Stats());
            }

            List<Animal> dogs2 = new List<Animal>() { dog1, dog2, dog3, dog4 };
            foreach (Dog dog in dogs2)
            {
                Console.WriteLine(dog.Stats());
            }
            foreach (Dog dog in dogs2)
            {
                Console.WriteLine(dog.PrintHelloImFather());
            }
        }

        private static void WriteStatsForListofChild()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse());
            animals.Add(new Dog());
            animals.Add(new Hedgehog());
            animals.Add(new Warm());
            animals.Add(new Bird());
            animals.Add(new Flamingo());
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
        }

        private static void AddValueListofDogs(out Dog dog1, out Dog dog2, out Dog dog3, out Dog dog4)
        {
            dog1 = new Dog(3.5, 12, "male", "German Shepherd");
            dog2 = new Dog();
            dog2.DogKind = "Bulldog";
            dog3 = new Dog();
            dog3.DogKind = "Golden Retriever";
            dog4 = new Dog();
            dog4.DogKind = "Poodle";
        }
    }
}
