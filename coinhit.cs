using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class coinhit : MonoBehaviour
{
    public float hp = 2;
    
    public GameObject coin;
    
    public GameObject chrome;
    public TextMeshProUGUI text;
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        RaycastHit2D[] hit = Physics2D.CircleCastAll(transform.position, 8.505f, Vector2.zero);
        if (hit != null)
        {

                Destroy(chrome.gameObject);
             
        }
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = hp.ToString(); 
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 1.2f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
