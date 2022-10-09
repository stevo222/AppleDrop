
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
   // public UnityEvent disableEvent;
   

    public void SetValue(int number)
    {
        value = number;
    }

    public void CompareValue(IntData obj)
    {
        if (value >= obj.value)
        {
           
        }
        else
        {
            value = obj.value;
        }
    }
    

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void SetValue(IntData obj)
    {
        value = obj.value;
    }
    
    

   // private void OnDisable()
   // {
    //    disableEvent.Invoke();
   // }

    public void ReplaceValue(int number)
    {
        value = number;
    }

    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
