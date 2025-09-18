using System;

namespace entregable1
{
    public interface IHealthManager
    {
        void Heal(double heal);
        void takeDamage(double damage);
        double ShowCharacterLife();
    }
}