using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform tpPoint;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name.Equals("Plattform")) {
            gameObject.transform.position = tpPoint.position;
            Physics.SyncTransforms();
        }
    }
}
