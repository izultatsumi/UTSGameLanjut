using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaimonChase : MonoBehaviour {

    public Transform target;
    float paimonSpeed = 0.5f;

    const float tabrak = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.position);

        if((transform.position - target.position).magnitude > tabrak)
            transform.Translate(0f, 0f, paimonSpeed * Time.deltaTime);
	}
}
