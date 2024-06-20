using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   void OnGetAnimationFinished()
    {
        Debug.Log("オブジェクトを破棄します");

    }
   void OnTriggerEnter(Collider other)
    {
        
        //Debug.Log(other.name + " が接触した");
        // Destroy(gameObject);
    }

    void OnTriggerExit(Collider other)
    {

    }
}