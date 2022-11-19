using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameInputField;
    private bool nameCorrect = false;
    private string m_NameInput;
    public string nameInput
    {
        get { return m_NameInput; } // Encapsulation
        set
        {
            if (value.Length > 8)
            {
                Debug.Log("Too long of a Name");
            }
            else if (value.Length > 0)
            {
                m_NameInput = value;
                nameCorrect = true;
            }
        }
    }

    public void StartButtonPressed()
    {
        nameInput = nameInputField.text;

        if (nameCorrect)
        {
            SceneManager.LoadScene(1);
        }
 
    }
}
