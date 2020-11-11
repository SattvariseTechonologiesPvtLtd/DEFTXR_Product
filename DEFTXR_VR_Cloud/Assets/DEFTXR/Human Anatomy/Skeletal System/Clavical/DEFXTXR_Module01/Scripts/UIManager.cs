using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   
    public string selectedBtnName;
   

    public GameObject zoneAPlat, zoneBplat, zoneCplat;
    public static UIManager Instance;

    public GameObject clavicaleBone,scapulaBone,humerusBone,ulnaradiusBone,femurBone;
    
    // Sub-Menu reference to on off on click of buttn
    public GameObject upperLimbMenu, lowerLimbMenu, thoraxMenu, headneckbrainMenu,ComingSoonPanel;

   

   

    //Sprites to be replaced as per selection
    Sprite btnSelected, btnDselected;

    public GameObject mainUI;

    void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        clavicaleBone.SetActive(false);
        scapulaBone.SetActive(false);
      //  humerusBone.SetActive(false);
        femurBone.SetActive(false);
        mainUI.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
       // ShootLaserFromTargetPosition(rightHand.transform.position, rightHand.transform.forward, laserMaxLength);

        //Call and select the UI as per laser collision
        //selectUIButton();

    }

    /// <summary>
    /// Methode will match the button selected by laser
    /// </summary>
    /// 
    public void onUpperLimbButtonClick()
    {
        upperLimbMenu.SetActive(true);
        lowerLimbMenu.SetActive(false);
        thoraxMenu.SetActive(false);
        headneckbrainMenu.SetActive(false);
    }

    public void onLowerLimbButtonClick()
    {
        upperLimbMenu.SetActive(false);
        lowerLimbMenu.SetActive(true);
        thoraxMenu.SetActive(false);
        headneckbrainMenu.SetActive(false);
    }

    public void onThoraxButtonClick()
    {
        upperLimbMenu.SetActive(false);
        lowerLimbMenu.SetActive(false);
        thoraxMenu.SetActive(true);
        headneckbrainMenu.SetActive(false);
    }

    public void onHNBButtonClick()
    {
        upperLimbMenu.SetActive(false);
        lowerLimbMenu.SetActive(false);
        thoraxMenu.SetActive(false);
        headneckbrainMenu.SetActive(true);

    }

    public void onClavicleButtonClick()
    {
        clavicaleBone.SetActive(true);
        scapulaBone.SetActive(false);
        humerusBone.SetActive(false);
        femurBone.SetActive(false);
        ulnaradiusBone.SetActive(false);

        zoneAPlat.SetActive(true);
        //zoneBplat.SetActive(true);
        //zoneCplat.SetActive(true);

        mainUI.SetActive(false);
        ComingSoonPanel.SetActive(false);
    }

    public void onScapulaButtonClick()
    {
        clavicaleBone.SetActive(false);
        scapulaBone.SetActive(true);
        humerusBone.SetActive(false);
        femurBone.SetActive(false);
        ulnaradiusBone.SetActive(false);


        //zoneAPlat.SetActive(true);
        zoneBplat.SetActive(true);
       // zoneCplat.SetActive(true);
        mainUI.SetActive(false);
        ComingSoonPanel.SetActive(false);
    }
    public void onHumerusButtonClick()
    {
        clavicaleBone.SetActive(false);
        scapulaBone.SetActive(false);
        femurBone.SetActive(false);
        ulnaradiusBone.SetActive(false);
        humerusBone.SetActive(true);
        mainUI.SetActive(false);
        ComingSoonPanel.SetActive(false);
        //zoneAPlat.SetActive(true);
        zoneBplat.SetActive(true);
        // zoneCplat.SetActive(true);


    }
    public void onFemurButtonClick()
    {
        clavicaleBone.SetActive(false);
        scapulaBone.SetActive(false);
        femurBone.SetActive(true);
        ulnaradiusBone.SetActive(false);
        humerusBone.SetActive(false);

      //  zoneAPlat.SetActive(true);
        zoneBplat.SetActive(true);
     //   zoneCplat.SetActive(true);
        mainUI.SetActive(false);
        ComingSoonPanel.SetActive(false);


    }
    public void onUlnaRadiusButtonClick()
    {
        clavicaleBone.SetActive(false);
        scapulaBone.SetActive(false);
        femurBone.SetActive(false);
        ulnaradiusBone.SetActive(true);
        humerusBone.SetActive(false);
        mainUI.SetActive(false);
        ComingSoonPanel.SetActive(false);
        //zoneAPlat.SetActive(true);
        zoneBplat.SetActive(true);
        // zoneCplat.SetActive(true);
    }
    public void onCMPButtonClick()
    {
        clavicaleBone.SetActive(false);
        scapulaBone.SetActive(false);
        femurBone.SetActive(false);

        ComingSoonPanel.SetActive(true);

    }

    public void onOkayButtonClick()
    {
        ComingSoonPanel.SetActive(false);
    }

    public void onHomeButtonClick()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void onSkeletonSystemHomeButtonClick()
    {
        clavicaleBone.SetActive(false);
        scapulaBone.SetActive(false);
        femurBone.SetActive(false);
        humerusBone.SetActive(false);
        ulnaradiusBone.SetActive(false);

        mainUI.SetActive(true);
    }




}
