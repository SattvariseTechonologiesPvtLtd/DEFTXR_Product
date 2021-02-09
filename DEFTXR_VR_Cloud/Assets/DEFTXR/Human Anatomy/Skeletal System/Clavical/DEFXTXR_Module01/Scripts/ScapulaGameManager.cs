﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScapulaGameManager : MonoBehaviour
{

   // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;

    public GameObject insertionObj, originObj, DefaultObj, ligamentObj, featuresObj;

    public bool attch, inserAttch, ligamentAttach, origAttach, featureAttach = false;

    public Sprite enable, disable;

    public GameObject[] featuresList;
    public GameObject[] insertionsList;
    public GameObject[] originsList;
    public GameObject[] ligamentsList;

    public bool isAllFeaturesSelected;
    public bool isAllInsertionsSelected;
    public bool isAllLigamentsSelected;
    public bool isAllOriginsSelected;

    public GameObject feature_dropdown;
    public GameObject featureSelectAllButtonTick;
    public GameObject subButtonsParent;

    public GameObject ligaments_dropdown;
    public GameObject ligamentsSelectAllButtonTick;
    public GameObject ligamentsSubButtonsParent;

    public GameObject origin_dropdown;
    public GameObject originsSelectAllButtonTick;
    public GameObject originsSubButtonsParent;

    public GameObject insertion_dropdown;
    public GameObject insertionsSelectAllButtonTick;
    public GameObject insertionsSubButtonsParent;

    public GameObject insertionBtn;
    public GameObject ligamentsBtn;
    public GameObject originBtn;
    public GameObject featureBtn;

    // Use this for initialization
    void Start()
    {
        isAllFeaturesSelected = false;
        isAllInsertionsSelected = false;
        isAllOriginsSelected = false;
        isAllLigamentsSelected = false;

        insertion_dropdown.SetActive(false);
        ligaments_dropdown.SetActive(false);
        origin_dropdown.SetActive(false);
        feature_dropdown.SetActive(false);

        featureBtn.GetComponent<Image>().sprite = disable;
        insertionBtn.GetComponent<Image>().sprite = disable;
        originBtn.GetComponent<Image>().sprite = disable;
        ligamentsBtn.GetComponent<Image>().sprite = disable;

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void selectAllFeatures()
    {
        if (isAllFeaturesSelected == false)
        {
            featureSelectAllButtonTick.SetActive(true);

            for (int j = 0; j < featuresList.Length; j++)
            {
                featuresList[j].SetActive(true);
            }
            foreach (Transform t in subButtonsParent.transform)
            {
                t.GetChild(1).transform.GetChild(0).gameObject.SetActive(true);
            }
            isAllFeaturesSelected = true;
        }
        else
        {
            featureSelectAllButtonTick.SetActive(false);

            for (int j = 0; j < featuresList.Length; j++)
            {
                featuresList[j].SetActive(false);
            }

            foreach (Transform s in subButtonsParent.transform)
            {
                s.GetChild(1).transform.GetChild(0).gameObject.SetActive(false);

            }

            isAllFeaturesSelected = false;
        }
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

    public void selectAllLigaments()
    {
        if (isAllLigamentsSelected == false)
        {
            ligamentsSelectAllButtonTick.SetActive(true);

            for (int l = 0; l < ligamentsList.Length; l++)
            {
                ligamentsList[l].SetActive(true);
            }
            foreach (Transform t in ligamentsSubButtonsParent.transform)
            {
                t.GetChild(1).transform.GetChild(0).gameObject.SetActive(true);
            }
            isAllLigamentsSelected = true;
        }
        else
        {
            ligamentsSelectAllButtonTick.SetActive(false);

            for (int l = 0; l < ligamentsList.Length; l++)
            {
                ligamentsList[l].SetActive(false);
            }

            foreach (Transform t in ligamentsSubButtonsParent.transform)
            {
                t.GetChild(1).transform.GetChild(0).gameObject.SetActive(false);

            }

            isAllLigamentsSelected = false;
        }
    }

    public void onInsertionsButtonClick()
    {
        if (inserAttch == false)
        {

            insertionObj.SetActive(true);
            originObj.SetActive(false);
            DefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            insertion_dropdown.SetActive(true);

            insertionBtn.GetComponent<Image>().sprite = enable;

            inserAttch = true;
        }
        else
        {

            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
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
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            origin_dropdown.SetActive(true);

            originBtn.GetComponent<Image>().sprite = enable;

            origAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            origin_dropdown.SetActive(false);

            originBtn.GetComponent<Image>().sprite = disable;

            origAttach = false;
        }
    }

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(false);
            ligamentObj.SetActive(true);
            featuresObj.SetActive(false);
            ligaments_dropdown.SetActive(true);

            ligamentsBtn.GetComponent<Image>().sprite = enable;

            ligamentAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            ligaments_dropdown.SetActive(false);

            ligamentsBtn.GetComponent<Image>().sprite = disable;


            ligamentAttach = false;
        }
    }

    public void onFeaturesButtonClick()
    {
        if (featureAttach == false)
        {

            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(true);
            feature_dropdown.SetActive(true);

            featureBtn.GetComponent<Image>().sprite = enable;

            featureAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            feature_dropdown.SetActive(false);

            featureBtn.GetComponent<Image>().sprite = disable;

            featureAttach = false;
        }
    }
}
