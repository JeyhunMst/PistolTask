using System;
using System.Collections.Generic;
using System.Text;

namespace PistolTask.Methods
{
    class Weapon
    {
        
        private int _magazineCapacity;
        private int _currentAmmoCount;
        private double _magazineUnloadTime;
        private string _fireMode;
        public int MagazineCapacity 
        {
            get
            {
                return _magazineCapacity;
            }
            set
            {
                if (value>0)
                {
                    _magazineCapacity = value;
                }
            }
        }
        public int CurrentAmmoCount
        {
            get 
            {
                return _currentAmmoCount;
            }
            set 
            {
                if (value>=0 && value<=MagazineCapacity)
                {
                    _currentAmmoCount = value;
                }
            }
        }
        public double MagazineUnloadTime
        {
            get 
            {
                return _magazineUnloadTime;
            }
            set 
            {
                if (value>0)
                {
                    _magazineUnloadTime = value;

                }
            }
        }
        public string FireMode 
        { get 
            {
                return _fireMode;
            }
            set 
            {
                if (value=="single" || value=="auto" || value=="Auto" || value=="Single")
                {
                    _fireMode = value;
                }
            } 
        }

        public Weapon(int magazineCapacity,int currentAmmoCount,double magazineEmptyTime,string fireMode)
        {
            MagazineCapacity = magazineCapacity;
            CurrentAmmoCount =currentAmmoCount;
            MagazineUnloadTime = magazineEmptyTime;
            FireMode = fireMode;
        }
        public void Shoot()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (CurrentAmmoCount!=0)
            {
                CurrentAmmoCount = CurrentAmmoCount - 1;
                Console.WriteLine("Shot");
            }
            else
                Console.WriteLine("Magazine is empty!!!");
        }
        public void Fire() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (FireMode == "single" || FireMode == "Single")
            {

                if (CurrentAmmoCount != 0)
                {
                    CurrentAmmoCount = CurrentAmmoCount - 1;
                    Console.WriteLine("Shot");
                }
                else
                    Console.WriteLine("Magazine is empty!!!");

            }
            else 
            {

                double EachBulletSecond = MagazineUnloadTime / MagazineCapacity;
                double needUnloadTime = CurrentAmmoCount * EachBulletSecond;
                if (CurrentAmmoCount != 0)
                {

                    CurrentAmmoCount = CurrentAmmoCount - CurrentAmmoCount;
                    Console.WriteLine("Shot");
                    Console.WriteLine($"{needUnloadTime} seconds were spent to unload magazine");
                }
                else
                    Console.WriteLine("Magazine is empty!!!");
            }
           
        }
        public int GetRemainBulletCount() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            
            return MagazineCapacity - CurrentAmmoCount;

        }
        public void Reload() 
        {
            CurrentAmmoCount = CurrentAmmoCount + GetRemainBulletCount();
            
        }
        public void ChangeFireMode() 
        {
            if (FireMode == "single" || FireMode=="Single")
            {
                FireMode = "auto";
            }
            else 
            {
                FireMode = "single";
            }
        }
        public void ShowInfo() 
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (MagazineCapacity!=0 && FireMode!=null)
            {
                Console.WriteLine($"Magazine capacity:{MagazineCapacity}\n Current ammo:{CurrentAmmoCount}\n Total magazine unload time:{MagazineUnloadTime}\n Fire mode:{FireMode}");
            }
            else
                Console.WriteLine("Wrong input!!!");
        }



    }
}
