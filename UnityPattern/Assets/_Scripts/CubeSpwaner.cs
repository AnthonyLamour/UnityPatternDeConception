using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpwaner : MonoBehaviour
{

    public GameObject cubeObj;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubeObj, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
