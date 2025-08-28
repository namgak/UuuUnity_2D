using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this things position (camera) should be the same as the car's position
    // we don't need Start() : what we gonna be doing is happening in every single frame.

    void LateUpdate()
    {
        // camera is going to access to game object's Position of Transform
        // 정의? :카메라의 위치가 thing to follow 에 지정한 것의 위치와 일치하기를 바라고 있다.
        // 하지만 정확히 일치하게 되면, 인게임에서는 붙어버려서 background만 보이게 된다.
        // 따라서, Z축 상에서 약간 뒤로 빠져있어야 한다.
        // transform.position = thingToFollow.transform.position; X
        transform.position = thingToFollow.transform.position + new Vector3 (0,0, -10); 

    }
}
