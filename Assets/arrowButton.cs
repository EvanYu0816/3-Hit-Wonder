using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowButton : MonoBehaviour {

    public bool cw;
    public GameObject ring;
    public int w;
    Transform rt;
    bool prsd; 
	void Start () {
        rt = ring.transform;
        prsd = false;
    }
    void Update() {
        if (prsd ) rt.RotateAround(rt.position, cw ? Vector3.back : Vector3.forward, w * Time.deltaTime);
    }
    void OnMouseDown() {
        prsd = true; 
    }
    void OnMouseUp() {
        prsd = false; 
    }
}
