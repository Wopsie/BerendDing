using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour 
{
	
	// Update is called once per frame
	void Update () 
    {
        //if player is in range
            //attack

        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 10f);
        int i = 0;
        while (i < hitColliders.Length) 
        {
            hitColliders[i].SendMessage("AddDamage");
            i++;
        
        }

        Gizmos.DrawSphere(transform.position, 10f);
	}
}
