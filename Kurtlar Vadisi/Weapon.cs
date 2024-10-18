using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurtlar_Vadisi
{
    internal class Weapon
    {
        public string Name;
        public int AmmoCapasity;
        public int AmmoCount;
        public bool Mode;
       

        public Weapon(string name, int ammoCapasity, int ammoCount,string mode)
        {
            Name = name;
            AmmoCount = ammoCount;
            AmmoCapasity = ammoCapasity;
            
            Mode = true; 
        }

        public void Shoot(bool mode )
        {
            Console.WriteLine("ATIS EDILDI ----------------------------------}");
            if (AmmoCount <= AmmoCapasity&&AmmoCount>0)
            {
                if (mode == true)
                {
                    AmmoCount = 0; ;
                }
                else if (mode == false )
                {
                    AmmoCount--;
                }
            }
           

        }
    

        public void GetRemainBulletCount() 
        { Console.WriteLine($"Qalan gulleniz ={AmmoCount}"); }
        public void Reload() { AmmoCount = AmmoCapasity;Console.WriteLine("[Reloaded]"); }
        public void ChangeFireMode() { if (Mode == true) { Mode = false ;Console.WriteLine("Simple mode kecdi"); } else if (Mode == false) { Mode = true;Console.WriteLine("Avtomatik mode kecdi  "); } }
        
        public void Information() { Console.WriteLine($"Weapon name :{Name} Ammo Capasity :{AmmoCapasity} Ammo:{AmmoCount}"); }
    }
}
