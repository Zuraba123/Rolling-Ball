using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoin : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public string coinTagString;
    public string badcoinTagString;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!" + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            score = score + 1;
        }
        else if (other.tag == "Bad Coin" && score > 0)
        {
            score = score - 1;
        }

        scoreText.text = "Score: " + score;
        Destroy(other.gameObject);
    }
}
