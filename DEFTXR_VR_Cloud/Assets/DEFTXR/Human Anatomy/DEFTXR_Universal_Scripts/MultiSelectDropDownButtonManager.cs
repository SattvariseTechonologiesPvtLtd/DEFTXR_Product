using UnityEngine;
using System.Collections;

public class MultiSelectDropDownButtonManager : MonoBehaviour
{

    [SerializeField]
    private GameObject myButtonTick;

    [SerializeField]
    private GameObject myReferenceObject;

    [SerializeField]
    private int myButtonId;

    bool isTickMarked;

    
    // Use this for initialization
    void Start()
    {
        isTickMarked = false;
        myButtonTick.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void tickMarkToggle()
    {
        if (isTickMarked == false){

            myButtonTick.SetActive(true);
            myReferenceObject.SetActive(true);
            isTickMarked = true;

            MultiSelectDropdown_Manager.Instance.selectedButtonIdList.Add(myButtonId);
            MultiSelectDropdown_Manager.Instance.onDropDownButtonSelection();
        }
        else {
            myButtonTick.SetActive(false);
            myReferenceObject.SetActive(false);
            isTickMarked = false;

            MultiSelectDropdown_Manager.Instance.selectedButtonIdList.Remove(myButtonId);
            MultiSelectDropdown_Manager.Instance.onDropDownButtonSelection();

        }

    }
}
