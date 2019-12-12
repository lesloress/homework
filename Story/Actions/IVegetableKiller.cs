using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story.Actions
{
    interface IVegetableKiller
    {
        void KillWithoutSuccess();
        //void KillWithSuccess();
        void StartKilling();
    }
}
