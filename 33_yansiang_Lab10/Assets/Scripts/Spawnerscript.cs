using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionY;
    int value;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }
    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        value = Random.Range(0, SpawnObject.Length);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject[value], transform.position, transform.rotation);
    }
}
