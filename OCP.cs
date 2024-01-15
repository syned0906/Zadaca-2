using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2 { 
    public class Creditcard { 

    }




    public class Bill
    {
        private int amount { get; set; }

        public Bill(int amount) { 
            this.amount = amount;
        }    
    
        public void Pay(Creditcard card) { 
        
        
        }

    }
}

// Navedeni primjer krsi OCP jer bi trebali u Pay metodu napraviti sucelje IPayable koja ce omoguciti vise nacina plaćanja racuna jer ovako klasa ostaje 
// ostaje podlozna samo placanju preko kartice dok mozemo uvest i PayPal i neke druge nacina placanja