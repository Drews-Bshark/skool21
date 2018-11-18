using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cube : MonoBehaviour
{
    private float speed;
    public GameObject objects;  
    private void Start()
    {
        speed = Random.Range(0.05F, 0.1F);
    }
    void Update()
    {
        objects.transform.Translate(0, -speed, 0);
        if (transform.position.x <= -6F && (Input.GetKeyDown("a") && transform.position.y <= -3F))
        {
            Debug.Log("Precision:" + (4.5 - transform.position.y) * 10);
            GameObject.Destroy(objects);
        }
        if (transform.position.x > -6F && transform.position.x < 6F && Input.GetKeyDown("s") && transform.position.y <= -3F)
        {
            Debug.Log("Precision:" + (4.5 - transform.position.y) * 10);
            GameObject.Destroy(objects);
        }
        if (transform.position.x >= 6F && Input.GetKeyDown("d") && transform.position.y <= -3F)
        {
            Debug.Log("Precision:" + (4.5 - transform.position.y) * 10);
            GameObject.Destroy(objects);
        }
        if(transform.position.y <= -4.5F)
            GameObject.Destroy(objects);

    }      
}