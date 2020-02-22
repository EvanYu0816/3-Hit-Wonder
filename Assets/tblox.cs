using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tblox : MonoBehaviour {

    public Color[] c;
    SpriteRenderer sr;
	void Start () {
        sr = gameObject.GetComponent<SpriteRenderer>();
        InvokeRepeating("randcol", 0, 0.5f); 
        
	}
    void randcol (){
        sr.color = c[Random.Range(0, 4)]; 
    }
}
