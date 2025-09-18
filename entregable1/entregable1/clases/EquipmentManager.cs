using System;

namespace entregable1
{
    public class EquipmentManager : IequipmentManager
    {

        private Isword sword = new InitialSword();
        private Iarmor armor = new InitialArmor();
        public void Equip(Isword sword)
        {
            this.sword = sword;
        }

        public void Equip(Iarmor armor)
        {
            this.armor = armor;
        }

        public double resistencia()
        {

            return armor.resistencia();

        }

        public double damage()
        {

            return sword.damage();

        }
        
    }
}