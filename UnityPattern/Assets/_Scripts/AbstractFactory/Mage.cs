using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Mage : IEnemyFactory
{
    public IWeapon GetWeapon()
    {
        return new Wand();
    }

    public IArmor GetArmor()
    {
        return new Cloak();
    }
}
