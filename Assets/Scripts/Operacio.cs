using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Operacio : MonoBehaviour
{
    private float _vel;
    private int _valorOperacion;
    public Sprite[] _SpriteOpera = new Sprite[5];
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2f;
        System.Random aleatori = new System.Random();
        _valorOperacion = aleatori.Next(0,10); //Aleatorio con un rango de 0 al 9.
        //Accedemos al componente Sprite Rnederer y dentro de este componente vamos al atributo Sprite.
        gameObject.GetComponent<SpriteRenderer>().sprite = _SpriteOpera[_valorOperacion];
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
