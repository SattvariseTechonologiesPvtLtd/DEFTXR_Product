// Created By : Ayodhyanandan Bhosale
// Project : DEFTXR 
// This script is resposible for the controlling the Zone A  flow.
//
//
//
//
//

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ZoneAGameManager : MonoBehaviour
{
    /// <summary>
    /// Introduction Zone A : Variable Declaration.                               ----- START -----
    /// </summary>

    //Steps references to display animation Introduction.
    [SerializeField]
    private GameObject step01, step02, step03, step04;

    //UI references to display animation information.
    [SerializeField]
    private GameObject intro_VO03, intro_VO05, intro_VO07, intro_VO09,title;

    // list of the audioclips required
    [SerializeField]
    private List<AudioClip> intro_VO;

    

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private OVRGrabbable cubeGrab;

    [SerializeField]
    private GameObject grabingObjParent,grabObjtemp,grabOjbOrg;

    [SerializeField]
    private GameObject nervousSystem, startUi,questionUi;

    [SerializeField]
    private GameObject instr01, instr02, instr03, instr04, instr05;

    public bool isLastStep = false;


    /// <summary>
    /// Introduction Zone A : Variable Declaration.                                ----- END -----
    /// </summary>
    /// 

    

    // Start is called before the first frame update
    void Start()
    {
        initialise_DefaultData();
        StartCoroutine(introduction());
        
    }

    /// <summary>
    /// this methode will initialize all the variables to the default values
    /// </summary>
    void initialise_DefaultData()
    {
       
        // Disable all the platforms
      

        //Disable all the UI Instructions
        title.SetActive(false);
        intro_VO03.SetActive(false);
        intro_VO05.SetActive(false);
        intro_VO07.SetActive(false);
        intro_VO09.SetActive(false);

        //Disable all the Steps
        step01.SetActive(false);
        step02.SetActive(false);
        step03.SetActive(false);
        step04.SetActive(false);

        // Disable all the instruction
        instr01.SetActive(false);
        instr02.SetActive(false);
        instr03.SetActive(false);
        instr04.SetActive(false);
        instr05.SetActive(false);

        nervousSystem.SetActive(false);
        startUi.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (cubeGrab.isGrabbed == true && isLastStep == false)
        {
            
            StartCoroutine(lastStep());
            isLastStep = true;
            
        }

    }



    IEnumerator introduction()
    {
        // activate the required component
      
        yield return new WaitForSeconds(5f);
        
      
        
       
        startUi.SetActive(true);
        audioSource.PlayOneShot(intro_VO[0]);
        yield return new WaitForSeconds(intro_VO[0].length);

        yield return new WaitForSeconds(2f);
        questionUi.SetActive(false);

        // First instruction 
        instr01.SetActive(true);
        startUi.SetActive(false);
        title.SetActive(true);
        nervousSystem.SetActive(true);
        audioSource.PlayOneShot(intro_VO[1]);
        yield return new WaitForSeconds(intro_VO[1].length);
        title.SetActive(false);
        yield return new WaitForSeconds(2f);

        intro_VO03.SetActive(true);
        step01.SetActive(true);
        audioSource.PlayOneShot(intro_VO[2]);
        yield return new WaitForSeconds(intro_VO[2].length);

        yield return new WaitForSeconds(2f);
        intro_VO03.SetActive(false);
        step01.SetActive(false);
        grabingObjParent.SetActive(true);
        grabObjtemp.SetActive(true);
        grabOjbOrg.SetActive(false);

        instr01.SetActive(false);

        // Second instruction 
        instr02.SetActive(true);
        audioSource.PlayOneShot(intro_VO[3]);
        yield return new WaitForSeconds(intro_VO[3].length);

        yield return new WaitForSeconds(2f);

        intro_VO05.SetActive(true);
        step02.SetActive(true);
        audioSource.PlayOneShot(intro_VO[4]);
        yield return new WaitForSeconds(intro_VO[4].length);

       
        yield return new WaitForSeconds(2f);
        intro_VO05.SetActive(false);
        step02.SetActive(false);
        instr02.SetActive(false);
        // Third instruction 
        instr03.SetActive(true);
        audioSource.PlayOneShot(intro_VO[5]);
        yield return new WaitForSeconds(intro_VO[5].length);
        grabObjtemp.SetActive(false);

        grabOjbOrg.SetActive(true);
        

    }

    IEnumerator lastStep()
    {
       

        yield return new WaitForSeconds(2f);

        intro_VO07.SetActive(true);
        step03.SetActive(true);
        audioSource.PlayOneShot(intro_VO[6]);
        yield return new WaitForSeconds(intro_VO[6].length);

        yield return new WaitForSeconds(2f);
        intro_VO07.SetActive(false);
        step03.SetActive(false);
        instr03.SetActive(false);

        // Fourth instruction 
        instr04.SetActive(true);

        audioSource.PlayOneShot(intro_VO[7]);
        yield return new WaitForSeconds(intro_VO[7].length);

        yield return new WaitForSeconds(2f);

        intro_VO09.SetActive(true);
        step04.SetActive(true);
        audioSource.PlayOneShot(intro_VO[8]);
        yield return new WaitForSeconds(intro_VO[8].length);

        yield return new WaitForSeconds(2f);
        intro_VO09.SetActive(false);
        step04.SetActive(false);

        yield return new WaitForSeconds(5f);
        grabingObjParent.SetActive(false);
        grabObjtemp.SetActive(false);
        grabOjbOrg.SetActive(false);
        instr04.SetActive(true);

        audioSource.PlayOneShot(intro_VO[9]);
        yield return new WaitForSeconds(intro_VO[9].length);

        NervousSystemSceneManager.Instance.ZoneB.SetActive(true);
        NervousSystemSceneManager.Instance.ZoneC.SetActive(true);
        NervousSystemSceneManager.Instance.ZoneA.SetActive(false);
        
    }

}
