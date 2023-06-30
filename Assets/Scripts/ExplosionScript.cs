using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    void Awake() 
    {
        StartCoroutine(WaitForDestruct());
    }

    private IEnumerator WaitForDestruct()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
