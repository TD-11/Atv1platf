using UnityEngine;
using UnityEngine.UI; 


public class Botoes : MonoBehaviour
{

    public Button botaoStart;
    public Button botaoQuit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        botaoStart.onClick.AddListener(StartGame);
        botaoQuit.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartGame()
    {
        GameManager.instance.LoadGame();
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
