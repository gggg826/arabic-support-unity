using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


	void Start()
    {
        //transform.GetComponent<UILabel>().text = "برحلا  ناصحلا  ضيبألا  نم  ميخملا  ةضفلا  .ديلا  نكميو  نأ  نوكي  كيرش  كتايح  يف  ةحاس .ةكرعملا";
        string str = "[-]  متناول الفريق مستوى  [N] [00ffff]";
        transform.GetComponent<UILabel>().text = str.Replace("[N]", "10");
	}
}
