using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scoreScript : MonoBehaviour {
    TextMeshProUGUI txt; 
	void Start () {
        txt = gameObject.GetComponent<TextMeshProUGUI>(); 
	}
	
	void Update () {
        txt.text = PlayerPrefs.GetInt("score").ToString(); 
	}
}
