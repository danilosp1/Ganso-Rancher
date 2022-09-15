using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;

    private void Awake() {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start() {
        CreateItemButton(/*Item.GetSprite(Item.ItemType.Seed),*/"Seed", Item.GetCost(Item.ItemType.Seed), 0);
        CreateItemButton(/*Item.GetSprite(Item.ItemType.Seed),*/"Plant", Item.GetCost(Item.ItemType.Plant), 1);
    }

    private void CreateItemButton(/*Sprite itemSprite,*/ string itemName, int itemCost, int positionIndex){
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("NameText").GetComponent<Text>().text = itemName.ToString();
        shopItemTransform.Find("PriceText").GetComponent<Text>().text = itemCost.ToString();
        // shopItemTransform.Find("ItemImage").GetComponent<Image>().sprite = itemSprite;

    }
}
