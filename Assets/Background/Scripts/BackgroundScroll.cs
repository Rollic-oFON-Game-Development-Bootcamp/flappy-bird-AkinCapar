using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] Vector2 moveSpeed;

    Vector2 offSet;
    Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offSet = moveSpeed * Time.deltaTime;
        material.mainTextureOffset += offSet;
    }
}
