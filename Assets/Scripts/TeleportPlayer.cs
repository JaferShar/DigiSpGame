using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform tpPoint;
    public GameObject player;

    private void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.name.Equals("Enemy")) Debug.Log("hittttttttt");
    }
}
