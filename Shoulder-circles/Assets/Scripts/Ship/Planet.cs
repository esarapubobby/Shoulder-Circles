using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public float orbitRadius = 3f;
    private LineRenderer orbitRing;
    private int LineSegments = 64;

    void Start()
    {
        orbitRing = GetComponent<LineRenderer>();

        //LineRenderer
        orbitRing.loop =true;
        orbitRing.startWidth = 0.05f;
        orbitRing.endWidth = 0.05f;
        orbitRing.positionCount = LineSegments+1;
        orbitRing.useWorldSpace = true;

        //white Color
        orbitRing.startColor = new Color(1f, 1f, 1f, 0.3f);
        orbitRing.endColor = new Color(1f, 1f, 1f, 0.3f);



        DrawnRing();
    }
    public void DrawnRing()
    {
        for( int i =0; i<=LineSegments; i++)
        {
            float angle = (i/(float)LineSegments)*360f*Mathf.Deg2Rad;
            float x = transform.position.x + Mathf.Cos(angle) * orbitRadius;
            float z = transform.position.z + Mathf.Sin(angle) * orbitRadius;

            orbitRing.SetPosition(i,new Vector3(x,transform.position.y,z));
        }
    }
    public void SetRadius(float radius)
    {
        orbitRadius = radius;
        DrawnRing();
    }

}
