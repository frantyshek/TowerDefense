using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtons : MonoBehaviour
{
    [SerializeField] Button archerTowerButton;
    [SerializeField] Button balistaTowerButton;
    [SerializeField] Button cannonTowerButton;
    [SerializeField] Button wizardTowerButton;

    public static bool archerTower = false;
    public static bool balistaTower = false;
    public static bool cannonTower = false;
    public static bool wizardTower = false;

    void Start()
    {
        archerTowerButton.onClick.AddListener(archerTowerSelected);
        balistaTowerButton.onClick.AddListener(balistaTowerSelected);
        cannonTowerButton.onClick.AddListener(cannonTowerSelected);
        wizardTowerButton.onClick.AddListener(wizardTowerSelected);
    }

    public void archerTowerSelected()
    {
        archerTower = !archerTower;
        balistaTower = false;
        cannonTower = false;
        wizardTower = false;

    }

    public void balistaTowerSelected()
    {
        balistaTower = !balistaTower;
        archerTower = false;
        cannonTower = false;
        wizardTower = false;
    }

    public void cannonTowerSelected()
    {
        cannonTower = !cannonTower;
        archerTower = false;
        balistaTower = false;
        wizardTower = false;
    }

    public void wizardTowerSelected()
    {
        wizardTower = !wizardTower;
        archerTower = false;
        balistaTower = false;
        cannonTower = false;
    }
}
