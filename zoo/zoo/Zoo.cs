using System;
using System.Collections.Generic;
using System.Text;

namespace zoo
{
    class Zoo
    {
        private List<Cat> cats;
        private List<Dog> dogs;
        private List<Cow> cows;

        public Zoo()
        {
            cats = new List<Cat>();
            cats.Add(new Cat(4));
            cats.Add(new Cat(4));
            cats.Add(new Cat(4));

            dogs = new List<Dog>();
            dogs.Add(new Dog(3));
            dogs.Add(new Dog(3));

            cows = new List<Cow>();
            cows.Add(new Cow(3));
            cows.Add(new Cow(3));


        }

        public void Run()
        {
            foreach (Cat katt in cats)
            {
                katt.Act();
                Console.WriteLine(" ");
            }

            foreach (Dog hund in dogs)
            {
                hund.Act();
                Console.WriteLine(" ");
            }

            foreach (Cow kossa in cows)
            {
                kossa.Act();
                Console.WriteLine(" ");
            }



        }



    }
}
