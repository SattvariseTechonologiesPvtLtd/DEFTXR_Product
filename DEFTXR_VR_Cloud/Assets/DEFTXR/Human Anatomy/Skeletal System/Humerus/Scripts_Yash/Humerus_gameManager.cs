using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Humerus_gameManager : MonoBehaviour
{
 
    public GameObject zoneBObj;
    public GameObject HumerusinsertionObj, HumerusoriginObj, HumerusDefaultObj, HumerusligamentObj;    

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

            HumerusinsertionObj.SetActive(true);
            HumerusoriginObj.SetActive(false);
            HumerusDefaultObj.SetActive(false);
            HumerusligamentObj.SetActive(false);



            inserAttch = true;
        }
        else
        {

            HumerusinsertionObj.SetActive(false);
            HumerusoriginObj.SetActive(false);
            HumerusDefaultObj.SetActive(true);
            HumerusligamentObj.SetActive(false);

            inserAttch = false;
        }
    }

    public void onOriginButtonClick()
    {
        if (origAttach == false)
        {

            HumerusinsertionObj.SetActive(false);
            HumerusoriginObj.SetActive(true);
            HumerusDefaultObj.SetActive(false);
            HumerusligamentObj.SetActive(false);
            origAttach = true;
        }
        else
        {


            HumerusinsertionObj.SetActive(false);
            HumerusoriginObj.SetActive(false);
            HumerusDefaultObj.SetActive(true);
            HumerusligamentObj.SetActive(false);
            origAttach = false;
        }
    }

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

            HumerusinsertionObj.SetActive(false);
            HumerusoriginObj.SetActive(false);
            HumerusDefaultObj.SetActive(false);
            HumerusligamentObj.SetActive(true);
            ligamentAttach = true;
        }
        else
        {


            HumerusinsertionObj.SetActive(false);
            HumerusoriginObj.SetActive(false);
            HumerusDefaultObj.SetActive(true);
            HumerusligamentObj.SetActive(false);
            ligamentAttach = false;
        }
    }
}
