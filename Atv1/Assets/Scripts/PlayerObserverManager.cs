using System;
using UnityEngine;

public static class PlayerObserverManager
{
    public static Action<int> onPlayerMoedasChanged;

    public static void ChangedMoedas(int moedas)
    {
        onPlayerMoedasChanged?.Invoke(moedas);
    }
}
