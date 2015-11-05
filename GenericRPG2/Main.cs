using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRPG2
{
    class Main
    {
        internal void start()
        {
            Hero h = new Hero();
            Weapon w = new Weapon();
            // Weapon w2 = new Weapon();

            Shield s = new Shield();
            Month currentMonth = Month.November;
            Monster m = new Monster();

            // w2.setName("Human slayer");
            // w2.setDamage(20);

            m.setName("Troll");
            // m.setWeapon(w2);

            m.setWeapon(w);


            // setName Shieldille

            s.setName("Troll blocker");
            s.setDefence(5);

            w.SetName("The Mighty Troll Killer Sword");
            w.SetDamage(10);


            h.setName("Joona");
            h.setHP(24);
            h.setWeapon(w);
            h.setShield(s);

            // setShield

            w.SetDamage(0);
            w.SetName("This ain't no weapon!");


            enum Month {January, February, March, April, May, June, July, August, September, October, November, December};
	//{
	         
	//}

        }
    }
}
