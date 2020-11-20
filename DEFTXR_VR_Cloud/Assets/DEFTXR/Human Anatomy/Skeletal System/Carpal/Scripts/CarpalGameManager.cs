using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CarpalGameManager : MonoBehaviour
{
    // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;
    public GameObject CarpalinsertionObj,CarpaloriginObj, CarpalDefaultObj;
    //public GameObject pecuBtn, sidedeterBtn, featureBtn, clinAnaBtn, ossiBtn;
    public GameObject CarpalinsertioBtn, CarpaloriginBtn;
    public Sprite selected, Dselected;
    public bool attch, CarpalinserAttch, CarpalorigAttach = false;

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
                if (CarpalinserAttch == false)
                {
                    CarpalinsertioBtn.GetComponent<Image>().sprite = selected;
                   CarpalinsertionObj.SetActive(true);
                    CarpaloriginObj.SetActive(false);
                    CarpalDefaultObj.SetActive(false);
                  



                    CarpalinserAttch = true;
                }
                else
                {
                    CarpalinsertioBtn.GetComponent<Image>().sprite = Dselected;
                    CarpalinsertionObj.SetActive(false);
                    CarpaloriginObj.SetActive(false);
                    CarpalDefaultObj.SetActive(true);
                

                    CarpalinserAttch = false;
                }
            }

            if (string.Compare(UIManager.Instance.selectedBtnName, "Origin") == 0)
            {
                if (CarpalorigAttach == false)
                {
                    CarpaloriginBtn.GetComponent<Image>().sprite = selected;
                    CarpalinsertionObj.SetActive(false);
                    CarpaloriginObj.SetActive(true);
                    CarpalDefaultObj.SetActive(false);
                  
                    CarpalorigAttach = true;
                }
                else
                {

                    CarpaloriginBtn.GetComponent<Image>().sprite = Dselected;
                    CarpalinsertionObj.SetActive(false);
                    CarpaloriginObj.SetActive(false);
                    CarpalDefaultObj.SetActive(true);
              
                    CarpalorigAttach = false;
                }
            }

           



        }


    }
}
