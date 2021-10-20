using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    //add points
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Scorekeeper.Instance.AddScore();
            Destroy(gameObject);
        }
    }

}
