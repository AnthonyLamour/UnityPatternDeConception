using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IEnemyFactory
{
    IWeapon GetWeapon();
    IArmor GetArmor();
}
