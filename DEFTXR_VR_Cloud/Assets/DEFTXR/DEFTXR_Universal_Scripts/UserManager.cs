using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Security.Cryptography.X509Certificates;



public class UserManager : MonoBehaviour
{
   


    void Start()
    {
            StartCoroutine(Upload());
    }




    IEnumerator Upload()
    {
        Debug.Log("start");       

        WWWForm form = new WWWForm();
        form.AddField("email", "ayodhyanandan@gmail.com");
        form.AddField("password", "R@D8jqz9");
        form.headers.Add("Accept", "application/json");

        Debug.Log(""+form.data.ToString());
        UnityWebRequest www = UnityWebRequest.Post("https://creintechs.sg-host.com/public/api/login", form);

        www.certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();

        // Debug.Log(www.ToString());
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!"+www.downloadHandler.text);
        }
    }
}
class AcceptAllCertificatesSignedWithASpecificKeyPublicKey : CertificateHandler
{

    // Encoded RSAPublicKey
    private static string PUB_KEY = "mypublickey";
    protected override bool ValidateCertificate(byte[] certificateData)
    {
        X509Certificate2 certificate = new X509Certificate2(certificateData);
        string pk = certificate.GetPublicKeyString();
        if (pk.ToLower().Equals(PUB_KEY.ToLower()))
            return true;
        return true;
    }
}