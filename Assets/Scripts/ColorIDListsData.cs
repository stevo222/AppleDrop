using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class ColorIDListsData : ScriptableObject
{

 public List<ColorID> colorIDList;

 public ColorID currentColor;

 private int numb;

 public void SetCurrentColorRandomly()
 {
  numb = Random.Range(0, colorIDList.Count);
  currentColor = colorIDList[numb];
 }
}
