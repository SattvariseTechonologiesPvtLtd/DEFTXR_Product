using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Patella_GameManager : MonoBehaviour
{
    // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;

    public GameObject insertionObj,  DefaultObj, ligamentObj;

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
     
            DefaultObj.SetActive(false);
            ligamentObj.SetActive(false);



            inserAttch = true;
        }
        else
        {

            insertionObj.SetActive(false);
          
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);

            inserAttch = false;
        }
    }

   

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

            insertionObj.SetActive(false);
          
            DefaultObj.SetActive(false);
            ligamentObj.SetActive(true);
            ligamentAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
          
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            ligamentAttach = false;
        }
    }



}
