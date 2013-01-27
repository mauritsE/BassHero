function Update () {

	
       var up = transform.TransformDirection(Vector3.up);
       var hit : RaycastHit;    
       Debug.DrawRay(transform.position, -up * 10, Color.green);
     
       if(Physics.Raycast(transform.position, -up, hit, 10)){
          Debug.Log("Hit");    
          if(hit.collider.gameObject.name == "floor"){
               Destroy(GetComponent(Rigidbody));
          }
       }
    }

