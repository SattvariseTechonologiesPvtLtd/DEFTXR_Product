using UnityEngine;
using System.Collections;
using System;

public class FloorCollision : MonoBehaviour
{

    public Vector3 myLoc;
    public Quaternion rotation;

    public void Start()
    {

        myLoc = this.transform.position;
        rotation = this.transform.rotation;
    }

    public void OnCollisionEnter(Collision other) {

        if (String.Compare(other.gameObject.name, "floor") == 0)
        {
            Debug.Log(other.gameObject.name);
            this.gameObject.transform.position = myLoc;
            this.gameObject.transform.rotation = rotation;

        }

    }

   
}
