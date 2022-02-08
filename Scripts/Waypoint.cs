using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [SerializeField] GameObject archerTowerPrefab;
    [SerializeField] GameObject balistaTowerPrefab;
    [SerializeField] GameObject cannonTowerPrefab;
    [SerializeField] GameObject wizardTowerPrefab;
    [SerializeField] GameObject redCube;
    [SerializeField] GameObject greenCube;

    public bool isPlaceable;

    void OnMouseDown()
    {
        if(ShopButtons.archerTower == true && isPlaceable)
        {
            Instantiate(archerTowerPrefab, transform.position, Quaternion.identity);
            isPlaceable = false;
            greenCube.SetActive(false);
            redCube.SetActive(true);
        }

        if(ShopButtons.balistaTower == true && isPlaceable)
        {
            Instantiate(balistaTowerPrefab, transform.position, Quaternion.identity);
            isPlaceable = false;
            greenCube.SetActive(false);
            redCube.SetActive(true);
        }

        if(ShopButtons.cannonTower == true && isPlaceable)
        {
            Instantiate(cannonTowerPrefab, transform.position, Quaternion.identity);
            isPlaceable = false;
            greenCube.SetActive(false);
            redCube.SetActive(true);
        }

        if(ShopButtons.wizardTower == true && isPlaceable)
        {
            Instantiate(wizardTowerPrefab, transform.position, Quaternion.identity);
            isPlaceable = false;
            greenCube.SetActive(false);
            redCube.SetActive(true);
        }
    }

    void OnMouseEnter()
    {
        if(isPlaceable)
        {
            greenCube.SetActive(true);
        }
        else
        {
            redCube.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        greenCube.SetActive(false);
        redCube.SetActive(false);
    }
}
