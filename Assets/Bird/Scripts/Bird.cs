using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rbBird;
    [SerializeField] private float velocityAmount = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rbBird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MakeBirdFly();
    }
     
    public void MakeBirdFly()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rbBird.velocity = Vector2.up * velocityAmount;
        }
    }
}
