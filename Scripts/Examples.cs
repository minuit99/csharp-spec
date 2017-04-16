using UnityEngine;
using System.Collections;

public class EnumExample : MonoBehaviour
{
	public enum WeaponType { Sword, Dagger, Knife, Staff, Mace }

	public WeaponType currentWeapon = WeaponType.Dagger;

	// Use this for initialization
	void Start ()
	{



	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (currentWeapon) 
		{
		case WeaponType.Dagger: 
			Debug.Log("dagger");
			break;
		case WeaponType.Staff:
			Debug.Log("Its staff");
			break;
		default:
			break;
		}

	}
}



//Ninja without triggering distance.y


//	//	private float speed = 50.0f;
//	private float distanceFrom;
//	public bool grounded = true;
//	private bool isAttacking;
//	private bool isJumping;
//	private float jumpXSpeed = 3f;
//	private float jumpYSpeed = 6.5f;
//
//
//	public GameObject dagger;
//	public GameObject player;
//	private Vector3 distance;
//	private PlayerHealth playerHealth;
//	private Rigidbody rb;
//
//
//
//	//	private enum State { IDLE, JUMPING, ATTACKING };
//	//	private State currentState = State.IDLE;
//
//
//
//	void Awake()
//	{
//		playerHealth = player.GetComponent<PlayerHealth>();
//		rb = GetComponent<Rigidbody>();
//
//	}
//
//	void Update()
//	{
//		//		switch (currentState) 
//		//		{
//		//			case State.IDLE:
//		//			{
//		//				Debug.Log("State is 1");
//		//				break;
//		//			}
//		//			case State.JUMPING:
//		//			{
//
//
//
//		distance = ( player.transform.position - transform.position );
//		//		distance.y = 0;
//		distance.z = 0;
//		distanceFrom = distance.magnitude;
//		//distance /= distanceFrom;
//
//
//		if(distanceFrom <= 7.0f)
//		{
//
//			//	if(distance == new Vector3(1,0,0))
//			//	{
//			//				Debug.Log("player is at left");
//			if(distance.x < 0f)
//			{
//				transform.localEulerAngles = new Vector3(0,0,0);
//				StartCoroutine(JumpLeft(2));
//				//}
//
//			}
//			else	if(distance.x> 0f)
//			{
//				//				Debug.Log(distanceFrom);
//				//				Debug.Log("player is at right");
//
//				//{
//				transform.localEulerAngles = new Vector3(0,180,0);
//				StartCoroutine(JumpRight(2));
//				//	}
//
//
//			}
//
//		}
//
//
//	}
//
//	IEnumerator JumpLeft(float seconds)
//	{
//		if (grounded && !isJumping) 
//		{
//			rb.AddForce(-jumpXSpeed, jumpYSpeed, 0, ForceMode.VelocityChange);
//			isJumping = true;
//			yield return new WaitForSeconds(seconds);
//			Debug.Log(grounded);
//			isAttacking = true;
//			if(isAttacking)
//			{
//				StartCoroutine(Attacking(0.3f));
//			}
//
//		}
//
//		yield return null;
//
//	}
//
//	IEnumerator JumpRight(float seconds)
//	{
//		if (grounded && !isJumping) 
//		{
//			rb.AddForce(jumpXSpeed, jumpYSpeed, 0, ForceMode.VelocityChange);
//			isJumping = true;
//			yield return new WaitForSeconds(seconds);
//			//			Debug.Log(grounded);
//			isAttacking = true;
//			if(isAttacking)
//			{
//				StartCoroutine(Attacking(0.3f));
//			}
//
//		}
//		yield return null;
//
//	}
//
//	IEnumerator Attacking(float seconds)
//	{
//		//		Debug.Log("Who?");
//
//		dagger.GetComponent<MeshRenderer>().enabled = true;
//		dagger.GetComponent<BoxCollider>().enabled = true;
//		yield return new WaitForSeconds (seconds);
//		isAttacking = false;
//		dagger.GetComponent<MeshRenderer>().enabled = false;
//		dagger.GetComponent<BoxCollider>().enabled = false;
//		isJumping = false;
//
//	}
//
//
//	void OnCollisionEnter(Collision col)
//	{
//		if(col.gameObject.tag == "Ground")
//		{
//			grounded = true;
//		}
//	}
//
//	//	void OnCollisionExit(Collision col)
//	//	{
//	//		grounded = false;
//	//	}
//
//
//	void OnTriggerEnter(Collider trig)
//	{
//		if(trig.gameObject.tag == "Player")
//		{
//			playerHealth.takeDamage();
//		}
//
//		if(trig.gameObject.tag == "Sword")
//		{
//			//addforce in the direction oposite to player's sword
//			//			rb.AddForce(
//			//			transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
//			Destroy(gameObject, 0.5f);
//		}
//	}
//
//}


