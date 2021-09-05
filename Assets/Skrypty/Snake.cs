using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Snake : MonoBehaviour
{

    public int width;
    public int height;

    //centerMargin okresla przy jakim dystansie do srodka najblizszego tile'a (maximum) moze skrecic.
    //minimum 0.001f, maximum 0.5f
    static float centerMargin = 0.2f;

    TRSkrypt trskrypt;

    Vector2[,] tiles;

    float currentspeed = 5f;
    bool kobra = false;

    enum Turn
    {
        UP,
        LEFT,
        DOWN,
        RIGHT
    };

    Turn QueuedTurn;
    bool TurnIsQueued = false;
    bool SpawnedCollider = false;

    GameObject apbuton;
    GameObject dawnbuton;
    GameObject rigtbuton;
    GameObject leftbuton;
    GameObject napisy;

    void Awake()
    {
        trskrypt = gameObject.GetComponent<TRSkrypt>();

        apbuton = GameObject.Find("Button up");
        dawnbuton = GameObject.Find("Button down");
        rigtbuton = GameObject.Find("Button right");
        leftbuton = GameObject.Find("Button left");
        napisy = GameObject.Find("ScoreText");

        tiles = new Vector2[width, height];

        //Tworzenie Grid'a
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                tiles[x, y] = new Vector2(x - (width / 2), y - (height / 2));
            }
        }

        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        rigtbuton.SetActive(false);
        leftbuton.SetActive(false);
    }

    void ChangeButtonVisibility()
    {
        leftbuton.SetActive(!leftbuton.activeInHierarchy);
        rigtbuton.SetActive(!rigtbuton.activeInHierarchy);
        apbuton.SetActive(!apbuton.activeInHierarchy);
        dawnbuton.SetActive(!dawnbuton.activeInHierarchy);
    }

    public void TaskOnClickLeft()
    {
        QueuedTurn = Turn.LEFT;
        TurnIsQueued = true;
        ChangeButtonVisibility();
    }
    public void TaskOnClickRight()
    {
        QueuedTurn = Turn.RIGHT;
        TurnIsQueued = true;

        ChangeButtonVisibility();
    }
    public void TaskOnClickUp()
    {
        QueuedTurn = Turn.UP;
        TurnIsQueued = true;

        ChangeButtonVisibility();
    }
    public void TaskOnClickDown()
    {
        QueuedTurn = Turn.DOWN;
        TurnIsQueued = true;

        ChangeButtonVisibility();
    }

    void TurnSnake()
    {
        transform.position = tiles[Mathf.RoundToInt(transform.position.x + width / 2), Mathf.RoundToInt(transform.position.y + height / 2)];
        switch (QueuedTurn)
        {
            case Turn.UP:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case Turn.RIGHT:
                transform.rotation = Quaternion.Euler(0, 0, -90);
                break;
            case Turn.DOWN:
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case Turn.LEFT:
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
        }
        TurnIsQueued = false;
    }

    public void TaskOnClick()
    {
        kobra = true;
        rigtbuton.SetActive(true);
        leftbuton.SetActive(true);
    }

    //Poruszanie sie snejka
    void FixedUpdate()
    {
        //Dopiero po kliknieciu guzika, [kobra = true)] 
        //wiec dopiero po kliknieciu waz sie moze ruszac
        if (kobra == true)
        {
            transform.Translate(Vector2.up * currentspeed / 100);
        }
    }

    IEnumerator ColliderSpawnCooldown()
    {
        SpawnedCollider = true;
        yield return new WaitForSecondsRealtime(0.2f);
        SpawnedCollider = false;
    }

    //Sprawdzanie czy waz jest na srodku tile'a.
    //Jesli jest - skreci i sie "wysrodkuje"
    // na srodek tile'a na ktorym sie znajduje
    private void Update()
    {
        Vector2 nearest = tiles[Mathf.Clamp(Mathf.RoundToInt(transform.position.x + width / 2), 0, width), Mathf.Clamp(Mathf.RoundToInt(transform.position.y + height / 2), 0, height)];
        if (Vector2.Distance(transform.position, nearest) < centerMargin)
        {
            if (TurnIsQueued) 
                TurnSnake();
            if (!SpawnedCollider)
            {
                trskrypt.AddCollider();
                StartCoroutine(ColliderSpawnCooldown());
            }
        }
    }
}