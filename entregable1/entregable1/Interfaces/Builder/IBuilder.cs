using System;

namespace entregable1
{
    public interface IBuilder
    {
        void SetName(string name);
        void SetType();
        void SetHealth();
        void SetEquipment();
        Character GetCharacter();
        
    }
}