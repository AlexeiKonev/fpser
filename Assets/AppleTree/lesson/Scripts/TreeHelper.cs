using UnityEngine;
namespace Tree.Helper
{
    public class TreeHelper : MonoBehaviour
    {

        public float AppleSpawnTime = 3;

        public Transform PointSpawn;
        // Use this for initialization
        void Start()
        {
            InvokeRepeating("Timer", AppleSpawnTime, AppleSpawnTime);
        }

        void Timer()
        {
            GetComponent<Animator>().SetTrigger("GetApple");
            GameObject apple = Instantiate(Resources.Load("Apple"), PointSpawn.position, Random.rotation) as GameObject;
            apple.GetComponent<Rigidbody>().AddForce(apple.transform.forward * 10);
            Destroy(apple, 10.0f);

        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}

