using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameHandeler.AddCoin();

            Debug.Log("coin picked up, current coin count is: " + GameHandeler.CoinCount);
            Destroy(gameObject);
        }   
    }
}
