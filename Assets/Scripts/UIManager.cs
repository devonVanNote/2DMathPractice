using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;
    public GameObject fuel;
    public Text tankPosition;
    public Text fuelPosition;
    public Text energyAmount;

    // Start is called before the first frame update
    void Start()
    {
        tankPosition.text = tank.transform.position + string.Empty;
        fuelPosition.text = fuel.GetComponent<ObjectManager>().objectPosition + string.Empty;
    }

    // Update is called once per frame
    public void AddEnergy(string amount)
    {
        int number;
        if (int.TryParse(amount, out number))
        {
            energyAmount.text = amount;
        }
    }
}
