using UnityEngine;
using System.Collections;
using System;

public class ZoneBTouchAnimCollider : MonoBehaviour
{
    public int myTouchId;


    public void OnTriggerEnter(Collider other)
    {
        if (String.Compare(other.gameObject.name, "touchInput") == 0)
        {
            Debug.Log("workinggggg");

            this.gameObject.GetComponent<Collider>().enabled = false;
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            StartCoroutine(callandwait());
        }
    }

    IEnumerator callandwait()
    {
        ZoneBManager.Instance.zoneBTouchInputAnim(myTouchId);
        yield return new WaitForSeconds(3f);
        this.gameObject.GetComponent<Collider>().enabled = true;
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
