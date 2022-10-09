
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviorObject : MonoBehaviour
{
   public SpriteRenderer _renderObj;
   

   private void Awake()
   {
      _renderObj = GetComponent<SpriteRenderer>();
   }

   public void ChangeRenderColor(ColorID obj)
   {
      _renderObj.color = obj.value;
   }

   public void ChangeRendererColor(ColorIDListsData obj)
   {
      _renderObj.color = obj.currentColor.value;
   }
}
