using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProject
{
    class Program
    {
        static int weapon = 0;
        static int pistolAmmo = 6;
        static int shotGunAmmo = 2;
        static int bfgAmmo = 20;

        static int[] WeaponAmmo;
       static string[] weaponName = new string[3];
        static int[] ammoCapacity;

        static void Main(string[] args)
        {
          

            WeaponAmmo = new int[3];
            WeaponAmmo[0] = 0;
            WeaponAmmo[1] = 0;
            WeaponAmmo[2] = 0;

            
            weaponName[0] = "pistol";
            weaponName[1] = "ShotGun";
            weaponName[2] = "BFG";

            ammoCapacity[0] = 6;
            ammoCapacity[1] = 2;
            ammoCapacity[2] = 20;

            Fire();
           
            
            Console.WriteLine(weaponName[weapon] + "Ammo: " + WeaponAmmo[weapon]);
            Console.ReadKey(true);
        }

        static void Reload()
        {
            if ( WeaponAmmo )
          
        }

        static void Fire()
        {
            if ( WeaponAmmo[weapon] < 0)
            {
                WeaponAmmo[weapon] = WeaponAmmo[weapon] = 0 ;
            }

            WeaponAmmo[weapon] = WeaponAmmo[weapon] - 1;
           
        }

     }   
}
