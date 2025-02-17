using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TogglePauseMenu : MonoBehaviour
{
    private LookMap inputActions;
    public User inputActionsParent;
    public Cinemachine.CinemachineVirtualCamera userCamera;
    [SerializeField] GameObject UICanvas;

    private void Start()
    {
        inputActions = inputActionsParent.GetInputActions();
        inputActions.PauseMap.Disable();
        inputActions.PauseMap.Unpause.performed += Unpause_performed;
        inputActions.ViewMap.Pause.performed += Pause_performed;
    }

    private void Pause_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Pause();
    }

    private void Unpause_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Unpause();
    }

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        inputActions.ViewMap.Disable();
        inputActions.PauseMap.Enable();
        userCamera.enabled = false;
        UICanvas.SetActive(true);
    }
    public void Unpause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        inputActions.ViewMap.Enable();
        inputActions.PauseMap.Disable();
        userCamera.enabled = true;
        UICanvas.SetActive(false);
    }
}
