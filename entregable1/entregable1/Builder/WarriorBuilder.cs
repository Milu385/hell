using System;

namespace entregable1
{

    public class WarriorBuilder : IBuilder
    {
        private Character character = new Character();

        public void SetName(string name)
        {
            character.name = name;
        }
        public void SetType()
        {
            character.type = "warrior";
        }
        public void SetHealth()
        {
            character.health = new healthManager(30);
        }
        public void SetEquipment()
        {
            character.equipment = new EquipmentManager();
        }

        public Character GetCharacter()
        {
            return this.character;
        }
    }
}