using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour {
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;

    private int _id;
    
    public int id {
        get { return _id;}
    }

    public void setCard(int id, Sprite image) {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void OnMouseDown() {
        if (cardBack.activeSelf) {
            cardBack.SetActive(false);
        }
    }
}
