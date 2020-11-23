using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HipBone_GameManager : MonoBehaviour
{
    // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;
    public GameObject HipBoneinsertionObj, HipBoneoriginObj, HipBoneclavDefaultObj, HipBoneligamentObj;
    //public GameObject pecuBtn, sidedeterBtn, featureBtn, clinAnaBtn, ossiBtn;
    public GameObject HipBoneligamentBtn, HipBoneinsertioBtn, HipBoneoriginBtn;
    public Sprite selected, Dselected;
    public bool attch, HipBoneinserAttch, HipBoneligamentAttach, HipBoneorigAttach = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ClickandSelect();
    }

    void ClickandSelect()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {



            if (string.Compare(UIManager.Instance.selectedBtnName, "Insertion") == 0)
            {
                if (HipBoneinserAttch == false)
                {
                    HipBoneinsertioBtn.GetComponent<Image>().sprite = selected;
                    HipBoneinsertionObj.SetActive(true);
                    HipBoneoriginObj.SetActive(false);
                    HipBoneclavDefaultObj.SetActive(false);
                    HipBoneligamentObj.SetActive(false);



                    HipBoneinserAttch = true;
                }
                else
                {
                    HipBoneinsertioBtn.GetComponent<Image>().sprite = Dselected;
                    HipBoneinsertionObj.SetActive(false);
                    HipBoneoriginObj.SetActive(false);
                    HipBoneclavDefaultObj.SetActive(true);
                    HipBoneligamentObj.SetActive(false);

                    HipBoneinserAttch = false;
                }
            }

            if (string.Compare(UIManager.Instance.selectedBtnName, "Origin") == 0)
            {
                if (HipBoneorigAttach == false)
                {
                    HipBoneoriginBtn.GetComponent<Image>().sprite = selected;
                    HipBoneinsertionObj.SetActive(false);
                    HipBoneoriginObj.SetActive(true);
                    HipBoneclavDefaultObj.SetActive(false);
                    HipBoneligamentObj.SetActive(false);
                    HipBoneorigAttach = true;
                }
                else
                {

                    HipBoneoriginBtn.GetComponent<Image>().sprite = Dselected;
                    HipBoneinsertionObj.SetActive(false);
                    HipBoneoriginObj.SetActive(false);
                    HipBoneclavDefaultObj.SetActive(true);
                    HipBoneligamentObj.SetActive(false);
                    HipBoneorigAttach = false;
                }
            }

            if (string.Compare(UIManager.Instance.selectedBtnName, "Ligaments") == 0)
            {

                if (HipBoneligamentAttach == false)
                {
                    HipBoneligamentBtn.GetComponent<Image>().sprite = selected;
                    HipBoneinsertionObj.SetActive(false);
                    HipBoneoriginObj.SetActive(false);
                    HipBoneclavDefaultObj.SetActive(false);
                    HipBoneligamentObj.SetActive(true);
                    HipBoneligamentAttach = true;
                }
                else
                {

                    HipBoneligamentBtn.GetComponent<Image>().sprite = Dselected;
                    HipBoneinsertionObj.SetActive(false);
                    HipBoneoriginObj.SetActive(false);
                    HipBoneclavDefaultObj.SetActive(true);
                    HipBoneligamentObj.SetActive(false);
                    HipBoneligamentAttach = false;
                }

            }




        }


    }
}
