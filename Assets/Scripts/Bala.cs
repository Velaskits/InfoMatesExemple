using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Bala : MonoBehaviour
{
    public float velocity = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y += velocity * Time.deltaTime;
        transform.position = novaPos;

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        float altura = spriteRenderer.bounds.size.y /2;
        float limitarribaY = Camera.main.orthographicSize;
        transform.position = novaPos;
        if(novaPos.y >= limitarribaY){
            Destroy(gameObject);
        }
    }
}
