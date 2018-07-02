using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movpiso : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (piso.instance.choque == true)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
	}
}
