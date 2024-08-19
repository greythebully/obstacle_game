using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scorer : MonoBehaviour
{
    int hits = 0;
   private void OnCollisionEnter(Collision other)
   {
    if(other.gameObject.tag != "hit")
    {
        hits++;
        Debug.Log("No. of times you have hit the wall: " + hits);
   }
    }
        
}
