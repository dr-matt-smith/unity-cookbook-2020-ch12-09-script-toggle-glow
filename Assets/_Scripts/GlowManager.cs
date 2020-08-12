using UnityEngine;

public class GlowManager : MonoBehaviour
{
	private string powerId = "Vector1_FAA90140";
	private string colorId = "Color_22064B5A";

	void Update()
	{
		if (Input.GetKeyDown("0"))
			GetComponent<Renderer>().material.SetFloat(powerId, 0);

		if (Input.GetKeyDown("1"))
			SetGlowColor(Color.red);

		if (Input.GetKeyDown("2"))
			SetGlowColor(Color.blue);
	}

	private void SetGlowColor(Color c)
	{
		GetComponent<Renderer>().material.SetFloat(powerId, 5);
		GetComponent<Renderer>().material.SetColor(colorId, c);
	}
}
