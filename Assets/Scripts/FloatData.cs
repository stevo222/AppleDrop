using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;
    
    public UnityEvent onZeroEvent;
    

    public void UpdateValue(float num)
    {
        value += num;
    }

    public void SetValue(float num)
    {
        value = num;
    }
    public void DisplayImage(Image img)
    {
        if (value <= 0)
        {
            onZeroEvent.Invoke();
        }
        else if (value >= 1)
        {
            value = 1;
        }

        img.fillAmount = value;
    }
    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
    
}
