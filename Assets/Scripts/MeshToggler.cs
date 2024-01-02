using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    [SerializeField] private GameObject turbineObject;
    private bool isActive = true;

    public void Toggle()
    {
        if (isActive)
        {
            turbineObject.SetActive(false);
            isActive = false;
        }
        else
        {
            turbineObject.SetActive(true);
            isActive = true;
        }
    }

}
