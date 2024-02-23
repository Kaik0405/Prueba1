using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnity
{
    class Card
    {
        private int ID;
        private string name;
        private string description;
        private int Atk;
        private string type;
        
        public Card(int ID, string name, string description, int Atk,string type)
        {
            this.ID = ID;
            this.name = name;
            this.description = description;
            this.Atk = Atk;
            this.type = type;
        }
        public void getCard()
        {
            Console.WriteLine(ID);
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine(Atk);
            Console.WriteLine(type);
        }

    }
}
