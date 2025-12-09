using UnityEngine;

public class DissolveAnimate : MonoBehaviour
{
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float h = Mathf.PingPong(Time.time, 1.0f);
        rend.material.SetFloat("_CutoffHeight", -h);
    }
}
