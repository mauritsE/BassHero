var speed: float = 5.0;
var ball;
var frontplane;
var backplane;
function Update () {

	transform.Translate(Vector3(0,0,- speed) * Time.deltaTime);
	


}