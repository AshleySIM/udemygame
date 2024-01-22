using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = -1; 
 private void OnCollisionEnter(Collision other)
  {
    if(other.gameObject.tag != "Hit")
    {

    
    hits++;

    Debug.Log("you bumped into the walls this many times: " +hits);
  }
  }
}
