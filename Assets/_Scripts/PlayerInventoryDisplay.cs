using UnityEngine;

[RequireComponent(typeof(PlayerInventory))]
public class PlayerInventoryDisplay : MonoBehaviour
{
	private int numInventorySlots;
	private PickupUI[] slots;

	public GameObject panelSlotGrid;
	public GameObject starSlotPrefab;

	void Awake()
	{
		GameObject[] gameObjectsTaggedStar = GameObject.FindGameObjectsWithTag("Star");
		numInventorySlots = gameObjectsTaggedStar.Length;

		slots = new PickupUI[numInventorySlots];
		float width = 50 + (numInventorySlots * 50);
		panelSlotGrid.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);

		for (int i = 0; i < numInventorySlots; i++)
		{
			GameObject starSlotGO = (GameObject)
				Instantiate(starSlotPrefab);
			starSlotGO.transform.SetParent(panelSlotGrid.transform);
			starSlotGO.transform.localScale = new Vector3(1, 1, 1);
			slots[i] = starSlotGO.GetComponent<PickupUI>();
		}
	}


	public void OnChangeStarTotal(int starTotal)
	{
		for (int i = 0; i < numInventorySlots; i++)
		{
			PickupUI slot = slots[i];
			if (i < starTotal)
				slot.DisplayColorIcon();
			else
				slot.DisplayGreyIcon();
		}
	}
}
