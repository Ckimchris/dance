using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<float> rotations;
    public GameObject arrow;
    public List<GameObject> positions;

    public List<GameObject> arrows;
    public List<GameObject> tempArrows;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(ArrowSetBegin());
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(NextSet());
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Clean();
        }
    }

/*    IEnumerator ArrowSetBegin()
    {
        foreach(var position in positions)
        {
            GameObject arrowObj = Instantiate(arrow, position.transform.position, Quaternion.identity);
            arrowObj.transform.eulerAngles = new Vector3(0, 0, rotations[Random.Range(0, rotations.Count)]);
            arrows.Add(arrowObj);
            tempArrows.Add(arrowObj);
            yield return new WaitForSeconds(0.5f);
        }

    }*/

    IEnumerator ArrowSetBegin()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject arrowObj = Instantiate(arrow, positions[i].transform.position, Quaternion.identity);
            arrowObj.transform.eulerAngles = new Vector3(0, 0, rotations[Random.Range(0, rotations.Count)]);
            arrows.Add(arrowObj);
            tempArrows.Add(arrowObj);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(1f);
        Clean();
    }

    IEnumerator NextSet()
    {
        int i = 0;
        for(i = 0;i < arrows.Count; i++)
        {
            arrows[i].SetActive(true);
            yield return new WaitForSeconds(0.5f);
        }

        GameObject arrowObj = Instantiate(arrow, positions[i++].transform.position, Quaternion.identity);
        arrowObj.transform.eulerAngles = new Vector3(0, 0, rotations[Random.Range(0, rotations.Count)]);
        arrows.Add(arrowObj);
        tempArrows.Add(arrowObj);

        yield return new WaitForSeconds(1f);
        Clean();
    }

    void Clean()
    {
        foreach(var arrow in tempArrows)
        {
            arrow.SetActive(false);
        }
    }
}
