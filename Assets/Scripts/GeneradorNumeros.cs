using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GeneradorDeNumeros : MonoBehaviour
{
    public GameObject _PrefactNumero;
    // Start is called before the first frame update

    public void IniciaGeneracioNums()
    {
        //El primer parametro es el metodo de respawn
        //El segundo es el tiempo que tarda en empezar a respawnear
        //El tercero es el tiempo entre respawn y respawn
        InvokeRepeating("GeneradorNumeros", 1f, 1f);

    }

    public void AturaGeneracioNums(){
        CancelInvoke("GeneradorNumeros");
    }
    void Start()
    {

    }

    /*
        * Invoke()
        * invokeRepeating()
        * CancelInvoke()
        */
    // Update is called once per frame
    void Update()
    {


    }

    private void GeneradorNumeros()
    {
        GameObject numero = Instantiate(_PrefactNumero);
        Vector2 costatSuperiorDret = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 costatSuperiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        numero.transform.position = new Vector2(Random.Range(costatSuperiorDret.x, costatSuperiorEsquerra.x), costatSuperiorDret.y);

    }
}
