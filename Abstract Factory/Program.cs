using System;

namespace Abstract_Factory
{
    public interface IAbstractFactory
    {
        IWeapon Weapon();

        IArmor Armor();

        ISkill Skill();
    }

    public interface IWeapon
    {
        string Attack();
    }
    public interface IArmor
    {
        string Description();
    }
    public interface ISkill
    {
        string UseSkill();
    }

    class Warrior : IAbstractFactory
    {
        public IWeapon Weapon()
        {
            return new Sword();
        }
        public IArmor Armor()
        {
            return new HeavyArmor();
        }
        public ISkill Skill()
        {
            return new Berserk();
        }
    }
    class Sorcerer : IAbstractFactory
    {
        public IWeapon Weapon()
        {
            return new Wand();
        }
        public IArmor Armor()
        {
            return new MagicArmor();
        }
        public ISkill Skill()
        {
            return new Healing();
        }
    }
    class Rouge : IAbstractFactory
    {
        public IWeapon Weapon()
        {
            return new Bow();
        }
        public IArmor Armor()
        {
            return new LightArmor();
        }
        public ISkill Skill()
        {
            return new Invisibility();
        }
    }

    class Sword : IWeapon
    {
        public string Attack()
        {
            return "You swing your sword. (2 damage)";
        }
    }
    class Bow : IWeapon
    {
        public string Attack()
        {
            return "You fire your bow. (1 damage)";
        }
    }
    class Wand : IWeapon
    {
        public string Attack()
        {
            return "You cast fire. (2 damage)";
        }
    }

    class HeavyArmor : IArmor
    {
        public string Description()
        {
            return "Your armor slows you down. (+2 Defense, -2 Speed)";
        }
    }
    class LightArmor : IArmor
    {
        public string Description()
        {
            return "Your armor is as light as a feather. (+1 Defense, +1 Speed)";
        }
    }
    class MagicArmor : IArmor
    {
        public string Description()
        {
            return "It's like you're wearing nothing at all. (+1 Defense, +2 Speed)";
        }
    }

    class Berserk : ISkill
    {
        public string UseSkill()
        {
            return "You go Berserk. (+2 Attack)";
        }
    }
    class Healing : ISkill
    {
        public string UseSkill()
        {
            return "You cast Healing. (+2 Healing)";
        }
    }
    class Invisibility : ISkill
    {
        public string UseSkill()
        {
            return "No one can see you now. (100% stealth)";
        }
    }


    class Client
    {
        public void Main()
        {
            ClientMethod(new Warrior());
            Console.WriteLine();
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var weapon = factory.Weapon();
            var armor = factory.Armor();
            var skill = factory.Skill();

            Console.WriteLine(weapon.Attack());
            Console.WriteLine(armor.Description());
            Console.WriteLine(skill.UseSkill());
            //Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
