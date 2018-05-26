 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFollower : MonoBehaviour
{
    public Camera followingCamera;
    private Transform transform;
    private Vector3 initialCameraPos;
	void Start ()
	{
	    transform = GetComponent<Transform>();
	    followingCamera.transform.position = new Vector3(transform.position.x, transform.position.y, followingCamera.transform.position.z);
	    initialCameraPos = followingCamera.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 newCameraPos = Vector3.Lerp(followingCamera.transform.position, new Vector3(transform.position.x, transform.position.y), .2f);
        followingCamera.transform.position = new Vector3(newCameraPos.x, newCameraPos.y, followingCamera.transform.position.z);
	}
}
