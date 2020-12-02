using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sacrum_GameManager : MonoBehaviour
{
    public GameObject zoneBObj;
    public GameObject SacrumoriginObj, SacrumDefaultObj, SacrumligamentObj;

    public bool attch, ligamentAttach, origAttach = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   
    public void onOriginButtonClick()
    {
        if (origAttach == false)
        {

            
            SacrumoriginObj.SetActive(true);
            SacrumDefaultObj.SetActive(false);
            SacrumligamentObj.SetActive(false);
            origAttach = true;
        }
        else
        {


          
            SacrumoriginObj.SetActive(false);
            SacrumDefaultObj.SetActive(true);
            SacrumligamentObj.SetActive(false);
            origAttach = false;
        }
    }

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

       
            SacrumoriginObj.SetActive(false);
            SacrumDefaultObj.SetActive(false);
            SacrumligamentObj.SetActive(true);
            ligamentAttach = true;
        }
        else
        {


           
            SacrumoriginObj.SetActive(false);
            SacrumDefaultObj.SetActive(true);
            SacrumligamentObj.SetActive(false);
            ligamentAttach = false;
        }
    }
}
