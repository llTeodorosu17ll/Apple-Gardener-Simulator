using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bear : MonoBehaviour{

	private Rigidbody2D rigidBody;

	// movement speed of bears
	[SerializeField] private float moveSpeed;

	private bool moveRight;

	// saves reference to field
	private void Awake() => rigidBody = GetComponent<Rigidbody2D>();

	// this method called when bear appears in game
	private void Start() {
		moveRight = transform.position.x < 0;

		// set rotation at start
		float yRotation = moveRight ? 0 : 180;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
	}

	// physics can update objects properly with fixedupdate
	private void FixedUpdate() => rigidBody.velocity = new Vector2(moveSpeed * Time.fixedDeltaTime * (moveRight ? 1 : -1), rigidBody.velocity.y);
}