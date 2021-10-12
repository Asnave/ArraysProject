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
        //static int pistolAmmo = 6;
        //static int shotGunAmmo = 2;
        //static int bfgAmmo = 20;


        static int[] WeaponAmmo = new int[3];
        static string[] weaponName = new string[3];
        static int[] ammoCapacity = new int[3];
        

        static void Main(string[] args)
        {
            WeaponAmmo[0] = 0;
            WeaponAmmo[1] = 0;
            WeaponAmmo[2] = 0;


            weaponName[0] = "Pistol";
            weaponName[1] = "ShotGun";
            weaponName[2] = "BFG";


            ammoCapacity[0] = 6;
            ammoCapacity[1] = 2;
            ammoCapacity[2] = 20;

            Reload();
            ShowHUD();
            
            ChangeWeapon(1);
            Reload();
            ShowHUD();
            Console.WriteLine("");
            Console.WriteLine("Change Weapon");
            Console.WriteLine("");

            Fire(2);
            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("Shooting");

            Reload();
            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("Reloading");
            Console.WriteLine("");



            Console.ReadKey(true);
        }

        static void Reload()
        {
            WeaponAmmo[weapon] = ammoCapacity[weapon];
        }

        static void Fire(int shots)
        {

            WeaponAmmo[weapon] = WeaponAmmo[weapon] - shots;

            if (WeaponAmmo[weapon] < 0)
            {
                WeaponAmmo[weapon] = 0;
            }

        }
        static void ShowHUD()
        {
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine(weaponName[weapon]);
            Console.WriteLine("Ammo: " + WeaponAmmo[weapon] + "/" + ammoCapacity[weapon]);


        }
        static void ChangeWeapon(int currentWeapon)
        {
            weapon = currentWeapon; 
        }
        



    }
}
