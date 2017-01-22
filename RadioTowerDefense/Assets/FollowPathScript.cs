using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPathScript : MonoBehaviour {
    private Vector3 targetVector3;
    private int speed = 3;
    public int pathToFollow = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        targetVector3 = new Vector3(0,0,0);
        iTween.MoveUpdate(this.gameObject,iTween.Hash("time",speed,"orienttopath",true,"position",targetVector3));
	}
}
