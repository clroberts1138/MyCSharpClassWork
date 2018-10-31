using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    public class Pistols
    {
        public string PistolBrand { get; set; }

        public int PistolCaliber { get; set; }

        public delegate void ShootPistol(string type);

        public Pistols(string type, int size)
        {
            this.PistolBrand = type;
            this.PistolCaliber = size;
        }

        public Pistols()
        {
            ShootPistol myPistol = ShootAPistol;
            ShootALargerPistol("SmithAndWesson", 45, myPistol);
        }

        public Pistols(int size)
        {
            this.PistolCaliber = size;
        }

        // Method for a delegate
        public void ShootAPistol(string message)
        {
            Console.WriteLine(message);
        }

        public void ShootALargerPistol(string type, int oldSize, ShootPistol another)
        {
            another(" I Shot a " + type + " pistol at caliber " + (oldSize + 5).ToString());
        }

        public void PolicePistol(string message)
        {
            Console.WriteLine(" Police pistol is {0} ", message);
        }

        public void ShotGunPistol(string message)
        {
            Console.WriteLine(" ShotGun Pistol is {0} ", message);
        }
    }
}
