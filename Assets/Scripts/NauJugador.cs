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
        float direccio_vertical = Input.GetAxisRaw("Vertical");
        Vector2 direccio_indicada = new Vector2(direccio_horitzontal, direccio_vertical).normalized;

        float limitEsquerraX = -Camera.main.orthographicSize * Camera.main.aspect
        float limitDretaX = Camera.main.orthographicSize * Camera.main.aspect;

        Vector2 posicio_objecte = transform.position; //Ens retorna la posicio actual de la nau.
        posicio_objecte += direccio_indicada * vel_nau * Time.deltaTime;

        posicio_objecte.x = Mathf.Clamp(posicio_objecte.x, -5, 5);

        transform.position = posicio_objecte;
    }
}
