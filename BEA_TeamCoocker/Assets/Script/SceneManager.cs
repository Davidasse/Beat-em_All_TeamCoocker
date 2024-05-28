using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public Player _player;
    private Image _image;
    private float _maxPV=50;
    private float _maxStamina = 5;
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        //Gestion de la barre de vie
        _image.fillAmount = _player.pvPlayer / _maxPV;

        if ( _player.pvPlayer > 25f)
        {
            _image.color = Color.green;
        }
        else if (_player.pvPlayer > 10f && _player.pvPlayer < 25f)
        {
            _image.color = Color.yellow;
        }
        else if (_player.pvPlayer < 10f)
        {
            _image.color = Color.red;
        }
    }

    public void CheckGameOver()
    {

    }
}