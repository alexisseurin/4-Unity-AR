using UnityEngine;

public class ClickElementBehaviour : MonoBehaviour
{
    public ItemLabelBehaviour itemLabelBehaviour;
    public GameObject labelGameObject;


    void OnMouseOver()
    {
        labelGameObject.SetActive(true);
        itemLabelBehaviour.Label.text = gameObject.name;
    }

    void OnMouseExit()
    {
        itemLabelBehaviour.Label.text = "";
    }
}
