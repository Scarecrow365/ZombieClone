using UnityEngine;

public class Zombie : MonoBehaviour
{

    [SerializeField] private float _speed;
    private bool _isDead;

    private Transform _head;
    private Rigidbody _headRigidbody;
    private GameController _gameController;

    void Awake()
    {
        _head = transform.GetChild(0);
        _gameController = FindObjectOfType<GameController>();
    }

    void Update()
    {
        if (!_isDead)
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _gameController.GameOver();
            Destroy(other.gameObject);
        }


        if (other.CompareTag("Weapon"))
        {
            _isDead = true;
            _head.transform.SetParent(null);
            _headRigidbody = _head.gameObject.AddComponent<Rigidbody>();
            _headRigidbody.AddForce(new Vector3(-6,10), ForceMode.Impulse);
            Destroy(_head.gameObject, 2f);
            Destroy(gameObject);
        }
    }
}
