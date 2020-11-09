using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScapulaGameManager : MonoBehaviour
{

   // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;

    public GameObject insertionObj, originObj, clavDefaultObj, ligamentObj;

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
            
            insertionObj.SetActive(true);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(false);
            ligamentObj.SetActive(false);



            inserAttch = true;
        }
        else
        {
            
            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);

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
            origAttach = true;
        }
        else
        {

          
            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
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
            ligamentAttach = true;
        }
        else
        {

         
            insertionObj.SetActive(false);
            originObj.SetActive(false);
            clavDefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            ligamentAttach = false;
        }
    }

 
}
