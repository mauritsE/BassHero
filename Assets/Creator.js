var thePrefab : GameObject;

function Start () {
	thePrefab.AddComponent("ballmove");
	var instance : GameObject = Instantiate(thePrefab, transform.position, transform.rotation);
	instance.AddComponent("ballmove");


}