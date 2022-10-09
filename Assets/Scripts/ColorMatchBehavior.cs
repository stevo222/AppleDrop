using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchedBehavior
{
    public ColorIDListsData colorDatalistobj;

    private void Awake()
    {
        idObj = colorDatalistobj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var NewColor = idObj as ColorID;
        renderer.color = NewColor.value;
    }
}
