using UnityEngine;
using System.Collections;

public class NervousSystemSceneManager : MonoBehaviour
{
    [SerializeField]
    public GameObject ZoneA, ZoneB, ZoneC;


    // Zone A,B,C platforms 
    [SerializeField]
    public GameObject zoneAPlatform, zoneBPlatform, zoneCPlatform;
    public static NervousSystemSceneManager Instance;

    public int zoneBTouchId;

    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start()
    {
        ZoneA.SetActive(true);
        ZoneB.SetActive(false);
        ZoneC.SetActive(false);
        zoneAPlatform.SetActive(false);
        Debug.Log("called here");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
