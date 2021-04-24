using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonSetup : MonoBehaviour
{
	// Start is called before the first frame update
	void Start( )
	{
		GetComponent<VRM.VRMFirstPerson>( ).Setup( );
	}

	// Update is called once per frame
	void Update( )
	{
		
	}
}
