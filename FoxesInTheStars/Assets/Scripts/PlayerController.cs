using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform transform;
    [Range(0.1f, 1f)]
    public float Speed;
	void Start ()
	{
	    transform = GetComponent<Transform>();
	}
	
	
	void Update ()
	{
	    if (Input.GetKey(KeyCode.D))
	    {
	        transform.position = new Vector3(transform.position.x + Speed, transform.position.y);
	    }

	    if (Input.GetKey(KeyCode.A))
	    {
	        transform.position = new Vector3(transform.position.x - Speed, transform.position.y);
        }
	}
}
