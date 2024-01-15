using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public interface IMovable {
        void Walk();
        void Swim();
        
    
    }



    public class Whale : IMovable {
       public void Walk() { 
            throw new Exception("Cant walk");
            }
       public void Swim() {
            Console.WriteLine("Swim");
            }

    
    }

}

// ovo je los primjer ISP jer imamo klasu koja nema implementirane sve znacajke sucelja IMovable ,odnosno daje exception za Walk,rijesenje bi bilo napraviti
// posebno sucelje za Walk i Swim
