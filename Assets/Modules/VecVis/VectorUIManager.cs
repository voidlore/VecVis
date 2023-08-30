using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace VecVis
{
    public class VectorUIManager : MonoBehaviour
    {
        public VectorVisualizerManager vectorVisualizerManager;
        public TMP_InputField startX, startY, startZ, endX, endY, endZ, id;
        public float startXF, startYF, startZF, endXF, endYF, endZF;
        public int idToDelete;

        private void Start()
        {
            startX.onValueChanged.AddListener(OnInputFieldValueChangedstartX);
            startY.onValueChanged.AddListener(OnInputFieldValueChangedstartY);
            startZ.onValueChanged.AddListener(OnInputFieldValueChangedstartZ);
            endX.onValueChanged.AddListener(OnInputFieldValueChangedEndX);
            endY.onValueChanged.AddListener(OnInputFieldValueChangedEndY);
            endZ.onValueChanged.AddListener(OnInputFieldValueChangedEndZ);
            id.onValueChanged.AddListener(OnInputFieldValueChangedId);
        }

        private void OnInputFieldValueChangedstartX(string newValue)
        {
            if (float.TryParse(newValue, out float startX))
            {
                Debug.Log("Parsed input value as float");
                startXF = float.Parse(newValue);
            }
        }
        private void OnInputFieldValueChangedstartY(string newValue)
        {
            if (float.TryParse(newValue, out float startY))
            {
                Debug.Log("Parsed input value as float");
                startYF = float.Parse(newValue);
            }
        }
        private void OnInputFieldValueChangedstartZ(string newValue)
        {
            if (float.TryParse(newValue, out float startZ))
            {
                Debug.Log("Parsed input value as float");
                startZF = float.Parse(newValue);
            }
        }
        private void OnInputFieldValueChangedEndX(string newValue)
        {
            if (float.TryParse(newValue, out float startXEnd))
            {
                Debug.Log("Parsed input value as float");
                endXF = float.Parse(newValue);
            }

        }
        private void OnInputFieldValueChangedEndY(string newValue)
        {
            if (float.TryParse(newValue, out float startYEnd))
            {
                Debug.Log("Parsed input value as float");
                endYF = float.Parse(newValue);
            }
        }
        private void OnInputFieldValueChangedEndZ(string newValue)
        {
            if (float.TryParse(newValue, out float startZEnd))
            {
                Debug.Log("Parsed input value as float");
                endZF = float.Parse(newValue);
            }
        }
        private void OnInputFieldValueChangedId(string newValue)
        {
            if (int.TryParse(newValue, out int id))
            {
                Debug.Log("Parsed input value as int");
                idToDelete = int.Parse(newValue);
            }
        }

        public void AddVector()
        {
            vectorVisualizerManager.AddVisualization(idToDelete, new Vector3(startXF, startYF, startZF), new Vector3(endXF, endYF, endZF), Color.black, true, float.MaxValue);
        }
    }
}
