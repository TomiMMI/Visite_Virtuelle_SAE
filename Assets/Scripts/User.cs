using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class User : MonoBehaviour
{
    private LookMap inputActions;
    public event EventHandler<onSelectChangeEventArgs> onSelectChange;

    public class onSelectChangeEventArgs : EventArgs
    {
        public Transform selection;
    }
    [SerializeField] private LayerMask layer;
    private Transform lastSelected = null;

    private void Awake()
    {
        inputActions = new LookMap();
        inputActions.Enable();
        inputActions.ViewMap.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if(lastSelected != null)
        {
            lastSelected.GetComponent<LightSelected>().enabled = false;
            lastSelected.GetComponent<SphereTransition>().Transit();
            lastSelected = null;
        }
        else
        {
            Touch touch = Input.GetTouch(0);
            var ray = Camera.main.ScreenPointToRay(touch.position);

            RaycastHit hit = new RaycastHit();

            if(Physics.Raycast(ray, out hit, layer))
            {
                hit.collider.gameObject.GetComponent<SphereTransition>().Transit();
                lastSelected.GetComponent<LightSelected>().enabled = false;
                lastSelected = null;
            }
        }
    }

    private void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out RaycastHit raycast, layer);
        if(raycast.transform != lastSelected)
        {
            lastSelected = raycast.transform;
            onSelectChange?.Invoke(this, new onSelectChangeEventArgs
            {
                selection = lastSelected
            });
        }
    }
    private void Pause()
    {
        inputActions.ViewMap.Disable();
        inputActions.PauseMap.Enable();

    }
    public LookMap GetInputActions()
    {
        return inputActions;
    }
}
