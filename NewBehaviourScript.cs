using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int dixanie = 100;
    private bool daed = false;
    void endGame ()
    {
        daed = true;
        Debug.Log("Balloon life time:" + Mathf.RoundToInt(Time.time) + "s");
        Destroy(gameObject);
   }
    private void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
    }
    void Update () {
        if (!daed)
        {
            if (gameObject.transform.localScale.x <= 0.1)
                endGame();
            if (Input.GetKeyDown("space") && dixanie > 10)
            {
                if (gameObject.transform.localScale.x >= 6)
                    endGame();
                dixanie -= 10;
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 0.1F, gameObject.transform.localScale.y + 0.1F, gameObject.transform.localScale.z);
            }
            else 
            if (dixanie < 100)
                dixanie += 1;
             gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x - 0.006F, gameObject.transform.localScale.y - 0.006F, gameObject.transform.localScale.z);    

            
        }
	}
}
