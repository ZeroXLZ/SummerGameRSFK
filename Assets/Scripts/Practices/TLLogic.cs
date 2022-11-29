using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLLogic : MonoBehaviour
{
    private GameObject r11;
    private GameObject r12;
    private GameObject r21;
    private GameObject r22;
    private GameObject y11;
    private GameObject y12;
    private GameObject y21;
    private GameObject y22;
    private GameObject g11;
    private GameObject g12;
    private GameObject g21;
    private GameObject g22;
    private GameObject G1Light;
    private GameObject G2Light;
    private GameObject R1Light;
    private GameObject R2Light;
    public GameObject tl;
    private void Start()
    {
        r11 = GameObject.Find("R11");
        r12 = GameObject.Find("R12");
        r21 = GameObject.Find("R21");
        r22 = GameObject.Find("R22");
        y11 = GameObject.Find("Y11");
        y12 = GameObject.Find("Y12");
        y21 = GameObject.Find("Y21");
        y22 = GameObject.Find("Y22");
        g11 = GameObject.Find("G11");
        g12 = GameObject.Find("G12");
        g21 = GameObject.Find("G21");
        g22 = GameObject.Find("G22");
        G1Light = GameObject.Find("G1Light");
        G2Light = GameObject.Find("G2Light");
        R1Light = GameObject.Find("R1Light");
        R2Light = GameObject.Find("R2Light");
        StartCoroutine(lightWork());
    }

    IEnumerator lightWork()
    {
        while (true)
        {
            tl.GetComponent<TL>().priorityF = 1;
            R1Light.GetComponent<Light>().intensity = 500;
            R2Light.GetComponent<Light>().intensity = 500;
            g11.GetComponent<Light>().intensity = 500;
            g12.GetComponent<Light>().intensity = 500;
            r21.GetComponent<Light>().intensity = 500;
            r22.GetComponent<Light>().intensity = 500;
            yield return new WaitForSeconds(5);
            y11.GetComponent<Light>().intensity = 500;
            y12.GetComponent<Light>().intensity = 500;
            g11.GetComponent<Light>().intensity = 0;
            g12.GetComponent<Light>().intensity = 0;
            yield return new WaitForSeconds(3);
            tl.GetComponent<TL>().priorityS = 1;
            tl.GetComponent<TL>().priorityF = 0;
            r11.GetComponent<Light>().intensity = 500;
            r12.GetComponent<Light>().intensity = 500;
            r21.GetComponent<Light>().intensity = 0;
            r22.GetComponent<Light>().intensity = 0;
            y11.GetComponent<Light>().intensity = 0;
            y12.GetComponent<Light>().intensity = 0;
            g21.GetComponent<Light>().intensity = 500;
            g22.GetComponent<Light>().intensity = 500;
            yield return new WaitForSeconds(5);
            y21.GetComponent<Light>().intensity = 500;
            y22.GetComponent<Light>().intensity = 500;
            g21.GetComponent<Light>().intensity = 0;
            g22.GetComponent<Light>().intensity = 0;
            yield return new WaitForSeconds(3);
            tl.GetComponent<TL>().priorityS = 0;
            tl.GetComponent<TL>().priorityF = 0;
            R1Light.GetComponent<Light>().intensity = 0;
            R2Light.GetComponent<Light>().intensity = 0;
            G1Light.GetComponent<Light>().intensity = 500;
            G2Light.GetComponent<Light>().intensity = 500;
            y21.GetComponent<Light>().intensity = 0;
            y22.GetComponent<Light>().intensity = 0;
            r11.GetComponent<Light>().intensity = 500;
            r12.GetComponent<Light>().intensity = 500;
            r21.GetComponent<Light>().intensity = 500;
            r22.GetComponent<Light>().intensity = 500;
            yield return new WaitForSeconds(10);
            r11.GetComponent<Light>().intensity = 0;
            r12.GetComponent<Light>().intensity = 0;
            G1Light.GetComponent<Light>().intensity = 0;
            G2Light.GetComponent<Light>().intensity = 0;
        }
    }
}
