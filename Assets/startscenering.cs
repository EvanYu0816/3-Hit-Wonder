using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscenering : MonoBehaviour {
    Transform tf;
	void Start () {
        tf = gameObject.transform; 
	}
	
	
	void Update () {
        tf.RotateAround(tf.position, Vector3.back, 45*Time.deltaTime); 
	}
}
