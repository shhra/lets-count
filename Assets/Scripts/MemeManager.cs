﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeManager : MonoBehaviour {

    // you will have to manually select all the images in the inspector
    public List<Sprite> images;
    //CanvasRenderer sr;

    void Start()
    {
        // reference to the SpriteRenderer component on your GameObject
        
       showRandomImage();
    }

    void showRandomImage()
    {
        // count the number of images that you have selected..
        // lets say you selected 30 images
        int count = images.Count;

        // randomly select any number between 0 and 30
        int index = Random.Range(0, count); // let's assume that the output is 5

        // now we will assign an image from our list which is at index 5
        GetComponent<UnityEngine.UI.Image>().sprite = images[index];
    }
}
