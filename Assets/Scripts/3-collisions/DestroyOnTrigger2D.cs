using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField]
    float bottom_filde = -6.66f;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        if(transform.position.y <= bottom_filde)
        {
            Destroy(this.gameObject);
        }
    }
}
