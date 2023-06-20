using System;
using System.Collections.Generic;
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
        //DECLARATION (Type + Name)
        int IntegerNumber1;

        //DECLARATION + INITIALIZATION (Type + Name + Initialization). In this context the "=" sign is a initializator
        int IntegerNumber2 = 4;

        //DECLARATION (Type + Name). Will alocate memory and set default value Null.
        string Name;
        string Name2 = new string("y");
    
        //ARRAY (type + array dimension + name)
        int[,] IntArray = new int[3,3];


        //CONSTRUCTOR, same Class name. its invoqued with the "new" operator
        public VariablesAndMethods(int IntNumber, int ArraySize)
        {

            //THIS to reference the Object instanced
            this.IntegerNumber1 = IntNumber;

        }

        public VariablesAndMethods()
        {
        }
    }
}
