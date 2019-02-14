using UnityEngine;
using System.Collections;

public class UIButton : MonoBehaviour {
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color highlightColor = Color.cyan;

    public void OnMouseEnter() {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null) {
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit() {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null) {
            sprite.color = Color.white;
        }
    }

    public void OnMouseDown() {
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }

    public void OnMouseUp() {
        transform.localScale = new Vector3(0.19f, 0.19f, 0.19f);
        if (targetObject != null) {
            targetObject.SendMessage(targetMessage);
        }
    }
}
