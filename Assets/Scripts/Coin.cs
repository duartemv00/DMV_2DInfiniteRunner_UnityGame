using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            GameManager.Instance.SumCoins(coinValue);
            //Destroy(this.gameObject);
            transform.position = new Vector3(16,0,0);
        }
    }
}
