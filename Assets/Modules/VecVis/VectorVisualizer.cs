using UnityEngine;

namespace VecVis
{
    public class VectorVisualizer : MonoBehaviour
    {
        public int id;
        public Vector3 start, end;
        public Color color;
        public bool undying;
        public float lifeTime;

        private LineRenderer lineRenderer;

        private void Awake()
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.positionCount = 2;
        }

        private void Update()
        {
            lineRenderer.startColor = color;
            lineRenderer.endColor = color;
            lineRenderer.widthMultiplier = 0.1f;

            lineRenderer.material.color = color;
            lineRenderer.SetPosition(0, transform.TransformPoint(start));
            lineRenderer.SetPosition(1, transform.TransformPoint(end));
        }
    }
}
