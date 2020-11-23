using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CarpalGameManager : MonoBehaviour
{
    public GameObject zoneBObj;
    public GameObject CarpalinsertionObj, CarpaloriginObj, CarpalDefaultObj;

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

            CarpalinsertionObj.SetActive(true);
            CarpaloriginObj.SetActive(false);
            CarpalDefaultObj.SetActive(false);
         //   CarpalligamentObj.SetActive(false);



            inserAttch = true;
        }
        else
        {

            CarpalinsertionObj.SetActive(false);
            CarpaloriginObj.SetActive(false);
            CarpalDefaultObj.SetActive(true);
           // CarpalligamentObj.SetActive(false);

            inserAttch = false;
        }
    }

    public void onOriginButtonClick()
    {
        if (origAttach == false)
        {

            CarpalinsertionObj.SetActive(false);
            CarpaloriginObj.SetActive(true);
            CarpalDefaultObj.SetActive(false);
           // CarpalligamentObj.SetActive(false);
            origAttach = true;
        }
        else
        {


            CarpalinsertionObj.SetActive(false);
            CarpaloriginObj.SetActive(false);
            CarpalDefaultObj.SetActive(true);
           // CarpalligamentObj.SetActive(false);
            origAttach = false;
        }
    }

    public void onLigamentsButtonClick()
    {
        if (ligamentAttach == false)
        {

            CarpalinsertionObj.SetActive(false);
            CarpaloriginObj.SetActive(false);
            CarpalDefaultObj.SetActive(false);
          //  CarpalligamentObj.SetActive(true);
            ligamentAttach = true;
        }
        else
        {


            CarpalinsertionObj.SetActive(false);
            CarpaloriginObj.SetActive(false);
            CarpalDefaultObj.SetActive(true);
          //  CarpalligamentObj.SetActive(false);
            ligamentAttach = false;
        }
    }
}
