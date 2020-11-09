using UnityEngine;
using System.Collections;
using System.Threading.Tasks;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instace;
    public LineRenderer laserLineRenderer;
    public GameObject rightHand;
    public float laserWidth = 0.1f;
    public float laserMaxLength = 50f;
    public bool isGrabEnd = false;

    public int objectGrabCount;
    public Material clavical;

    public GameObject UIButtonsParent;

    private void Awake()
    {
        Instace = this;
    }

    public AudioClip[] tutorial_VO;
    public GameObject[] tutorial_Instructions;
    public AudioSource audioSource;
    public int tutorialStageCount = 0;
    float initialWaitTime;

    public bool camRaycastOn;
    public bool isRightGrabPressed, isLeftGrabPressed, isRightTriggerPressed, isLeftTriggerPressed;
    public int grabCount, triggerCount;

    public GameObject firstGrab,grab01,grab02,grab03;

    public GameObject leftController, rightController;

    public OVRGrabbable firstGrabbable,grab01Grabbable,grab02Grabbable,grab03Grabable,clavicalBone;
    public GameObject clavicalBoneObject;

    [SerializeField]
    private Camera OVRCam;

    [SerializeField]
    public GameObject rightStethoscope, leftSmily;
    public GameObject anchor01, anchore02;
    public GameObject sciFiTable;
    public GameObject leftGrab, rightGrab,leftTrigger,rightTrigger;

    public GameObject tooltipLeft, tooltipright, tooltipLeftGrab, tooltipLeftTrigger, tooltipRightGrab, tooltipRightTrigger;

    public bool isControllerOption,isUiInteraction;

    public GameObject button1, button2, button3,button4;
    public GameObject skeleton;
    public int grabbaleCount = 0, clavicalCount = 0;

    // Use this for initialization
    void Start()
    {
        resetTutorialParameters();
        startTutorial();
    }

     void resetTutorialParameters()
    {
        tutorialStageCount = 0;
        initialWaitTime = 3.0f;
        camRaycastOn = false;
        isUiInteraction = false;
       


        //Disable Gameobjects
        rightStethoscope.SetActive(false);
        leftSmily.SetActive(false);
        anchor01.SetActive(false);
        anchore02.SetActive(false);
        leftGrab.SetActive(false);
        rightGrab.SetActive(false);
        camRaycastOn = false;

        button1.SetActive(false);
        button2.SetActive(false);

        button4.SetActive(false);
        button3.SetActive(false);
        isControllerOption = false;
        skeleton.SetActive(false);

        tooltipright.SetActive(false);
        tooltipLeft.SetActive(false);
        tooltipLeftTrigger.SetActive(false);
        tooltipRightTrigger.SetActive(false);
        leftTrigger.SetActive(false);
        rightTrigger.SetActive(false);

        isRightTriggerPressed = false;
        isLeftTriggerPressed = false;


        tooltipright.SetActive(false);
        tooltipLeft.SetActive(false);
        tooltipLeftGrab.SetActive(false);
        tooltipRightGrab.SetActive(false);
        leftGrab.SetActive(false);
        rightGrab.SetActive(false);

        isLeftGrabPressed = false;
        isRightGrabPressed = false;

        rightStethoscope.SetActive(false);
        leftSmily.SetActive(false);
        sciFiTable.SetActive(false);
        anchor01.SetActive(false);
        anchore02.SetActive(false);
        UIButtonsParent.SetActive(false);
        grab01.SetActive(false);
        grab02.SetActive(false);
        grab03.SetActive(false);
    }

    async void startTutorial() {

        tutorialStageCount = 0;
        initialWaitTime = 3.0f;
        await WaitForTimeAsync(initialWaitTime);      
        playTutorialStage(tutorialStageCount);
    }



   public async void playTutorialStage(int current_stage)
    {

        switch (current_stage)
        {
            case 0:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 1:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage-1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);

                rightStethoscope.SetActive(true);
                camRaycastOn = true;

                tutorialStageCount++;              
                Debug.Log("VO ended");
                break;
            case 2:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                camRaycastOn = true;
                tutorialStageCount++;
                Debug.Log("VO ended");
                break;
            case 3:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                leftSmily.SetActive(false);
                rightStethoscope.SetActive(false);

                await WaitForTimeAsync(3f);
                tutorialStageCount++;

                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 4:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 5:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                anchor01.SetActive(true);
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 6:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
               
                Debug.Log("VO ended");
                break;
            case 7:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                anchore02.SetActive(true);
                tutorialStageCount++;
                Debug.Log("VO ended");
                break;
            case 8:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                sciFiTable.SetActive(true);
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
             
                Debug.Log("VO ended");
                break;
            case 9:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 10:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);

                isControllerOption = true;

                tooltipright.SetActive(true);
                tooltipLeft.SetActive(true);
                tooltipLeftTrigger.SetActive(true);
                tooltipRightTrigger.SetActive(true);
                leftTrigger.SetActive(true);
                rightTrigger.SetActive(true);

                isRightTriggerPressed = false;
                isLeftTriggerPressed = false;
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 11:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);               


                tutorialStageCount++;
                Debug.Log("VO ended");
                break;
            case 12:

               
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);

                tooltipright.SetActive(true);
                tooltipLeft.SetActive(true);
                tooltipLeftGrab.SetActive(true);
                tooltipRightGrab.SetActive(true);
                leftGrab.SetActive(true);
                rightGrab.SetActive(true);

                isLeftGrabPressed = false;
                isRightGrabPressed = false;

                tutorialStageCount++;
                Debug.Log("VO ended");
                break;
            case 13:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                firstGrab.SetActive(true);
                tutorialStageCount++;
              
                Debug.Log("VO ended");
                break;
            case 14:
            
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                Debug.Log("VO ended");
                break;
            case 15:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                button2.SetActive(true);
                button3.SetActive(true);
                tutorialStageCount++;

                Debug.Log("VO ended");
                break;
            case 16:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                isUiInteraction = false;
                UIButtonsParent.SetActive(false);

                grab01.SetActive(true);
                grab02.SetActive(true);
                grab03.SetActive(true);
                isUiInteraction = false;
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 17:
                await WaitForTimeAsync(20f);
                UIButtonsParent.SetActive(true);
                button4.SetActive(true);
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);

                grab01.SetActive(false);
                grab02.SetActive(false);
                grab03.SetActive(false);
                isUiInteraction = true;

                tutorialStageCount++;
                Debug.Log("VO ended");
                break;
            case 18:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
           
                Debug.Log("VO ended");
                break;
            case 19:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 20:
                await WaitForTimeAsync(5f);
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                playTutorialStage(tutorialStageCount);
                Debug.Log("VO ended");
                break;
            case 21:
                audioSource.PlayOneShot(tutorial_VO[current_stage]);
                tutorial_Instructions[current_stage - 1].SetActive(false);
                tutorial_Instructions[current_stage].SetActive(true);
                await WaitForTimeAsync(tutorial_VO[current_stage].length);
                tutorialStageCount++;
                Debug.Log("VO ended");
                break;
        }
    }




    void ShootLaserFromTargetPosition(Vector3 targetPosition, Vector3 direction, float length)
    {
        Ray ray = new Ray(targetPosition, direction);
        Vector3 endPosition = targetPosition + (length * direction);


        if (Physics.Raycast(ray, out RaycastHit raycastHit, length))
        {
            endPosition = raycastHit.point;
            // debug.text = ""+ raycastHit.transform.gameObject.name;

            string selectedBtn = raycastHit.transform.gameObject.name;

            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                if (string.Compare(selectedBtn, "ClickButton01") == 0)
                {
                    playTutorialStage(tutorialStageCount);
                    button1.SetActive(false);
                }
                if (string.Compare(selectedBtn, "ClickButton02") == 0 )
                {
                    button2.SetActive(false);
                 
                }
                if (string.Compare(selectedBtn, "ClickButton03") == 0)
                {
                    button3.SetActive(false);
                    playTutorialStage(tutorialStageCount);

                }
                if (string.Compare(selectedBtn, "HumanAnatomy") == 0)
                {
                    button4.SetActive(false);
                    sciFiTable.SetActive(false);
                    skeleton.SetActive(true);
                    isUiInteraction = false;
                    playTutorialStage(tutorialStageCount);

                }

            }
        }

        laserLineRenderer.SetPosition(0, targetPosition);
        laserLineRenderer.SetPosition(1, endPosition);
    }


    private void Update()
    {

        if (isUiInteraction == true)
        {
            ShootLaserFromTargetPosition(rightHand.transform.position, rightHand.transform.forward, laserMaxLength);
        }
        else
        {
            Vector3 none = new Vector3(0,0,0);
            laserLineRenderer.SetPosition(0, none);
            laserLineRenderer.SetPosition(1, none);
        }



        if (firstGrabbable.isGrabbed == true)
        {
            
            isGrabEnd = true;
        }

        if (clavicalBone.isGrabbed == true && clavicalCount == 0)
        {
            clavicalBoneObject.GetComponent<Renderer>().material = clavical;
            
            playTutorialStage(tutorialStageCount);
            clavicalCount++;
        }
    

        

        //Controller Actions


        if (isGrabEnd == true && grabbaleCount == 0)
        {
            if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
            {
                playTutorialStage(tutorialStageCount);
                isUiInteraction = true;
                firstGrab.SetActive(false);
                UIButtonsParent.SetActive(true);
                button1.SetActive(true);
                isGrabEnd = false;
                grabbaleCount++;
             }

         }
        if (isControllerOption == true)
        {


            if (grabCount < 2)
            {
                if (isRightGrabPressed == false)
                {
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
                    {

                        rightGrab.SetActive(false);
                        tooltipRightGrab.SetActive(false);
                        isRightGrabPressed = true;
                        grabCount++;
                    }
                }

                if (isLeftGrabPressed == false)
                {
                    if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
                    {
                        leftGrab.SetActive(false);
                        tooltipLeftGrab.SetActive(false);
                        isLeftGrabPressed = true;
                        grabCount++;
                    }
                }
            }

            if (triggerCount < 2)
            {

                if (isLeftTriggerPressed == false)
                {
                    if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                    {
                        leftTrigger.SetActive(false);
                        tooltipLeftTrigger.SetActive(false);
                        isLeftTriggerPressed = true;
                        triggerCount++;
                    }
                }

                if(isRightTriggerPressed == false)
                { 
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {
                        rightTrigger.SetActive(false);
                        tooltipRightTrigger.SetActive(false);
                        isRightTriggerPressed = true;
                        triggerCount++;
                    }

                }
            }
        }


        if (grabCount == 2)
        {
            playTutorialStage(tutorialStageCount);
            isControllerOption = false;
            leftController.SetActive(false);
            rightController.SetActive(false);
            grabCount++;
        }

        if (triggerCount == 2)
        {
            playTutorialStage(tutorialStageCount);
            triggerCount++;
        }

        // Camera Raycast for Step01
        if (camRaycastOn == true)
        {
            Debug.Log("started");
            RaycastHit hit;
            Ray rayToCameraPos = new Ray(transform.position, Camera.main.transform.forward);
            Vector3 dir = Camera.main.transform.forward;
            if (Physics.Raycast(OVRCam.transform.position, dir, out hit, 1000))
            {
                Debug.Log(hit.collider.name + ", " + hit.collider.tag);

                if (String.Compare(hit.collider.name, "Steathoscope") == 0)
                {
                    Debug.Log("right detected");
                    leftSmily.SetActive(true);
                    playTutorialStage(tutorialStageCount);
                    hit.collider.gameObject.GetComponent<Collider>().enabled = false;
                    camRaycastOn = false;
                }

                if (String.Compare(hit.collider.name, "Happyface") == 0)
                {
                    Debug.Log("right detected");
                    playTutorialStage(tutorialStageCount);
                    camRaycastOn = false;
                }
            }
        }
    }





    private async Task WaitForTimeAsync(float waitTime)
    {
        await Task.Delay(TimeSpan.FromSeconds(waitTime));
        Debug.Log("Finished waiting.");
    }
}
