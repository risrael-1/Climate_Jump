using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public GameObject player;
    public GameObject platPrefab;
    public GameObject prefadBigPlat;
    public GameObject prefadJetpack;
    public GameObject objectO2;
    public GameObject objectO2X2;

    void Start()
    {
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetString("HighScore", "0");
        }
       
    }

    void Update()
    {
        
    }

    private GameObject getTypeObject(string tag)
    {
        if (tag == "plat")
        {
            return platPrefab;
        }
        if (tag == "platbounds")
        {
            return prefadBigPlat;
        }
        if (tag == "plato2X2")
        {
            return objectO2X2;
        }
        if (tag == "plato2")
        {
            return objectO2;
        }
        if (tag == "jet")
        {
            return prefadJetpack;
        }

        return platPrefab;

    }

    private int getdistancePlayer(string tag)
    {
        if (tag == "plat")
        {
            return 8;
        }
        if (tag == "platbounds")
        {
            return 10;
        }
        if (tag == "plato2X2")
        {
            return 30;
        }
        if (tag == "plato2")
        {
            return 20;
        }
        if (tag == "jet")
        {
            return 25;
        }

        return 0;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != null)
        {
            if (collision.gameObject.tag != "DeadZone")
            {

                platPrefab.tag = collision.gameObject.tag;
                Destroy(collision.gameObject);
                Instantiate(getTypeObject(platPrefab.tag), new Vector2(Random.Range(-3f, 3f), player.transform.position.y + (getdistancePlayer(platPrefab.tag) + Random.Range(-0.5f, 1f))), Quaternion.identity);
                 
            }
        }
    }
}
