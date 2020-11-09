// Created By : Ayodhyanandan Bhosale
// Project : DEFTXR 
// This script is resposible for the controlling the Zone A  flow.
//
//
//
//
//


using UnityEngine;
using System.Collections;

public class ZoneBManager : MonoBehaviour
{

    public static ZoneBManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    /// <summary>
    /// Introduction Zone A : Variable Declaration.                               ----- START -----
    /// </summary>



    //ZoneB Interactive object references
    [SerializeField]
    GameObject Cerebrum, Cerebellum, Diencephalon, Midbrain, Pons, MedulaOblongata;

    //Zone B Brain parts and complete brain;
    [SerializeField]
    GameObject brain_complete,brain_parts;

    [SerializeField]
    Material CerebrumMat, CerebellumMat, DiencephalonMat, MidbrainMat, PonsMat, MedulaOblongataMat;

    [SerializeField]
    Material transperentView;

    [SerializeField]
    GameObject touchAnim;

    [SerializeField]
    GameObject BrainAnim, TouchAnim;

    public bool isLastStep = false;


    /// <summary>
    /// Introduction Zone A : Variable Declaration.                                ----- END -----
    /// </summary>
    /// 



    // Start is called before the first frame update
    void Start()
    {
        initialise_DefaultData();


    }

    /// <summary>
    /// this methode will initialize all the variables to the default values
    /// </summary>
    void initialise_DefaultData()
    {
       
        NervousSystemSceneManager.Instance.zoneBPlatform.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
       


    }

    //Main Menu function calls
    public void onBrainButtonClick()
    {
        StartCoroutine(NervousSystemUIManager.Instance.brainbtnClick());
       
        NervousSystemUIManager.Instance.brainSubMenuChanges(6);

        BrainAnim.SetActive(true);
        brain_complete.SetActive(true);
        brain_parts.SetActive(false);
        TouchAnim.SetActive(false);
    }

    public void onSpinalCordButtonClick()
    {
        StartCoroutine(NervousSystemUIManager.Instance.spinalbtnClick());
       
        BrainAnim.SetActive(false);
        brain_complete.SetActive(false);
        brain_parts.SetActive(false);
        TouchAnim.SetActive(true);
    }
    //subemenu function calls
    public void onCerebrumButtonClick()
    {
        NervousSystemUIManager.Instance.brainSubMenuChanges(0);

        brainSubMenuMatChanges(0);
    }

    public void onCerebellumButtonClick()
    {
        NervousSystemUIManager.Instance.brainSubMenuChanges(1);

        brainSubMenuMatChanges(1);
    }
    public void onDiencephelanButtonClick()
    {
        NervousSystemUIManager.Instance.brainSubMenuChanges(2);

        brainSubMenuMatChanges(2);
    }

    public void onPonsButtonClick()
    {
        NervousSystemUIManager.Instance.brainSubMenuChanges(3);

        brainSubMenuMatChanges(3);
    }

    public void onMidbrainButtonClick()
    {
        NervousSystemUIManager.Instance.brainSubMenuChanges(4);

        brainSubMenuMatChanges(4);
    }

    public void onMedulaOblangatButtonClick()
    {
        NervousSystemUIManager.Instance.brainSubMenuChanges(5);

        brainSubMenuMatChanges(5);
    }
   

    public void brainSubMenuMatChanges(int count)
    {
        switch (count)
        {
            case 0:
                brain_parts.SetActive(true);
                brain_complete.SetActive(false);

                Cerebrum.GetComponent<Renderer>().material = CerebrumMat;
                Cerebellum.GetComponent<Renderer>().material = transperentView;
                Diencephalon.GetComponent<Renderer>().material = transperentView;
                Midbrain.GetComponent<Renderer>().material = transperentView;
                Pons.GetComponent<Renderer>().material = transperentView;
                MedulaOblongata.GetComponent<Renderer>().material = transperentView;
                break;

            case 1:

                brain_parts.SetActive(true);
                brain_complete.SetActive(false);


                Cerebrum.GetComponent<Renderer>().material = transperentView;
                Cerebellum.GetComponent<Renderer>().material = CerebellumMat;
                Diencephalon.GetComponent<Renderer>().material = transperentView;
                Midbrain.GetComponent<Renderer>().material = transperentView;
                Pons.GetComponent<Renderer>().material = transperentView;
                MedulaOblongata.GetComponent<Renderer>().material = transperentView;
                break;

            case 2:
                brain_parts.SetActive(true);
                brain_complete.SetActive(false);

                Cerebrum.GetComponent<Renderer>().material = transperentView;
                Cerebellum.GetComponent<Renderer>().material = transperentView;
                Diencephalon.GetComponent<Renderer>().material = DiencephalonMat;
                Midbrain.GetComponent<Renderer>().material = transperentView;
                Pons.GetComponent<Renderer>().material = transperentView;
                MedulaOblongata.GetComponent<Renderer>().material = transperentView;
                break;

            case 3:
                brain_parts.SetActive(true);
                brain_complete.SetActive(false);

                Cerebrum.GetComponent<Renderer>().material = transperentView;
                Cerebellum.GetComponent<Renderer>().material = transperentView;
                Diencephalon.GetComponent<Renderer>().material = transperentView;
                Midbrain.GetComponent<Renderer>().material = transperentView;
                Pons.GetComponent<Renderer>().material = PonsMat;
                MedulaOblongata.GetComponent<Renderer>().material = transperentView;
                break;

            case 4:

                brain_parts.SetActive(true);
                brain_complete.SetActive(false);

                Cerebrum.GetComponent<Renderer>().material = transperentView;
                Cerebellum.GetComponent<Renderer>().material = transperentView;
                Diencephalon.GetComponent<Renderer>().material = transperentView;
                Midbrain.GetComponent<Renderer>().material = MidbrainMat;
                Pons.GetComponent<Renderer>().material = transperentView;
                MedulaOblongata.GetComponent<Renderer>().material = transperentView;
                break;

            case 5:
                brain_parts.SetActive(true);
                brain_complete.SetActive(false);

                Cerebrum.GetComponent<Renderer>().material = transperentView;
                Cerebellum.GetComponent<Renderer>().material = transperentView;
                Diencephalon.GetComponent<Renderer>().material = transperentView;
                Midbrain.GetComponent<Renderer>().material = transperentView;
                Pons.GetComponent<Renderer>().material = transperentView;
                MedulaOblongata.GetComponent<Renderer>().material = MedulaOblongataMat;
                break;
            case 6:
                brain_complete.SetActive(true);
                brain_parts.SetActive(false);
              
                break;
        }



    }

    public void zoneBTouchInputAnim(int touchid)
    {
        switch (touchid)
        {
            case 0:
                touchAnim.GetComponent<Animator>().Play("Base Layer.ZoneB_touch_ArmRight_anim", 0, 0.25f);
                break;
            case 1:
                touchAnim.GetComponent<Animator>().Play("Base Layer.ZoneB_touch_ArmLeft_anim", 0, 0.25f);
                break;
            case 2:
                touchAnim.GetComponent<Animator>().Play("Base Layer.ZoneB_touch_LegLeft_anim", 0, 0.25f);
                break;
            case 3:
                touchAnim.GetComponent<Animator>().Play("Base Layer.ZoneB_touch_LegRight", 0, 0.25f);
                break;
        }
    

    }




}
