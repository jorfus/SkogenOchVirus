using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Virusepidemin
{
    class Diskotek
    {
        public List<Person> Personer { get; private set; } = new List<Person>();

        /*int AntalSmittade { get; set; } = 1;
        int AntalImmuna { get; set; } = 1;*/

        public void FyllDisko()
        {
            Person smittadperson = new Person(true, true);
            Personer.Add(smittadperson);

            for (int i = 0; i < 49; i++)
            {
                Person friskPerson = new Person();
                Personer.Add(friskPerson);
            }
        }
        public (int antalSmittade, int antalImmuna) Smittade(int antalSmittade, int antalImmuna, int timmar)
        {
            (Personer, antalSmittade, antalImmuna) = Person.Smitta(Personer, antalSmittade, antalImmuna, timmar);
            return (antalSmittade, antalImmuna);
        }
        public override string ToString()
        {
            string allt = "\n";
            foreach (Person item in Personer)
                allt += item + "\n";

            return $"{allt}";
        }
    }
}
