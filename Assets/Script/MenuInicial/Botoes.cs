using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    [SerializeField] private GameObject telaMenuInicial, telaEscolheMapa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoMap()
    {
        telaMenuInicial.SetActive(false);
        telaEscolheMapa.SetActive(true);
    }
    public void Mapa1()
    {
        SceneManager.LoadScene(0);
    }
    public void Mapa2()
    {
        SceneManager.LoadScene(1);
    }
    public void Mapa3()
    {
        SceneManager.LoadScene(2);
    }
}
