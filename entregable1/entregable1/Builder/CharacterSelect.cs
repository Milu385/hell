using System;
using System.Security.Cryptography.X509Certificates;

namespace entregable1
{
    public class CharacterSelect
    {
        private IBuilder builder;

        public CharacterSelect(IBuilder builder)
        {
            this.builder = builder;
        }

        public Character CreateCharacter(string name)
        {
            builder.SetName(name);
            builder.SetType();
            builder.SetHealth();
            builder.SetEquipment();
            
            return builder.GetCharacter();
        }
    }
}