using System.Collections;
using System.Collections.Generic;
using UnityEngine;////
/// <summary>
/// /;/////////////////////////////
/// </summary>
public class  ButtonPress : MonoBehaviour
{
    // Start is called before the first frame update
    public static ButtonPress Instance { get; private set; }

    public int value;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        DontDestroyOnLoad(Instance);
    }
}
