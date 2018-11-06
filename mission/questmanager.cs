using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questmanager : MonoBehaviour {
    public Queststrings queststrings;
    
    public List<Quest> questtextboxes = new List<Quest>();
    // Use this for initialization
    void Start () {
       
        foreach (string Quest in queststrings.QuestsString)
        {
            questtextboxes.Add(new Quest(1, 0, Quest));
           
        }
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
