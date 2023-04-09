using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_shild : MonoBehaviour
{
    [SerializeField]
    float top_filde;
    [SerializeField]
    float bottom_filde;
    [SerializeField]
    float left_filde;
    [SerializeField]
    float right_filde;
    [SerializeField]
    float duration_for_appearing = 1f;
    [SerializeField]
    GameObject shild_object;

    float x, y;// the coordinate of the shilde
    GameObject newObject = null;
    public bool shilded_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        spawn_shilde();
    }

    // Update is called once per frame
    void Update()
    {
        if(newObject == null && shilded_flag == false)
        {
            Debug.Log("spawn one shilde!");
            spawn_shilde();
        }
    }
    void spawn_shilde()
    {
        x = Random.Range(left_filde, right_filde);
        y = Random.Range(bottom_filde, top_filde);
        newObject = Instantiate(shild_object.gameObject, new Vector2(x, y), Quaternion.identity,this.transform);
        StartCoroutine("spawn_and_disapear");
    }
    IEnumerator spawn_and_disapear()
    {
        yield return new WaitForSeconds(duration_for_appearing);
        Destroy(newObject);
    }
}
