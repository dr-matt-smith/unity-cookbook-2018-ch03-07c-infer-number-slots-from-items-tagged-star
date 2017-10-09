using UnityEngine;
using System.Collections;

/**
 * class to reveal/hide colored and grey image icons for a panel
 */
public class PickupUI : MonoBehaviour 
{
	// reference to colored icon
	public GameObject iconColor;

	// reference to grey version of icon
	public GameObject iconGrey;

	// just before starts, default panel to show neither icon
	// then in some Start() method, things can be initliased to match items in inventory ...
	void Awake()
	{
		DisplayEmpty();
	}

	// show the colored icon
	public void DisplayColorIcon()
	{
		iconColor.SetActive(true);
		iconGrey.SetActive(false);
	}

	// show the grey icon
	public void DisplayGreyIcon()
	{
		iconColor.SetActive(false);
		iconGrey.SetActive(true);
	}

	// show just the background image of the panel
	// (hide both colored and grey icons)
	public void DisplayEmpty()
	{
		iconColor.SetActive(false);
		iconGrey.SetActive(false);
	}
}
