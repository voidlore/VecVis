using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace VecVis
{
    public class VectorVisualizerManager : MonoBehaviour
    {
        private static VectorVisualizerManager instance;
        public static VectorVisualizerManager Instance
        {
            get
            {
                if(instance == null)
                {
                    GameObject managerObject = new GameObject("VectorVisualizationManager");
                    instance = managerObject.AddComponent<VectorVisualizerManager>();
                }
                return instance;
            }
        }

        private List<VectorVisualizer> visualizationObjects = new();
        private int visualizerCount = 0;

        private void Update()
        {
            for(int i = visualizationObjects.Count - 1; i >= 0; i--)
            {
                VectorVisualizer visualization = visualizationObjects[i];
                if(visualization.lifeTime <= 0)
                {
                    visualizationObjects.RemoveAt(i);
                }
            }
        }

        public void AddVisualization(int id, Vector3 startPoint, Vector3 endPoint, Color vectorColor, bool enduring, float lifeTime)
        {
            visualizerCount++;
            GameObject newObject = new GameObject("visualizer" + visualizerCount + 1);
            newObject.transform.parent = gameObject.transform;
            VectorVisualizer newVectorVisualizer = newObject.AddComponent<VectorVisualizer>();
            newVectorVisualizer.id = id;
            newVectorVisualizer.start = startPoint;
            newVectorVisualizer.end = endPoint;
            newVectorVisualizer.color = vectorColor;
            newVectorVisualizer.undying = enduring;
            newVectorVisualizer.lifeTime = lifeTime;
        }

        public void RemoveVisualizer(int id)
        {
            visualizerCount--;
            for(int i = 0; i < visualizerCount; i++)
                if (visualizationObjects[i].id == id)
                    visualizationObjects.RemoveAt(i);
        }
    }
}
