using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   void OnGetAnimationFinished()
    {
        Debug.Log("�I�u�W�F�N�g��j�����܂�");

    }
   void OnTriggerEnter(Collider other)
    {
        
        //Debug.Log(other.name + " ���ڐG����");
        // Destroy(gameObject);
    }

    void OnTriggerExit(Collider other)
    {

    }
}