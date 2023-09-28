using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Nau1;
    public GameObject GameOver;
    public enum EstatsGameManager{
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

    private void ActualitzaEstatGameManager(){
        switch(_estatGameManager){
            case EstatsGameManager.Inici:
                Nau1.SetActive(false);
                GameObject.Find("TitolJoc").SetActive(true);
                GameOver.SetActive(false);
                GameObject.Find("BotoInici").SetActive(true);
                break;
            case EstatsGameManager.Jugant:
                Nau1.SetActive(true);
                GameObject.Find("TitolJoc").SetActive(false);
                GameOver.SetActive(false);
                GameObject.Find("BotoInici").SetActive(false);
                break;
            case EstatsGameManager.GameOver:
                Nau1.SetActive(false);
                GameObject.Find("TitolJoc").SetActive(false);
                GameOver.SetActive(true);
                GameObject.Find("BotoInici").SetActive(false);
                break;
        }
    }

    public void SetEstatGameManager(EstatsGameManager estat){
        _estatGameManager = estat;
        ActualitzaEstatGameManager();
    }

    public void PassarAEstatJugant(){
        _estatGameManager = EstatsGameManager.Jugant;
        ActualitzaEstatGameManager();
    }
}
