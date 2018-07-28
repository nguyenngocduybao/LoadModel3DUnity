using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadAssetBundles : MonoBehaviour
{

    public InputField linkURL;
    private string objName;

    public void BtnLoad()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        WWW www = new WWW(linkURL.text);
        yield return www;

        if (www.error != null)
        {
            Debug.Log(www.error);
        }

        AssetBundle bundle = www.assetBundle;
        objName = linkURL.text.Substring(40);
        var obj = bundle.LoadAsset(objName);
        Instantiate(obj);
    }
}