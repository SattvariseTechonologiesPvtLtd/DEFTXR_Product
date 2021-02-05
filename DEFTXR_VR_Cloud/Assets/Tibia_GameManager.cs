﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tibia_GameManager : MonoBehaviour
{

    public GameObject zoneBObj;
    public GameObject TibiainsertionObj, TibiaoriginObj, TibiaDefaultObj, TibialigamentObj, TibiafeatureObj;

    public bool attch, inserAttch, ligamentAttach, origAttach, featureAttach = false;

    public GameObject feature_dropdown;
    public GameObject featureSelectAllButtonTick;
    public GameObject subButtonsParent;

    public GameObject ligaments_dropdown;
    public GameObject ligamentSelectAllButtonTick;
    public GameObject ligamentsubButtonsParent;

    public GameObject origin_dropdown;
    public GameObject originSelectAllButtonTick;
    public GameObject originsubButtonsParent;

    public GameObject insertion_dropdown;
    public GameObject insertionSelectAllButtonTick;
    public GameObject insertionsubButtonsParent;

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

            TibiainsertionObj.SetActive(true);
            TibiaoriginObj.SetActive(false);
            TibiaDefaultObj.SetActive(false);
            TibialigamentObj.SetActive(false);



            inserAttch = true;
        }
        else
        {

            TibiainsertionObj.SetActive(false);
            TibiaoriginObj.SetActive(false);
            TibiaDefaultObj.SetActive(true);
            TibialigamentObj.SetActive(false);

            inserAttch = false;
        }
    }

    public void onOriginButtonClick()
    {
        if (origAttach == false)
        {

            TibiainsertionObj.SetActive(false);
            TibiaoriginObj.SetActive(true);
            TibiaDefaultObj.SetActive(false);
            TibialigamentObj.SetActive(false);
            origAttach = true;
        }
        else
        {


            TibiainsertionObj.SetActive(false);
            TibiaoriginObj.SetActive(false);
            TibiaDefaultObj.SetActive(true);
            TibialigamentObj.SetActive(false);
            origAttach = false;
        }
    }

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

            TibiainsertionObj.SetActive(false);
            TibiaoriginObj.SetActive(false);
            TibiaDefaultObj.SetActive(false);
            TibialigamentObj.SetActive(true);
            ligamentAttach = true;
        }
        else
        {


            TibiainsertionObj.SetActive(false);
            TibiaoriginObj.SetActive(false);
            TibiaDefaultObj.SetActive(true);
            TibialigamentObj.SetActive(false);
            ligamentAttach = false;
        }
    }

    public void onFeaturesButtonClick()
    {
        if (featureAttach == false)
        {

            TibiainsertionObj.SetActive(false);
            TibiaoriginObj.SetActive(false);
            TibiaDefaultObj.SetActive(false);
            TibiaDefaultObj.SetActive(false);
            TibiafeatureObj.SetActive(true);
            feature_dropdown.SetActive(true);

            featureAttach = true;
        }
        else
        {


            TibiainsertionObj.SetActive(false);
            TibiaoriginObj.SetActive(false);
            TibiaDefaultObj.SetActive(true);
            TibialigamentObj.SetActive(false);
            TibiafeatureObj.SetActive(false);
            feature_dropdown.SetActive(false);

            featureAttach = false;
        }
    }
}
