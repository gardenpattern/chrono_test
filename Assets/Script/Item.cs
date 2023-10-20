using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType { Ammo, Coin, Grenade, Geart, Weapon }
    public ItemType Type;
    public int value;

    private float moveSpeed = 1;
    private float moveRange = 0.5f;
    private float startPosition = 1.5f;

    private void Update()
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
        MoveTo();
    }

    public void MoveTo()
    {
        float y = startPosition + moveRange * Mathf.Sin(Time.time * moveSpeed);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
