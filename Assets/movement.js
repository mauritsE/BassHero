function Update () {

     //transform.Translate(Vector3(0,0,1) * Time.deltaTime);
     var fwd = transform.forward * 100;
     rigidbody.AddForce(fwd);
    }

