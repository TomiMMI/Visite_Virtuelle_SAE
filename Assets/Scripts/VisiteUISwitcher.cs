using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisiteUISwitcher : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private GameObject visiteUI;

    public void OpenPause()
    {
        pauseUI.SetActive(true);
        visiteUI.SetActive(false);
    }
    public void ClosePause()
    {
        pauseUI.SetActive(false);
        visiteUI.SetActive(true);
    }
}