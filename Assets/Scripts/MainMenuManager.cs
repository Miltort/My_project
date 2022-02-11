using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager: MonoBehaviour
{

    [SerializeField] private Button StartButton;
    [SerializeField] private Button OpenCredits;
    [SerializeField] private Button CloseCredits;
    [SerializeField] private GameObject CreditsUI;

    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(() => LoadingScreen.LoadScene("Lab1"));
        OpenCredits.onClick.AddListener(() => CreditsUI.SetActive(true));
        CloseCredits.onClick.AddListener(() => CreditsUI.SetActive(false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
