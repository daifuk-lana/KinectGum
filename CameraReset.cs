using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {

    }
    public void OnClick()
    {
        //GameObject("MainCamera")を初期位置に変更
        GameObject.Find("MainCamera").transform.position = new Vector3(0f, 1.3f, 1.8f);
        GameObject.Find("MainCamera").transform.rotation = Quaternion.Euler(0, 180, 0);

    }
}