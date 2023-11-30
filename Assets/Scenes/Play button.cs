using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playbutton : MonoBehaviour
{
    Button btn;
    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate { loadScene (Scene); });
    }
    void loadScene(Scene scene)
    {
        SceneManager.LoadScene(2);
    }

}
