using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public HUD hud;

    //COIN STUFF
    public int NumCoins { get { return numCoins; }} 
    private int numCoins = 0;

    public int NumLives { get { return numLives; }}
    private int numLives = 3;

    //HEALTH STUFF

    void Awake() {
        if(Instance == null) {
            Instance = this;
        } else {
            Debug.Log("Too many GameManager Instances");
        }
    }

    public void SumCoins(int addCoins) {
        numCoins += addCoins;
        hud.UpdateCoins(numCoins);
    }

    public void LoseLive() {
        numLives -= 1;
        hud.DeactivateLive(numLives);
    }
}
