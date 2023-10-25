using UnityEngine;

public class Parallax : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public float speed;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }
    private void Update()
    {
        meshRenderer.material.mainTextureOffset+=new Vector2(speed*Time.deltaTime,0);
    }
}
