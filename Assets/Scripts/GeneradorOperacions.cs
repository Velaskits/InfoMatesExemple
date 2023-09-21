using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOperacions : MonoBehaviour
{
    public GameObject _PrefabsOperacio;
    // Start is called before the first frame update
    void Start()
    {
        //El primer parametro es el metodo de respawn
        //El segundo es el tiempo que tarda en empezar a respawnear
        //El tercero es el tiempo entre respawn y respawn
        InvokeRepeating("Genera", 1f, 3f);
        
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

    private void Genera(){
        GameObject numero = Instantiate(_PrefabsOperacio);
        Vector2 costatSuperiorDret = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
        Vector2 costatSuperiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

        numero.transform.position = new Vector2(Random.Range(costatSuperiorDret.x,costatSuperiorEsquerra.x), costatSuperiorDret.y);
        
    }
}

