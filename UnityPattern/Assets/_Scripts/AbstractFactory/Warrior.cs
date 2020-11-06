using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Warrior : IEnemyFactory
{
    public IWeapon GetWeapon()
    {
        return new Sword();
    }

    public IArmor GetArmor()
    {
        return new BodyArmor();
    }
}
