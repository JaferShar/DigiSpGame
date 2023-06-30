using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform tpPoint1;
    public Transform tpPoint2;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name.Equals("Plattform")) {
            gameObject.transform.position = tpPoint1.position;
            Physics.SyncTransforms();
        } else if (other.gameObject.name.Equals("Plattform2")) {
            gameObject.transform.position = tpPoint2.position;
            Physics.SyncTransforms();
        }
    }
}
