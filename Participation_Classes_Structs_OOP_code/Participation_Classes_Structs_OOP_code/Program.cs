namespace Participation_Classes_Structs_OOP_code
{
    public class Character
    {
        public string name;
        public int exp = 0;

        public Character()
        {
            //name = "Not assigned";
            Reset();
        }

        public Character(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }

        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;

        }

        //public void Character2() {
            //Reset();
        //}
    }

    public class  Paladin: Character 
    {
        public Weapon weapon;
        public Paladin(string name, Weapon weapon): base(name)
        {
            this.weapon = weapon;
        }

        public override void PrintStatsInfo()
        {
            Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
        }
    }
    public struct Weapon
    {
        public string name;
        public int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Agatha");
            heroine.PrintStatsInfo();

            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            //Testing refernce types
            Character villain = hero;

            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            villain.name = "Sir Kane the Brave";

            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            //Testing value types
            //note: hunting bow is declared above
            Weapon warBow = huntingBow;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();


            //Experimenting with Inheritance
            Paladin knight = new Paladin("Sir Arthur", huntingBow);
            knight.PrintStatsInfo();

            //Testing external files
            Adventurer mike = new Adventurer("Mike");
            mike.PrintStatsInfo();

            //Testing external files
            Dude dave = new Dude("Dave");
            dave.PrintStatsInfo();
        }
    }
}
