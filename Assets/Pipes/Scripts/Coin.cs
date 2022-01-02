using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private SpriteRenderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(myRenderer.enabled == true)
            {
                GameManager.instance.CoinCollected();
            }
            myRenderer.enabled = false;
        }

        if (collision.gameObject.name == "CoinActivateCollider")
        {
            myRenderer.enabled = true;
        }
    }


}
