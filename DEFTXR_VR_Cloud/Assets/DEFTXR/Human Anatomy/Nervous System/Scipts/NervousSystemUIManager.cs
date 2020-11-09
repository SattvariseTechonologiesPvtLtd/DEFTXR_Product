using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;


public class NervousSystemUIManager : MonoBehaviour
{
    /// <summary>
    /// UI manager will handle all the UI operations
    /// Nervous System UI Manager  : Variable Declaration.                                 --- START ---
    /// </summary>




  
    

    //making class as a singleton so other scripts can have access to this script
    public static NervousSystemUIManager Instance;

    //MainMenuButtons
    [SerializeField]
    GameObject brainBtn, spinalBtn,brainSubBtns,spinalSubBtns;

 
    [SerializeField]
    GameObject cerebrumUI, cerebellumUI, diecenphalanUI, midbrainUI, ponsUI, MedOblUI;
    //Sprites to be replaced as per selection

    public Sprite btnSelected, btnDselected;

    




    /// <summary>
    /// Nervous System UI Manager : Variable Declaration.                                ----- END -----
    /// </summary>
    /// 

    void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        initialise_defaults();

    }

    private void initialise_defaults()
    {
        brainBtn.SetActive(true);
        spinalBtn.SetActive(true);




    }

    // Update is called once per frame
    void Update()
    {
       
      
      

    }


   
  


        public void onHomeButtonClick()
        {
            SceneManager.LoadSceneAsync("MainMenu");
        }

        public void brainSubMenuChanges(int count)
    {
       switch(count)
        {
            case 0:
                cerebrumUI.SetActive(true);
                cerebellumUI.SetActive(false);
                diecenphalanUI.SetActive(false);
                ponsUI.SetActive(false);
                midbrainUI.SetActive(false);                
                MedOblUI.SetActive(false);

               

                
                break;

            case 1:
                cerebrumUI.SetActive(false);
                cerebellumUI.SetActive(true);
                diecenphalanUI.SetActive(false);
                ponsUI.SetActive(false);
                midbrainUI.SetActive(false);
                MedOblUI.SetActive(false);

                

              
                break;

            case 2:
                cerebrumUI.SetActive(false);
                cerebellumUI.SetActive(false);
                diecenphalanUI.SetActive(true);
                ponsUI.SetActive(false);
                midbrainUI.SetActive(false);
                MedOblUI.SetActive(false);

          

               
                break;

            case 3:
                cerebrumUI.SetActive(false);
                cerebellumUI.SetActive(false);
                diecenphalanUI.SetActive(false);
                ponsUI.SetActive(true);
                midbrainUI.SetActive(false);
                MedOblUI.SetActive(false);

               

               
                break;

            case 4:
                cerebrumUI.SetActive(false);
                cerebellumUI.SetActive(false);
                diecenphalanUI.SetActive(false);
                ponsUI.SetActive(false);
                midbrainUI.SetActive(true);
                MedOblUI.SetActive(false);

                
                
                break;

            case 5:
                cerebrumUI.SetActive(false);
                cerebellumUI.SetActive(false);
                diecenphalanUI.SetActive(false);
                ponsUI.SetActive(false);
                midbrainUI.SetActive(false);
                MedOblUI.SetActive(true);

              

               
                break;
        }
        
        
     
    }

    public IEnumerator brainbtnClick()
        {

        brainSubBtns.SetActive(true);
        spinalSubBtns.SetActive(false);

        yield return null;

    }

        public IEnumerator spinalbtnClick()
        {
        brainSubBtns.SetActive(false);
        spinalSubBtns.SetActive(true);


        yield return null;

        }

 




   

    



}
