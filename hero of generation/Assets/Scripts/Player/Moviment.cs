using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Moviment : MonoBehaviour
{

    //@Authors
    //
    //🅖🅘🅣🅗🅤🅑 Monika_404 
    //
    //🅖🅘🅣🅗🅤🅑 Ed2002
    //

    [SerializeField] float Speed = 4f;
    [SerializeField] string Scene;
    Rigidbody2D controller;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMoviment();
    }

    private void UpdateMoviment()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * Speed;
        controller.velocity = new Vector2(moveBy, controller.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(Scene);
    }
}
