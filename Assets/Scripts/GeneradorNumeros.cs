using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNumeros : MonoBehaviour
{
    public GameObject _PrefactNumero;
    // Start is called before the first frame update
    void Start()
    {
        //El primer parametro es el metodo de respawn
        //El segundo es el tiempo que tarda en empezar a respawnear
        //El tercero es el tiempo entre respawn y respawn
        InvokeRepeating("GeneradorNumero", 1f, 3f);
        
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

    private void GeneradorNumero(){
        GameObject numero = Instantiate(_PrefactNumero);
        numero.transform.position = Camera.main.ViewportToWorldPoint(new Vector2(0.5f,1f));
        
    }
}
