using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    //If an object collies with a trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Add score
        Score.score++;
    }
}
