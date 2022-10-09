
using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDListsData colorDatalistobj;

    private void Awake()
    {
        idobj = colorDatalistobj.currentColor;
    }
}
