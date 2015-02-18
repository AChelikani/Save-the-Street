var speed = 5;

function Update() {
	transform.Translate(Vector3.forward * speed * Time.deltaTime);
}