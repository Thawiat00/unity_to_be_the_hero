using UnityEngine;


//another example  : https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Object.Instantiate.html

public class template_2_Object_Instantiate : MonoBehaviour
{

    public GameObject prefab;
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }


}
