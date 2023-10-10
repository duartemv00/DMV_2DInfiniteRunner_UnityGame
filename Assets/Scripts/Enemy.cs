using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    EndlessScroll es;

    void Start() {
        es = GetComponent<EndlessScroll>();
    }
    
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player" && GameManager.Instance.NumLives>1) {
            GameManager.Instance.LoseLive();
            es.ResetPosition();
        } else if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
