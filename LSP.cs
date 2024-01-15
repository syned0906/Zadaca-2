using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Bird {
        public virtual void Fly() {
            Console.WriteLine("Leti");   
       }
    }


    public class Penguin : Bird { 
        
        public override void Fly()
        {
            throw new Exception("Penguins cannot fly");
        }
    
    }

}
// U ovom primjeru narusen je LSP jer klasa Penguin nemoze naslijediti klasu Bird jer pingvini ne lete te bi trebali dodati sucelje IFlyable