using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_2017_1_OR_NEWER
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    public static MenuHandler Instance;
    public TMP_InputField inputField;
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_2017_1_OR_NEWER
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
