using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Xml.Linq;

public class MenuManager : MonoBehaviour
{
    [SerializeField] TMP_InputField nameField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameField.lineLimit = 1;
    }

   
    
    // Method to clear up the input field when the user wants to write on it
    public void ClearInputField()
    {
        if (nameField.text == "Insert Name Here...")
        {
            nameField.text = "";
        }
    }

    public void RestablishText()
    {
        if(nameField.text == "")
        {
            nameField.text = "Insert Name Here...";
        }
    }

    public void SubmitText()
    {
        DataManager.Instance.playerName = nameField.text;
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    

}


