using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Patella_GameManager : MonoBehaviour
{
    // public GameObject ZoneA, ZoneB, ZoneC;
    public GameObject zoneBObj;

    public GameObject insertionObj,  DefaultObj, ligamentObj;

    public bool attch, inserAttch, ligamentAttach = false;

    public Sprite enable, disable;

    public GameObject[] insertionsList;
    public GameObject[] ligamentsList;

    public bool isAllInsertionsSelected;
    public bool isAllLigamentsSelected;

    public GameObject ligaments_dropdown;
    public GameObject ligamentsSelectAllButtonTick;
    public GameObject ligamentsSubButtonsParent;

    public GameObject insertion_dropdown;
    public GameObject insertionsSelectAllButtonTick;
    public GameObject insertionsSubButtonsParent;

    public GameObject insertionBtn;
    public GameObject ligamentsBtn;

    // Use this for initialization
    void Start()
    {
        
        isAllInsertionsSelected = false;
        isAllLigamentsSelected = false;

        insertion_dropdown.SetActive(false);
        ligaments_dropdown.SetActive(false);
        
        
        insertionBtn.GetComponent<Image>().sprite = disable;
        ligamentsBtn.GetComponent<Image>().sprite = disable;

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
           
            DefaultObj.SetActive(false);
            ligamentObj.SetActive(false);
            
            insertion_dropdown.SetActive(true);
            insertionBtn.GetComponent<Image>().sprite = enable;
            inserAttch = true;
        }
        else
        {

            insertionObj.SetActive(false);
            
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            
            insertion_dropdown.SetActive(false);
            insertionBtn.GetComponent<Image>().sprite = disable;

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
            
            ligaments_dropdown.SetActive(true);
            ligamentsBtn.GetComponent<Image>().sprite = enable;

            ligamentAttach = true;
        }
        else
        {


            insertionObj.SetActive(false);
          
            DefaultObj.SetActive(true);
            ligamentObj.SetActive(false);
            
            ligaments_dropdown.SetActive(false);
            ligamentsBtn.GetComponent<Image>().sprite = disable;


            ligamentAttach = false;
        }
    }



}
