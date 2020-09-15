using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotater : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        for (int i =3; i < 5; i++) {
            System.Console.WriteLine("{0}", i);
        }
        Console.ReadLine();

    }

}
