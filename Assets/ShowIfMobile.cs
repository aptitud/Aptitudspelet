using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowIfMobile : MonoBehaviour
{
    void Start()
    {
        var isMobile = Application.platform == RuntimePlatform.IPhonePlayer ||
                       Application.platform == RuntimePlatform.Android;

        gameObject.SetActive(isMobile);
    }
}
