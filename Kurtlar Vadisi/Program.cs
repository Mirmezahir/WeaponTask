using System.Data;

namespace Kurtlar_Vadisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon= new Weapon("AK-47",30,30,"Auto");
            bool f = false;
            bool g = false;
            bool h = false;
            do
            {
                Console.WriteLine("                                             KURTLAR VADISI            ");
                Console.WriteLine("1.WEAPON INFORMATION\n2.SHOOT\n3.AMMO COUNT\n4.Reload\n5.Change Shoot mode\n6.ELave\n0.EXIT");
                int login;
               do
                {
                    Console.WriteLine("Reqem daxil edin !");
                    g=int.TryParse(Console.ReadLine(), out login);
                    
                
                }while (!g);
                switch (login)
                {
                    case 1:
                        
                        weapon.Information();
                        
                        break;
                      
                    case 2:
                        if (weapon.AmmoCount > 0) { weapon.Shoot(weapon.Mode); }
                        else Console.WriteLine("NEED AMMO");
                        break;

                    case 3: weapon.GetRemainBulletCount(); break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.Clear();
                        
                        do
                        {
                            Console.WriteLine("1.Tutumu artir\n2.Gulleni Artir\n3.Menyuya qayit ");
                            do
                            {
                                bool p;
                                int o;
                                do
                                {      
                                     Console.WriteLine("Reqem daxil edin ");
                                     p = int.TryParse(Console.ReadLine(), out o);
                                } while (!p);
                                switch (o) 
                                
                                { 
                                    case 1:weapon.AmmoCapasity = weapon.AmmoCapasity + 10;
                                        Console.WriteLine("Gulle tutumu artdi");

                                    break;
                                        case 2:
                                        if (weapon.AmmoCount + 10 <= weapon.AmmoCapasity)
                                        {
                                            weapon.AmmoCount = weapon.AmmoCount + 10;
                                        }
                                        else Console.WriteLine("Gulle tutumu kecir");
                                        break;
                                        case 3:
                                        h= true;
                                        g= true;
                                        break;




                                }

                            } while (!g);
                            








                        } while (!h);
                        break;
                    case 0: f = true; break;

                }
            } while (!f);
            
        }
    }
}
