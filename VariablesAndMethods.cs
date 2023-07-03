using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Notes
{

    class MyObject
    {
        int id;

        public MyObject()
        {
        }
    }
    class VariablesAndMethods
    {
        class myHuman
        {
            //PRIVATE, all variables are private for encapsulation (protect its value via Getters & Setters)


            //DECLARATION (Acces + Type + Name). Default value is int = 0, Bol = false
            private int _age;

            //DECLARATION + INITIALIZATION (Type + Name + Initialization). In this context the "=" sign is a initializator for a default value
            private int _limbs = 4;

            //STATIC A class variable. Can be accesed without creating an object 
            private static int _heads = 1;

            //DECLARATION (Type + Name). Will alocate memory and set default value Null for Objects.
            private string _name;
            string _surName = new string("Last Name here");

            //ARRAY (type + array dimension + name)
            int[,] IntArray = new int[3, 3];


            //ENCAPSULATION, a field variable protected by treatment functions 
            //PROPERTIES in C# getters & Setters are treated like field variables
            public int Age { get => _age; set => _age = value; }
            public int Limbs { get => _limbs; set => _limbs = value; }
            public static int Heads { get => _heads; set => _heads = value; }
            public string Name { get => _name; set => _name = value; }
            public string SurName { get => _surName; set => _surName = value; }
            public int[,] IntArray1 { get => IntArray; set => IntArray = value; }



            //CONSTRUCTOR, same Class name. Its invoqued with the "new" operator
            public myHuman()
            {
                //THIS to reference the Object instanced
                this._age = 1;
                this._name = "Fulano";
            }
            //CONSTRUCTOR OVERLOADING
            public myHuman(int Age, string Name)
            {
                this._age = Age;
                this._name = Name;
            }



        }
    }
}
