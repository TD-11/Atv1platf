using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MoedasTextController : MonoBehaviour
{
    private TMP_Text moedasText;

    private void OnValidate()
    {
        moedasText = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        PlayerObserverManager.onPlayerMoedasChanged += AtualizaMoedas;
    }

    private void OnDisable()
    {
        PlayerObserverManager.onPlayerMoedasChanged -= AtualizaMoedas;
    }

    private void AtualizaMoedas(int valor)
    {
        moedasText.text = "Moedas: " + valor.ToString();
    }
}
