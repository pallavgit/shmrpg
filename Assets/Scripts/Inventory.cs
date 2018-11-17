﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	#region Singleton

	public static Inventory instance;

	void Awake ()
	{
		instance = this;
	}

	#endregion




	public delegate void OnItemChanged();
	public OnItemChanged onItemChangedCallback;

	public int space = 20;
	public List<Item> items = new List<Item>();

	// Add a new item if enough room
	public bool Add (Item item)
	{
		if (!item.isDefalutItem) 
		{
			if (items.Count >= space) 
			{
				Debug.Log ("Not enough room.");
				return false;
			}

			items.Add (item);
			if(onItemChangedCallback != null)
			  onItemChangedCallback.Invoke ();
		}
		return true;
	}

	// Remove an item
	public void Remove (Item item)
	{
		items.Remove (item);
		if(onItemChangedCallback != null)
			onItemChangedCallback.Invoke (); 
	}
}