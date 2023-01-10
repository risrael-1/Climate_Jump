using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject prefabPlat;

    public int nbPlats = 20;
    public float lvlWidth = 2f;
    public float minY = -1.5f;
    public float maxY = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawn = new Vector3();

        for(int i = 0; i < nbPlats; i++)
        {
            spawn.y += Random.Range(minY, maxY);
            spawn.x = Random.Range(-lvlWidth, lvlWidth);
            Instantiate(prefabPlat, spawn, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
