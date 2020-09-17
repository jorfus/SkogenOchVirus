using System;
using System.Collections.Generic;
using System.Text;

namespace Virusepidemin
{
    class Person
    {
        public bool Smittad { get; private set; }
        int SmittadNär { get; set; }
        public bool Immun { get; private set; } = false;

        public Person() : this(false, false) { }
        public Person(bool smittad, bool immun)
        {
            Smittad = smittad;
            Immun = immun;
        }

        public static (List<Person>, int antalSmittade, int antalImmuna) Smitta(List<Person> personer, int antalSmittade, int antalImmuna, int timmar)
        {
            int counter = antalSmittade;

            for (int i = 0; i < personer.Count; i++)
            {
                if (personer[i].Immun == false && counter != 0)
                {
                    personer[i].Smittad = personer[i].Immun = true;
                    personer[i].SmittadNär = timmar;
                    antalSmittade++;
                    antalImmuna++;
                    counter--;
                }
                else if (personer[i].Immun && timmar - personer[i].SmittadNär == 5)
                {
                    personer[i].Smittad = false;
                    antalSmittade--;
                }
                else if (counter == 0)
                    break;
            }

            return (personer, antalSmittade, antalImmuna);
        }
        public override string ToString()
        {
            return $"Smittad: {Smittad}\tTimme: {SmittadNär}\tImmun: {Immun}";
        }
    }
}
