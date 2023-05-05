using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	public GameObject TV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.position += new Vector3(-0.3f, 0, -0.3f) * Time.deltaTime;
    	if( transform.position.x < TV.transform.position.x-0.5f && transform.position.z < TV.transform.position.z-0.5f)
    	{
    		transform.rotation = Quaternion.Euler(0.0f, 39.7f, 0.0f);
    	}
    }
}
