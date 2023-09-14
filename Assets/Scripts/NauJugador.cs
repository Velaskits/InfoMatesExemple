using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class NauJugador : MonoBehaviour
{
    public float vel_nau;
    // Start is called before the first frame update
    void Start()
    {
        vel_nau = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float direccio_horitzontal = Input.GetAxisRaw("Horizontal");
        //Debug.Log("direccio_horitzontal=" + direccio_horitzontal);
        Vector2 direccio_indicada = new Vector2(direccio_horitzontal, 0f);
        Vector2 posicio_objecte = transform.position; //Ens retorna la posicio actual de la nau.
        posicio_objecte += direccio_indicada * vel_nau * Time.deltaTime;
        transform.position = posicio_objecte;
    }
}
