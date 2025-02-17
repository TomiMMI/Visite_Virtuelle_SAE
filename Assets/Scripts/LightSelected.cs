using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSelected : MonoBehaviour
{
    [SerializeField]private GameObject lightVisual;
    private User parentSelector;
    void Start()
    {
        parentSelector = Camera.main.GetComponent<User>();
        parentSelector.onSelectChange += ParentSelector_onSelectChange;

    }

    private void ParentSelector_onSelectChange(object sender, User.onSelectChangeEventArgs e)
    {

        if (e.selection != null && e.selection == this.transform)
        {
            lightVisual.SetActive(true);
        }
        else
        {
            lightVisual.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        parentSelector.onSelectChange -= ParentSelector_onSelectChange;
    }
}
