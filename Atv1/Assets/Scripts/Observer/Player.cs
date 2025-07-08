using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int moedas = 0;
    public float velocidade;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            moedas++;
            PlayerObserverManager.ChangedMoedas(moedas);
        }
        
        Movimento();
    }
    
    void Movimento()
    {
        float movimentoHorizontal = 0f;
        if (Input.GetKey(KeyCode.D))
        {
            movimentoHorizontal = 1f;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            movimentoHorizontal = -1f;
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        else
        {
            movimentoHorizontal = 0f;
        }

        transform.position += new Vector3(movimentoHorizontal, 0f, 0f) * velocidade * Time.deltaTime;
    }
}
