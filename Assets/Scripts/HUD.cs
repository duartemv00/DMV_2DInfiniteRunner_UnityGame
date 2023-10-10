using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI meters;
    public TextMeshProUGUI coins;

    public GameObject[] lives;

    void Update() {
        meters.text = (Time.timeSinceLevelLoad*4).ToString("#.") + " m";
    }

    public void UpdateCoins(int coinsTotales) {
        coins.text = coinsTotales.ToString();
    }

    public void DeactivateLive(int index) {
        lives[index].SetActive(false);
    }

    /*void ActivateLive(int index) {
        lives[index].SetActive(true);
    }*/
}
