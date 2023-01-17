using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start and Update Methods deleted 
    public static MainManager Instance;
    public Color TeamColor;

    private void Awake()
    { if(Instance != null)
    {
        Destroy(gameObject);
    }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    

}
