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
        vel_nau = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentNau();

        DispararBala();

    }

    private void MovimentNau()
    {
        //Encontrar limites
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        float anchura = spriteRenderer.bounds.size.x / 2;
        float altura = spriteRenderer.bounds.size.y / 2;

        float limitEsquerraX = -Camera.main.orthographicSize * Camera.main.aspect + anchura;
        float limitDretaX = Camera.main.orthographicSize * Camera.main.aspect - anchura;

        float limitabajoY = -Camera.main.orthographicSize + altura;
        float limitarribaY = Camera.main.orthographicSize - altura;
        
        //Mover la nave
        float direccio_horitzontal = Input.GetAxisRaw("Horizontal");
        //Debug.Log("direccio_horitzontal=" + direccio_horitzontal);
        float direccio_vertical = Input.GetAxisRaw("Vertical");
        Vector2 direccio_indicada = new Vector2(direccio_horitzontal, direccio_vertical).normalized;

        Vector2 posicio_objecte = transform.position; //Ens retorna la posicio actual de la nau.
        posicio_objecte += direccio_indicada * vel_nau * Time.deltaTime;

        posicio_objecte.x = Mathf.Clamp(posicio_objecte.x, limitEsquerraX, limitDretaX);
        posicio_objecte.y = Mathf.Clamp(posicio_objecte.y, limitabajoY, limitarribaY);

        transform.position = posicio_objecte;
    }

    private void DispararBala()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bala = Instantiate(Resources.Load("Prefabs/Bala") as GameObject);
            Vector2 novaPos1 = transform.position;
            bala.transform.position = novaPos1;
        }
    }
    /*Vector2 novaPos2 = transform.position;
    novaPos1.x = novaPos1.x + 0.2f;
    novaPos2.x = novaPos2.x - 0.2f;
    bala.transform.position = novaPos2;*/
}
