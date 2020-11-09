using UnityEngine;
using System.Collections;
using System;

public class TargetCollider : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {

        if (String.Compare(other.gameObject.name, "Player") == 0)
        {
            Debug.Log(other.gameObject.name);
            GameManager.Instace.playTutorialStage(GameManager.Instace.tutorialStageCount);
            this.gameObject.SetActive(false);
        }
    }
}
