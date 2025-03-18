using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UITransitionManager : MonoBehaviour
{
    
    [SerializeField] private GameObject pageObjetCanvas;
    [SerializeField] private GameObject pageMenuPrincipalCanvas;
    [SerializeField] private GameObject pageCatalogueCanvas;
    [SerializeField] private GameObject conteneurObjet;
    [SerializeField] private TMP_Text titre;
    [SerializeField] private TMP_Text description;
    private GameObject actualObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GeneratePage(Object objet)
    {
        conteneurObjet.transform.eulerAngles = new Vector3(0,-90,0);
        if (actualObject != null)
        {
            Object.Destroy(actualObject);
        }
        actualObject = Object.Instantiate(objet.model, conteneurObjet.transform);
        actualObject.SetActive(true);
        titre.text = objet.nom;
        description.text = objet.description;
        pageObjetCanvas.SetActive(true);
        pageCatalogueCanvas.SetActive(false);

    }

    public void BackToCatalogue()
    {
        pageObjetCanvas.SetActive(false);
        pageCatalogueCanvas.SetActive(true);
    }
    public void LoadObjectsPage()
    {
        pageMenuPrincipalCanvas.SetActive(false);
        pageCatalogueCanvas.SetActive(true);
    }
    public void LoadMenuPage()
    {
        pageMenuPrincipalCanvas.SetActive(true);
        pageCatalogueCanvas.SetActive(false);
    }

    public void LoadVisite()
    {
        SceneManager.LoadScene(1);
    }
}
