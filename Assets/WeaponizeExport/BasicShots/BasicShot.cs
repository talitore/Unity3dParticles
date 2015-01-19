using UnityEngine;
using System.Collections;

public class BasicShot : MonoBehaviour {

    public float SpinSpeed = 5f;
    public float MoveSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(Vector3.forward * (Time.deltaTime * SpinSpeed), Space.World);
        transform.Translate(transform.forward * (Time.deltaTime * MoveSpeed));
	}
}
