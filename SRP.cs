using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Square
    {

        private int a { get; set; }

        

        public Square(int a) {
            this.a = a;
        }
        
        public int Surface() { 
            return a*a; 
        }


        public void SaveUserFiles()
        {
            Console.WriteLine("Files saved.");
            
        }

    }
}

// Navedena klasa narusava SRP jer unutar klase Square imamo funkciju SaveUserFiles koja nema veze s klasom

