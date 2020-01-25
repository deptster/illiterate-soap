using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalCounter : MonoBehaviour
{
    public TextMeshProUGUI CoinDisplay;
    public TextMeshProUGUI MultiplierDisplay;
    public int MyCoins;
    public int MyMultiplier = 1;

    void Update()
    {
        CoinDisplay.GetComponent<TextMeshProUGUI>().text = "Coin: " + MyCoins;
        MultiplierDisplay.GetComponent<TextMeshProUGUI>().text = "Multiplier: x" + MyMultiplier;
    }

    public void IncreaseCoin()
    {
        MyCoins += 1 * MyMultiplier;
    }

    public void CoinMultiplier()
    {
        MyCoins -= 10;
        MyMultiplier += 1;
    }
}
