using UnityEngine;
using System.Collections;

public class FollowThis : MonoBehaviour {
    public GameObject followThis;
    public float XOffSet;
    public float ZOffSet;
    public float YOffSet;
	// Use this for initialization
    void Start() {
        transform.LookAt(followThis.transform);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 pos = followThis.transform.position;
        pos.x += XOffSet;
        pos.z += ZOffSet;
        pos.y += YOffSet;
        transform.position = pos;
    }
}
