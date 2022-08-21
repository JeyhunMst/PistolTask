using PistolTask.Methods;
using System;

namespace PistolTask
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
                Console.Write("Enter magazine capacity for gun:");
                int magazineCapacity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter current bullet count:");
                int currentBullet = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter time(seconds) need to unload full magazine: ");
                double timeUnload = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter fire mode: ");
                string fireMode = Console.ReadLine();
                Weapon gun = new Weapon(magazineCapacity, currentBullet, timeUnload, fireMode);
                GetMenu(gun);
    
        }
        static void Menu(Weapon gun, int check)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            switch (check)
            {
                case 0:
                    gun.ShowInfo();
                    break;
                case 1:
                    gun.Shoot();
                    
                    break;
                case 2:
                       gun.Fire();
                    break;
                case 3:
                    Console.WriteLine(gun.GetRemainBulletCount()); 
                    break;
                case 4:
                    gun.Reload();
                    break;
                case 5:
                    gun.ChangeFireMode();
                    break;
                case 7:
                    Console.WriteLine("Enter what do you want to do:\n 1.T (Change magazine capacity)\n 2.S (Change ammo count)\n 3.D (Change unload time)");
                    char character = Convert.ToChar(Console.ReadLine());
                    switch (character)
                    {
                        case 'T':
                            Console.Write("Enter new size of magazine:");
                            int newSize = Convert.ToInt32(Console.ReadLine());
                            gun.MagazineCapacity = newSize;
                            break;
                        case 'S':
                            Console.Write("Enter new amount of bullets:");
                            int newBullets = Convert.ToInt32(Console.ReadLine());
                            gun.CurrentAmmoCount = newBullets;
                            break;
                        case 'D':
                            Console.Write("Enter new unload time:");
                            double newUnload = Convert.ToDouble(Console.ReadLine());
                            gun.MagazineUnloadTime = newUnload;
                            break;
                        default:
                            Console.WriteLine("Wrong input!!!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input!!!");
                    break;
            }
            GetMenu(gun);
        }
        static void GetMenu(Weapon gun)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Weapon newGun = gun;

            Console.WriteLine("Enter what do you want to do:\n 0.Information\n 1.Shoot one bullet\n 2.Fire all bullets\n 3.Get remain bullet count\n 4.Reload\n 5.Change fire mode\n 6.Exit from program\n 7.Change parametrs of gun");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input != 6)
            {
                Menu(gun, input);
            }
            else 
            {               
                Console.WriteLine("Program finished");
            }
              
        }
 

    }
}
