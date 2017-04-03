using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	[SerializeField]
	private GameObject smallAst;

	[SerializeField]
	private GameObject medAst;

	[SerializeField]
	private GameObject largeAst;

	private int maxTotal = 800;
	private float spawnArea = 6000f;
	public static int totalCubes;

	// Use this for initialization
	void Start () {
		totalCubes = 0;
	}
	
	// Update is called once per frame
	void Update () {
		while (totalCubes < maxTotal) {
			totalCubes++;
			float positionX = Random.Range (-spawnArea, spawnArea);
			float positionZ = Random.Range (-spawnArea, spawnArea);
			float positionY = Random.Range (-spawnArea, spawnArea);
			Vector3 position = new Vector3 (positionX, positionY, positionZ);
			float modelDecide = (int) Random.Range (0, 3) + 1;
			if (modelDecide == 1) {
				Instantiate (smallAst, position, Quaternion.identity);
			} else if (modelDecide == 2) {
				Instantiate (medAst, position, Quaternion.identity);
			} else {
				Instantiate (largeAst, position, Quaternion.identity);
			}
		}
	}
}
