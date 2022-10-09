
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
   private Text label;

   public UnityEvent StartEvent;
   //public FloatData dataObj;

   private void Start()
   {
      label = GetComponent<Text>();
      StartEvent.Invoke();
      // UpdateLabel();

   }

   public void UpdateLabel(FloatData obj)
   {
      label.text = obj.value.ToString(CultureInfo.InvariantCulture);
      //label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
   }

   public void UpdageLabel(IntData obj)
   {
      label.text = obj.value.ToString(CultureInfo.InvariantCulture);
   }
}
