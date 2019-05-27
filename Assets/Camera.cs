using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Camera : NetworkBehaviour 
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject clientCamera;

	void Start () 
    {
        if (this.isServer)
        {
            mainCamera.SetActive(true);
            clientCamera.SetActive(false);
        }
        else if (this.isClient)
        {
            mainCamera.SetActive(false);
            clientCamera.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
