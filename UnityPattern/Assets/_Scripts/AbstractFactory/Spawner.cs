using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    IEnemyFactory factory = null;

    public GameObject warrior;
    public GameObject mage;
    public Transform warriorSpawnPosition;
    public Transform mageSpawnPosition;

    //SpawnEnemy method will decide what type of enemy will be created

    //Based on string input

    public void SpawnEnemy(string enemy)
    {
        if (enemy == "Warrior")
        {
            factory = new Warrior();
            Debug.Log("New Warior equipment:");
            Debug.Log(factory.GetWeapon().Item());
            Debug.Log(factory.GetArmor().Item());
            Debug.Log("");
        }
        else if (enemy == "Mage")
        {
            factory = new Mage();
            Debug.Log("New Mage equipment:");
            Debug.Log(factory.GetWeapon().Item());
            Debug.Log(factory.GetArmor().Item());
            Debug.Log("");
        }
        else
        {
            Debug.Log("Wrong type");
        }
    }

    private void Start()
    {
        Spawner MySpawner = new Spawner();
        MySpawner.SpawnEnemy("Mage");
        Instantiate(mage, mageSpawnPosition);
        MySpawner.SpawnEnemy("Warrior");
        Instantiate(warrior, warriorSpawnPosition);
    }
}
