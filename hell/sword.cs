using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable1
{
    public interface Isword
    {
        double damage();

    }

    public class InitialSword : Isword
    {
        double Isword.damage()
        {
            return 1.5;
        }
    }

    public class Machete : Isword
    {

        double Isword.damage()
        {
            return 3.5;
        }

    }

    public class Claymore : Isword
    {
        double Isword.damage()
        {
            return 4.5;
        }
    }

}

    
