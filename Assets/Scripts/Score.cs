using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    int Hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        Hits++;
        Debug.Log("Your Score is now: "+ Hits);
      
    }


}
