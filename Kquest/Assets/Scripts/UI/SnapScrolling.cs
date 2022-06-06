using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapScrolling : MonoBehaviour
{
    
    [Header("Controllers")]
    [Range(1,50)]
    public int panelCount;
    [Range(0,500)]
    public int panelOffset;
    [Range(0f,20f)]
    public float snapSpeed;
    [Range(0f,20f)]
    public float scrollSpeed;

    private GameObject[] go_list;   
    private Vector2[] panelPos;
    private RectTransform contentRect;
    private Vector2 contentVector;
    public int ID;

    [Range(0f,10f)]
    public float scaleOffset;
    private Vector2[] panelsScale;

    private bool isScrolling;

    [Header("Other objects")]
    public GameObject[] panelPrefabs;

    public ScrollRect scrollRect;

    void Start()
    {
        contentRect = GetComponent<RectTransform>();
        go_list  = new GameObject[panelCount];
        panelPos = new Vector2[panelCount];
        panelsScale = new Vector2[panelCount];

        for (int i = 0; i < panelCount; i++){
            go_list[i] = Instantiate(panelPrefabs[i], transform, false);
            if(i > 0){
                go_list[i].transform.localPosition = new Vector2(go_list[i-1].transform.localPosition.x + panelPrefabs[i].GetComponent<RectTransform>().sizeDelta.x + panelOffset, 
                go_list[i].transform.localPosition.y);
                panelPos[i] = -go_list[i].transform.localPosition;
            } 
        }
    }

    private void FixedUpdate()
    {
        if(contentRect.anchoredPosition.x >= panelPos[0].x && !isScrolling || contentRect.anchoredPosition.x <= panelPos[panelPos.Length - 1].x){
            scrollRect.inertia = false;
        }
        float nearestPos = float.MaxValue;
        for (int i = 0; i < panelCount; i++){
            float distance = Mathf.Abs(contentRect.anchoredPosition.x - panelPos[i].x);
            if (distance < nearestPos){
                nearestPos = distance;
                ID = i;
            }
            float scale = Mathf.Clamp(1 / (distance / panelOffset) * scaleOffset, 0.5f,1f);
            panelsScale[i].x = Mathf.SmoothStep(go_list[i].transform.localScale.x, scale + 0.2f, scrollSpeed * Time.fixedDeltaTime);
            panelsScale[i].y = Mathf.SmoothStep(go_list[i].transform.localScale.x, scale + 0.2f, scrollSpeed * Time.fixedDeltaTime);
            go_list[i].transform.localScale = panelsScale[i];
        }
        float scrollVelocity = Mathf.Abs(scrollRect.velocity.x);
        if(scrollVelocity < 400 && !isScrolling) scrollRect.inertia = false;
        if(isScrolling || scrollVelocity > 400) return;
        contentVector.x = Mathf.SmoothStep(contentRect.anchoredPosition.x, panelPos[ID].x, snapSpeed * Time.fixedDeltaTime);
        contentRect.anchoredPosition = contentVector;
    }

    public void Scrolling(bool scroll){
        isScrolling = scroll;
        if(isScrolling) scrollRect.inertia = true;
    }
}
