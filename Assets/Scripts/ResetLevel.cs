using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResetLevelFunction()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
