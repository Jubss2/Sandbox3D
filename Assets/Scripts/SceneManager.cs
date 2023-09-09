using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public Text valueT;
    private void Start()
    {
        valueT.text = ButtonPress.Instance.value.ToString();
        for (int i = 0; i < 10; i++)
        {
            ButtonPress.Instance.value++;
        }
    }
}
