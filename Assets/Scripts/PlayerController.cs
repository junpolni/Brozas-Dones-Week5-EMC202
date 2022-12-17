using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public PlayerClass playerClass;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Weapon weapon;

    [SerializeField] Transform weaponHand;

    Vector2 moveDirection;
    Vector2 mousePosition;

    private void Start()
    {
        moveSpeed = playerClass.moveSpeed;
        GetComponent<SpriteRenderer>().sprite = playerClass.playerSprite;
    }

    // Update is called once per frame
    void Update()
    {
        MovementInput();
        RotateHand();
    
        if (!PauseMenu.isPaused)
        {
            AttackInput();
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        /*Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle; */
    }

    void RotateHand()
    {
        float angle = Utility.AngleTowardsMouse(weaponHand.position);
        weaponHand.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    void MovementInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void AttackInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }
        mousePosition = Camera.main.WorldToScreenPoint(Input.mousePosition);
    }

    

    
}
