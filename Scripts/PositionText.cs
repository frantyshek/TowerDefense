using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]

public class PositionText : MonoBehaviour
{
    [SerializeField] Color defaultColor = Color.white;
    [SerializeField] Color disabledColor = Color.gray;
    TextMeshPro positionsText;
    Vector2Int positionVector = new Vector2Int();
    Waypoint waypoint;
    
    void Awake()
    {
        positionsText = GetComponent<TextMeshPro>();
        waypoint = GetComponentInParent<Waypoint>();
        DisplayTextPositions();

        positionsText.enabled = false;
    }

    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayTextPositions();
            UpdateObjectName();
        }

        PositionTextColor();

        DisablingPositionText();
    }

    void PositionTextColor()
    {
        if(waypoint.isPlaceable)
        {
            positionsText.color = defaultColor;
        }
        else
        {
            positionsText.color = disabledColor;
        }
    }

    void DisablingPositionText()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            positionsText.enabled = !positionsText.IsActive();
        }
    }

    void DisplayTextPositions()
    {
        positionVector.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        positionVector.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        positionsText.text = positionVector.x + "," + positionVector.y;
    }

    void UpdateObjectName()
    {
        transform.parent.name = positionVector.ToString();
    }
}
