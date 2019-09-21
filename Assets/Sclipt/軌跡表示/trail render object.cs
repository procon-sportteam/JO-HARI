using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour {

    public float speed;
    public float destroyTime;

    void Start () {
        Destroy(gameObject, destroyTime);
    }
    
    void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}