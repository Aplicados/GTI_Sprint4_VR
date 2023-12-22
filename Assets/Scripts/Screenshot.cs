using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            string currentTime = DateTime.Now.ToString("MM-dd-yy (HH-mm-ss)");
            ScreenCapture.CaptureScreenshot("screenshot" + currentTime + ".png", 4);
        }

    }
}
