using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class ItemLabelBehaviour : MonoBehaviour
{
    public TextMeshProUGUI Label;
    public Camera mainCamera;
    public Transform LabelPos1; // Tailstock
    public Transform LabelPos2; // Trainard
    public Transform LabelPos3; // Workpiece holder
    public Transform LabelPos4; // Built
    public Transform LabelPos5; // Slide
    public Transform LabelPos6; // Tool Holder
    private Dictionary<string, Transform> labelPositions;

    void Start()
    {
        mainCamera = Camera.main;
        labelPositions = new Dictionary<string, Transform>()
        {
            {"Tailstock", LabelPos1},
            {"Trainard", LabelPos2},
            {"Workpiece holder", LabelPos3},
            {"Built", LabelPos4},
            {"Slide", LabelPos5},
            {"Tool Holder", LabelPos6}
        };
    }

    void Update()
    {
        transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward, mainCamera.transform.rotation * Vector3.up);
        
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (labelPositions.ContainsKey(hit.transform.name))
            {
                Label.text = hit.transform.name;
                Label.transform.position = labelPositions[hit.transform.name].position;
            }
        }
    }
}
