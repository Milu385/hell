using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable1
{
    public interface Iarmor
    {
        double resistencia();

    }

    public class InitialArmor: Iarmor
    {
        double Iarmor.resistencia()
        {
            return 1;
        }
    }

    public class LeatherArmor : Iarmor
    {
        double Iarmor.resistencia()
        {
            return 0.9;
        }
        
    }


    public class PlateArmor : Iarmor
    {
        double Iarmor.resistencia()
        {
            return 0.6;
        }
    }

}


