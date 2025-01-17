using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class GameHandeler : MonoBehaviour
{
    public static int CoinCount = 0; // Initialize the coin count
    public TextMeshProUGUI CoinText; // Reference to your TextMeshPro text UI

    private void FixedUpdate()
    {
        CoinText.text = "Coins: " + CoinCount.ToString();
    }
    public static void AddCoin()
    {
        CoinCount++; // Increment the coin count
    }
}
