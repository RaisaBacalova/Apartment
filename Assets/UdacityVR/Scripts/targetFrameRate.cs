using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFrameRate : MonoBehaviour {

    public int targert = 60;
	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
