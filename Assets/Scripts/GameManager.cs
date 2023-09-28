using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Nau1;
    public GameObject GameOver;
    public GameObject TituloJuego;
    public GameObject BotoInici;
    public GameObject GeneradorNumeros;
    public GameObject GeneradorOperacions;
    public enum EstatsGameManager
    {
        Inici,
        Jugant,
        GameOver
    }

    private EstatsGameManager _estatGameManager;

    // Start is called before the first frame update
    void Start()
    {
        _estatGameManager = EstatsGameManager.Inici;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ActualitzaEstatGameManager()
    {
        switch (_estatGameManager)
        {
            case EstatsGameManager.Inici:
                Nau1.SetActive(false);
                TituloJuego.SetActive(true);
                GameOver.SetActive(false);
                BotoInici.SetActive(true);
                break;
            case EstatsGameManager.Jugant:
                GeneradorNumeros.GetComponent<GeneradorDeNumeros>().IniciaGeneracioNums();
                GeneradorOperacions.GetComponent<GeneradorOperacions>().IniciaGeneracioOper();
                Nau1.SetActive(true);
                TituloJuego.SetActive(false);
                GameOver.SetActive(false);
                BotoInici.SetActive(false);
                break;
            case EstatsGameManager.GameOver:
                GeneradorNumeros.GetComponent<GeneradorDeNumeros>().AturaGeneracioNums();
                GeneradorOperacions.GetComponent<GeneradorOperacions>().AturaGeneracioOper();
                Nau1.SetActive(false);
                TituloJuego.SetActive(false);
                GameOver.SetActive(true);
                BotoInici.SetActive(false);
                break;
        }
    }

    public void SetEstatGameManager(EstatsGameManager estat)
    {
        _estatGameManager = estat;
        ActualitzaEstatGameManager();
    }

    public void PassarAEstatJugant()
    {
        _estatGameManager = EstatsGameManager.Jugant;
        ActualitzaEstatGameManager();
    }
}
