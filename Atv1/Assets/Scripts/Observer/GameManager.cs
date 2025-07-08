using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.SceneManagement.SceneManager;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else Destroy(this.gameObject);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadScene(1);
        Invoke("LoadMainMenu", 3f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    

    private void LoadMainMenu()
    {
        LoadScene(2);
    }

    public void LoadGame()
    {
        LoadScene(3);
        LoadScene(4, LoadSceneMode.Additive);
    }
}