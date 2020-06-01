using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManagementScript : MonoBehaviour
{
    public enum dataType { none, C02, NO2, CO, SO2}
    public dataType typeOfData = dataType.none;
    [SerializeField]
    Dropdown dataDropDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeDataType()
    {
        typeOfData = (dataType)dataDropDown.value;
    }
}
