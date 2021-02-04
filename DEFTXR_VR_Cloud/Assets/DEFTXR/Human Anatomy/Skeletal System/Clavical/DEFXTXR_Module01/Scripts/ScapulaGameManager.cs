using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScapulaGameManager : MonoBehaviour
{

   // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;

    public GameObject insertionObj, originObj, clavDefaultObj, ligamentObj, featuresObj;

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
            
            insertionObj.SetActive(true);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            insertion_dropdown.SetActive(true);

            inserAttch = true;
        }
        else
        {
            
            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(true);
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
            clavDefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            origin_dropdown.SetActive(true);

            origAttach = true;
        }
        else
        {

          
            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(true);
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
            clavDefaultObj.SetActive(false);
            ligamentObj.SetActive(true);
            featuresObj.SetActive(false);
            ligaments_dropdown.SetActive(true);

            ligamentAttach = true;
        }
        else
        {

         
            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            ligaments_dropdown.SetActive(false);

            ligamentAttach = false;
        }
    }

    public void onfeatureButtonClick()
    {
        if (featureAttach == false)
        {

            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(false);
            ligamentObj.SetActive(true);
            featuresObj.SetActive(true);
            feature_dropdown.SetActive(true);
            featureAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            featuresObj.SetActive(false);
            feature_dropdown.SetActive(false);
            featureAttach = false;
        }
    }
}
