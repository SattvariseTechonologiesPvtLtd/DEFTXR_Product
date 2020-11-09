// Created By : Ayodhyanandan Bhosale
// Project : DEFTXR 
// This script is resposible for the controlling the Zone C  flow.
//
//
//
//
//
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZoneCManager : MonoBehaviour
{
    /// <summary>
    /// Introduction Zone C : Variable Declaration.                               ----- START -----
    /// </summary>

    //Steps references to display animation Introduction.
    [SerializeField]
    private GameObject ZoneC_Brain_AnimationParent, ZoneC_SpinalCord_AnimationParent,ZoneC_ANS_AnimationParent;

    public bool isClickedStart, isClickEnd = false;
    //UI references to display animation information.
   

    // list of the audioclips required
    [SerializeField]
    private List<AudioClip> brainVO,spinalVO,ANSVO,SNSVO;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private List<GameObject> brainSubT, spinalSubT, ANSSubT, SNSSubT;

    public GameObject brainSubs, spineSubs, ANSSubs, SNSSubs;

    /// <summary>
    /// Introduction Zone A : Variable Declaration.                                ----- END -----
    /// </summary>
    /// 


    // Use this for initialization

    void Start()
    {
        initialise_DefaultData();
        isClickedStart = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void initialise_DefaultData()
    {
        NervousSystemSceneManager.Instance.zoneCPlatform.SetActive(true);
    }



    public void onBrainButtonClick()
    {
        audioSource.Stop();
        StopAllCoroutines();
        resetZoneCAnimaiton();
        StartCoroutine(zoneC_Brain());
    }

    public void onSpinalCordButtonClick()
    {
        audioSource.Stop();
        StopAllCoroutines();
        resetZoneCAnimaiton();
        StartCoroutine(zoneC_SpinalCord());
    }

    public void onAutonomicButtonClick()
    {
        audioSource.Stop();
        StopAllCoroutines();
        resetZoneCAnimaiton();
        StartCoroutine(zoneC_ANS());
    }

    public void onSomaticButtonClick()
    {
        audioSource.Stop();
        StopAllCoroutines();
        resetZoneCAnimaiton();
        StartCoroutine(zoneC_SNS());
    }


    void resetZoneCAnimaiton()
    {
        ZoneC_Brain_AnimationParent.SetActive(false);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 0);

        ZoneC_SpinalCord_AnimationParent.SetActive(false);
        ZoneC_SpinalCord_AnimationParent.GetComponent<Animator>().enabled = false;

        ZoneC_ANS_AnimationParent.SetActive(false);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 0);

        brainSubs.SetActive(false);
        spineSubs.SetActive(false);
        SNSSubs.SetActive(false);
        ANSSubs.SetActive(false);


    }

    IEnumerator zoneC_Brain()
    {

        brainSubs.SetActive(true);
    

        //VO01
        yield return new WaitForSeconds(2f);
        audioSource.PlayOneShot(brainVO[0]);
        brainSubT[0].SetActive(true);
        yield return new WaitForSeconds(4f);
        ZoneC_Brain_AnimationParent.SetActive(true);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 1);
        yield return new WaitForSeconds(8f);
     
        //VO02
        yield return new WaitForSeconds(2f);
        brainSubT[0].SetActive(false);
        brainSubT[1].SetActive(true);
        audioSource.PlayOneShot(brainVO[1]);      
        yield return new WaitForSeconds(2f);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 2);
        yield return new WaitForSeconds(6f);

        //VO03
        yield return new WaitForSeconds(2f);
        brainSubT[1].SetActive(false);
        brainSubT[2].SetActive(true);
        audioSource.PlayOneShot(brainVO[2]);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 3);
        yield return new WaitForSeconds(brainVO[2].length);

        //VO04
        yield return new WaitForSeconds(2f);
        brainSubT[2].SetActive(false);
        brainSubT[3].SetActive(true);
        audioSource.PlayOneShot(brainVO[3]);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 4);
        yield return new WaitForSeconds(brainVO[3].length);

        //VO05
        yield return new WaitForSeconds(2f);
        brainSubT[3].SetActive(false);
        brainSubT[4].SetActive(true);
        audioSource.PlayOneShot(brainVO[4]);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 5);
        yield return new WaitForSeconds(brainVO[4].length);

        //VO06
        yield return new WaitForSeconds(2f);
        brainSubT[4].SetActive(false);
        brainSubT[5].SetActive(true);
        audioSource.PlayOneShot(brainVO[5]);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 6);
        yield return new WaitForSeconds(brainVO[5].length);

        //VO07
        yield return new WaitForSeconds(2f);
        brainSubT[5].SetActive(false);
        brainSubT[6].SetActive(true);
        audioSource.PlayOneShot(brainVO[6]);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 7);
        yield return new WaitForSeconds(brainVO[6].length);

        //VO08
        yield return new WaitForSeconds(2f);
        brainSubT[6].SetActive(false);
        brainSubT[7].SetActive(true);
        audioSource.PlayOneShot(brainVO[7]);
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepBrain", 8);
        yield return new WaitForSeconds(brainVO[7].length);
        brainSubT[7].SetActive(false);
        
        ZoneC_Brain_AnimationParent.GetComponent<Animator>().StopPlayback();
       
        isClickedStart = false;
    }


    IEnumerator zoneC_SpinalCord()
    {

        spineSubs.SetActive(true);

        //VO01
        yield return new WaitForSeconds(2f);
        audioSource.PlayOneShot(spinalVO[0]);
        spinalSubT[0].SetActive(true);
        ZoneC_SpinalCord_AnimationParent.SetActive(true);
        ZoneC_SpinalCord_AnimationParent.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(spinalVO[0].length);

        //VO02
        spinalSubT[0].SetActive(false);
        spinalSubT[1].SetActive(true);
        audioSource.PlayOneShot(spinalVO[1]);
        yield return new WaitForSeconds(spinalVO[1].length);
        spinalSubT[1].SetActive(false);
       
        isClickedStart = false;

    }

    IEnumerator zoneC_ANS()
    {
        ANSSubs.SetActive(true);
        //VO01
        yield return new WaitForSeconds(2f);
        audioSource.PlayOneShot(ANSVO[0]);
        ANSSubT[0].SetActive(true); 
        yield return new WaitForSeconds(ANSVO[0].length);

        //VO02
        ANSSubT[0].SetActive(false);
        ANSSubT[1].SetActive(true);
        audioSource.PlayOneShot(ANSVO[1]);
        ZoneC_ANS_AnimationParent.SetActive(true);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 1);
        yield return new WaitForSeconds(15f);
        ANSSubT[1].SetActive(false);
        ANSSubT[2].SetActive(true);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 2);
        yield return new WaitForSeconds(17);

        ANSSubT[2].SetActive(false);
        ANSSubT[3].SetActive(true);
        audioSource.PlayOneShot(ANSVO[2]);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 3);
        yield return new WaitForSeconds(ANSVO[2].length);

        ANSSubT[3].SetActive(false);
        ANSSubT[4].SetActive(true);
        audioSource.PlayOneShot(ANSVO[3]);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 4);
        yield return new WaitForSeconds(ANSVO[3].length);

        ANSSubT[4].SetActive(false);
        ANSSubT[5].SetActive(true);
        audioSource.PlayOneShot(ANSVO[4]);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 5);
        yield return new WaitForSeconds(ANSVO[4].length);


        ANSSubT[5].SetActive(false);
        ANSSubT[6].SetActive(true);
        audioSource.PlayOneShot(ANSVO[5]);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 6);
        yield return new WaitForSeconds(ANSVO[5].length);

        ANSSubT[6].SetActive(false);
        ANSSubT[7].SetActive(true);
        audioSource.PlayOneShot(ANSVO[6]);
        
        yield return new WaitForSeconds(ANSVO[6].length);

        ANSSubT[7].SetActive(false);
        ANSSubT[8].SetActive(true);
        audioSource.PlayOneShot(ANSVO[7]);
        ZoneC_ANS_AnimationParent.GetComponent<Animator>().SetInteger("zoncstepANS", 7);
        yield return new WaitForSeconds(ANSVO[7].length);

        ANSSubT[8].SetActive(false);
        ANSSubT[9].SetActive(true);
        audioSource.PlayOneShot(ANSVO[8]);
        
        yield return new WaitForSeconds(ANSVO[8].length);
        ANSSubT[9].SetActive(false);
        ZoneC_ANS_AnimationParent.SetActive(false);
     
        isClickedStart = false;
    }



    IEnumerator zoneC_SNS()
    {
        SNSSubs.SetActive(true);

        //VO01
        yield return new WaitForSeconds(2f);
        audioSource.PlayOneShot(SNSVO[0]);
        SNSSubT[0].SetActive(true);
        yield return new WaitForSeconds(SNSVO[0].length);
        yield return new WaitForSeconds(1f);

        audioSource.PlayOneShot(SNSVO[1]);       
        yield return new WaitForSeconds(SNSVO[1].length);
        yield return new WaitForSeconds(1f);

        audioSource.PlayOneShot(SNSVO[2]);
        yield return new WaitForSeconds(SNSVO[2].length);
        yield return new WaitForSeconds(1f);

        audioSource.PlayOneShot(SNSVO[3]);
        yield return new WaitForSeconds(SNSVO[3].length);
        yield return new WaitForSeconds(1f);

        audioSource.PlayOneShot(SNSVO[4]);
        yield return new WaitForSeconds(SNSVO[4].length);
        yield return new WaitForSeconds(1f);

        audioSource.PlayOneShot(SNSVO[5]);
        yield return new WaitForSeconds(SNSVO[5].length);
        yield return new WaitForSeconds(1f);

        SNSSubT[0].SetActive(false);
      
        isClickedStart = false;
    }
}
