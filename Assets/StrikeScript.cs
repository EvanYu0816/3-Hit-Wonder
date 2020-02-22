using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class StrikeScript : MonoBehaviour {


    public static TextMeshProUGUI txt;
    void Start()
    {
        txt = gameObject.GetComponent<TextMeshProUGUI>();
    }
    public static int upd(bool inc) {
        if (!inc) txt.text = "";
        else txt.text += "X ";
        return txt.text.Length / 2; 
    }
}
