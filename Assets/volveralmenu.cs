using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volveralmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnclickBotonjugar()
    {
        Debug.Log("Prueba3");
        MMSceneLoadingManager.LoadScene("MenuInicial");
    }
}
