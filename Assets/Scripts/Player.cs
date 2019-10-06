using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        transform.eulerAngles = new Vector3(0,180,0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Kick();
    }

    void Kick()
    {
        _animator.SetTrigger("Kick");
    }
}
