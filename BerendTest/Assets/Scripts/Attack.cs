using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Attack the Basterd");
        }
    }

    
}
