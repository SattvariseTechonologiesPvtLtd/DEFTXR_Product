using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rib_11 : MonoBehaviour
{
    public GameObject zoneBObj;
    public GameObject insertionObj, originObj, DefaultObj;

    public bool attch, inserAttch, origAttach = false;

    public Sprite enable, disable;

    public GameObject[] insertionsList;
    public GameObject[] originsList;

    public bool isAllInsertionsSelected;
    public bool isAllOriginsSelected;

    public GameObject origin_dropdown;
    public GameObject originsSelectAllButtonTick;
    public GameObject originsSubButtonsParent;

    public GameObject insertion_dropdown;
    public GameObject insertionsSelectAllButtonTick;
    public GameObject insertionsSubButtonsParent;

    public GameObject insertionBtn;
    public GameObject originBtn;

    // Use this for initialization
    void Start()
    {
        isAllInsertionsSelected = false;
        isAllOriginsSelected = false;

        insertion_dropdown.SetActive(false);
        origin_dropdown.SetActive(false);

        insertionBtn.GetComponent<Image>().sprite = disable;
        originBtn.GetComponent<Image>().sprite = disable;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void selectAllInsertions()
    {
        if (isAllInsertionsSelected == false)
        {
            insertionsSelectAllButtonTick.SetActive(true);

            for (int i = 0; i < insertionsList.Length; i++)
            {
                insertionsList[i].SetActive(true);
            }
            foreach (Transform a in insertionsSubButtonsParent.transform)
            {
                a.GetChild(1).transform.GetChild(0).gameObject.SetActive(true);
            }
            isAllInsertionsSelected = true;
        }
        else
        {
            insertionsSelectAllButtonTick.SetActive(false);

            for (int i = 0; i < insertionsList.Length; i++)
            {
                insertionsList[i].SetActive(false);
            }

            foreach (Transform z in insertionsSubButtonsParent.transform)
            {
                z.GetChild(1).transform.GetChild(0).gameObject.SetActive(false);

            }

            isAllInsertionsSelected = false;
        }
    }

    public void selectAllOrigins()
    {
        if (isAllOriginsSelected == false)
        {
            originsSelectAllButtonTick.SetActive(true);

            for (int k = 0; k < originsList.Length; k++)
            {
                originsList[k].SetActive(true);
            }
            foreach (Transform t in originsSubButtonsParent.transform)
            {
                t.GetChild(1).transform.GetChild(0).gameObject.SetActive(true);
            }
            isAllOriginsSelected = true;
        }
        else
        {
            originsSelectAllButtonTick.SetActive(false);

            for (int k = 0; k < originsList.Length; k++)
            {
                originsList[k].SetActive(false);
            }

            foreach (Transform t in originsSubButtonsParent.transform)
            {
                t.GetChild(1).transform.GetChild(0).gameObject.SetActive(false);

            }

            isAllOriginsSelected = false;
        }
    }


    public void onInsertionsButtonClick()
    {
        if (inserAttch == false)
        {

            insertionObj.SetActive(true);
            originObj.SetActive(false);
            DefaultObj.SetActive(false);
            insertion_dropdown.SetActive(true);

            insertionBtn.GetComponent<Image>().sprite = enable;

            inserAttch = true;
        }
        else
        {

            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(true);
            insertion_dropdown.SetActive(false);

            insertionBtn.GetComponent<Image>().sprite = disable;

            inserAttch = false;
        }
    }

    public void onOriginsButtonClick()
    {
        if (origAttach == false)
        {

            insertionObj.SetActive(false);
            originObj.SetActive(true);
            DefaultObj.SetActive(false);
            origin_dropdown.SetActive(true);

            originBtn.GetComponent<Image>().sprite = enable;

            origAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(true);
            origin_dropdown.SetActive(false);

            originBtn.GetComponent<Image>().sprite = disable;

            origAttach = false;
        }
    }
}
