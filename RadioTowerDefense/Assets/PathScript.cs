using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathScript : MonoBehaviour {
    //public Transform[] path;
    private Transform aNode;
    // Use this for initialization
    void Start () {
        globalValues.path = this.GetComponentsInChildren<Transform>(); 
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
