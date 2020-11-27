using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HipBone_GameManager : MonoBehaviour
{
    public GameObject zoneBObj;
    public GameObject HipBoneinsertionObj, HipBoneoriginObj, HipBoneDefaultObj, HipBoneligamentObj;

    public bool attch, inserAttch, ligamentAttach, origAttach = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onInsertionButtonClick()
    {
        if (inserAttch == false)
        {

            HipBoneinsertionObj.SetActive(true);
            HipBoneoriginObj.SetActive(false);
            HipBoneDefaultObj.SetActive(false);
            HipBoneligamentObj.SetActive(false);



            inserAttch = true;
        }
        else
        {

            HipBoneinsertionObj.SetActive(false);
            HipBoneoriginObj.SetActive(false);
            HipBoneDefaultObj.SetActive(true);
            HipBoneligamentObj.SetActive(false);

            inserAttch = false;
        }
    }

    public void onOriginButtonClick()
    {
        if (origAttach == false)
        {

            HipBoneinsertionObj.SetActive(false);
            HipBoneoriginObj.SetActive(true);
            HipBoneDefaultObj.SetActive(false);
            HipBoneligamentObj.SetActive(false);
            origAttach = true;
        }
        else
        {


            HipBoneinsertionObj.SetActive(false);
            HipBoneoriginObj.SetActive(false);
            HipBoneDefaultObj.SetActive(true);
            HipBoneligamentObj.SetActive(false);
            origAttach = false;
        }
    }

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

            HipBoneinsertionObj.SetActive(false);
            HipBoneoriginObj.SetActive(false);
            HipBoneDefaultObj.SetActive(false);
            HipBoneligamentObj.SetActive(true);
            ligamentAttach = true;
        }
        else
        {


            HipBoneinsertionObj.SetActive(false);
            HipBoneoriginObj.SetActive(false);
            HipBoneDefaultObj.SetActive(true);
            HipBoneligamentObj.SetActive(false);
            ligamentAttach = false;
        }
    }
}
