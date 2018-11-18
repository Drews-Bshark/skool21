using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject objects;
    public float x = 100F;
    private float i = 0F;
    private bool flag = false;

    void Update()
    {
        float speed = Random.Range(0.0001F, 0.001F);
        i += 0.8F;
        int rand = Random.Range(0, 3);


        if (i > x)
        {
            if (rand == 0)
            {
                GameObject.Instantiate(objects);
                objects.transform.position = new Vector3(-8F, 4F);
            }
            if (rand == 1)
            {
                GameObject.Instantiate(objects);
                objects.transform.position = new Vector3(0F, 4F);
            }
            if (rand == 2)
            {
                GameObject.Instantiate(objects);
                objects.transform.position = new Vector3(8F, 4F);
            }
            i = 0;            
        }
    }
}


