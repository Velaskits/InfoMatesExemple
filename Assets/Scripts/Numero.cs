using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Numero : MonoBehaviour
{
    private float _vel;
    private int _vlaorNumero;
    public Sprite[] _SpriteNumeros = new Sprite[10];
    // Start is called before the first frame update
    void Start()
    {
        _vel = 15f;
        System.Random aleatori = new System.Random();
        _vlaorNumero = aleatori.Next(0,10); //Aleatorio con un rango de 0 al 9.
        //Accedemos al componente Sprite Rnederer y dentro de este componente vamos al atributo Sprite.
        gameObject.GetComponent<SpriteRenderer>().sprite = _SpriteNumeros[_vlaorNumero];
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y = novaPos.y - _vel * Time.deltaTime;
        Debug.Log(Time.deltaTime);
        transform.position = novaPos;

        DestruyeFueraLimites();
    }

    private void OnTriggerEnter2D(Collider2D objecteTocat){
        if(objecteTocat.tag == "Bala" || objecteTocat.tag == "NauJugador"){
            Destroy(gameObject);
        }
    }
    private void DestruyeFueraLimites(){
        Vector2 costatInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        if(transform.position.y <= costatInferiorEsquerra.y){
            Destroy(gameObject);
        }
    }
}
