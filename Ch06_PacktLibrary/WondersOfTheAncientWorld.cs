using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.CS6
{
    [System.Flags]
    public enum WondersOfTheAncientWorld: byte
    {
        None = 0,
        GreatPyramidOfGiza = 1,
        HangingGardensOfBabilon = 1 << 1,
        StatueOfZeusAtOlympia = 1 << 2,
        TempleOfArtemisAtEmphesus = 1 << 3,
        MuasoleumAtHalicarnassus = 1 << 4,
        ColossusOfRhodes= 1 << 5,
        LighthouseOfAlexandria = 1 << 6
    }
}
