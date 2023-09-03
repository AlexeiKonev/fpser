using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameHelper : MonoBehaviour
{
    public Text AppleCounter;
    public int TreePrice = 5;

    private int _appleCounter;

    public int AppleCounterProp
    {
        get
        {
            return _appleCounter;
        }
        set
        {
            _appleCounter = value;
            AppleCounter.text = _appleCounter.ToString();
        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.collider.gameObject == null)
                    return;
                Debug.Log("Hit = " + hit.collider.gameObject.name);

                if (hit.collider.name.Contains("Apple"))
                {
                    AppleCounterProp++;
                    
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.name.Contains("Floor") &&
                    _appleCounter >= TreePrice)
                {
                    AppleCounterProp -= TreePrice;

                    Vector3 pointPosition = hit.point;
                    pointPosition.y = -0.25f;
                    GameObject tree = Instantiate(Resources.Load("Tree"), pointPosition, Quaternion.identity) as GameObject;
                }
            }
        }
    }
}
