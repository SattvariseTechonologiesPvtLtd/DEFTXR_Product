﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using TMPro;
using UnityEngine.UI;

public class FemurZoneBManager : MonoBehaviour
{
    // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;

    public GameObject insertionObj, originObj, femurDefaultObj, ligamentObj, featuresObj;

    public GameObject selectbtn;

    public bool attch, inserAttch, ligamentAttach, origAttach,featureAttach = false;

    public Sprite enable, disable;

    //public GameObject[] featuresList;

    //public bool isAllFeaturesSelected;
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

    public GameObject insertionBtn;
    public GameObject ligamentsBtn;
    public GameObject originBtn;
    public GameObject featureBtn;

    // Use this for initialization
    void Start()
    {
        //isAllFeaturesSelected = false;
        insertion_dropdown.SetActive(false);
        ligaments_dropdown.SetActive(false);
        origin_dropdown.SetActive(false);
        feature_dropdown.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onFeaturesSubButtonClick()
    {
       // featureSelectAllButtonTick.SetActive(false);
        //isAllFeaturesSelected = false;

        //foreach (int i in MultiSelectDropdown_Manager.Instance.selectedButtonIdList)
        //{
        //    for (int j = 0;  j < featuresList.Length; j++)
        //    {
        //        if (j == i){
        //            featuresList[j].SetActive(true);
        //        }
        //        else{
        //            featuresList[j].SetActive(false);
        //        }
        //    }
        //}
    }

   /* public void selectAllFeatures()
    {
        if (isAllFeaturesSelected == false){
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
        else {

            featureSelectAllButtonTick.SetActive(false);

            for (int j = 0; j < featuresList.Length; j++)
            {
                featuresList[j].SetActive(false);
            }

            foreach (Transform t in subButtonsParent.transform)
            {
                t.GetChild(1).transform.GetChild(0).gameObject.SetActive(false);

            }

            isAllFeaturesSelected = false;
        }
    }*/



    public void onInsertionButtonClick()
    {
        if (inserAttch == false)
        {

            insertionObj.SetActive(true);
            originObj.SetActive(false);
            femurDefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            insertion_dropdown.SetActive(true);

            inserAttch = true;
        }
        else
        {

            insertionObj.SetActive(false);
            originObj.SetActive(false);
            femurDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            insertion_dropdown.SetActive(false);

            
            inserAttch = false;
        }
    }

    public void onOriginButtonClick()
    {
        if (origAttach == false)
        {

            insertionObj.SetActive(false);
            originObj.SetActive(true);
            femurDefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            origin_dropdown.SetActive(true);

           
            origAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            femurDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            origin_dropdown.SetActive(false);


            origAttach = false;
        }
    }

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

            insertionObj.SetActive(false);
            originObj.SetActive(false);
            femurDefaultObj.SetActive(false);
            ligamentObj.SetActive(true);
            featuresObj.SetActive(false);
            ligaments_dropdown.SetActive(true);


            ligamentAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            femurDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            ligaments_dropdown.SetActive(false);

 

            ligamentAttach = false;
        }
    }

    public void onFeaturesButtonClick()
    {
        if (featureAttach == false)
        {
            
            insertionObj.SetActive(false);
            originObj.SetActive(false);
            femurDefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(true);
            feature_dropdown.SetActive(true);

            featureAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            femurDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
           feature_dropdown.SetActive(false);

            featureAttach = false;
        }
    }
}
