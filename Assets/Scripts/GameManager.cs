using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public RectTransform nameTag;
    public void UpdateNameTag(ClickableObject clickableObject) {
        nameTag.GetComponentInChildren<TextMeshProUGUI>().text = clickableObject.objectName;
        
        nameTag.sizeDelta = clickableObject.nameTagSize;

        nameTag.localPosition = new Vector2(clickableObject.nameTagSize.x / 2.0f + 1.0f, -0.5f);
    }
}
