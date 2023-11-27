using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using TMPro;
using System.Linq;

public class FirebaseManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay; // Asigna tu componente TextMeshProUGUI desde el Editor

    DatabaseReference reference;

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            FirebaseApp app = FirebaseApp.DefaultInstance;
            reference = FirebaseDatabase.DefaultInstance.RootReference;

            LoadAndSortData();
        });
    }

    void LoadAndSortData()
    {
        reference.Child("users").OrderByChild("score").GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted)
            {
                Debug.LogError("Error al cargar datos: " + task.Exception);
            }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;

                var sortedData = snapshot.Children.OrderByDescending(child => child.Child("score").Value);

                // Crear una cadena para almacenar los valores ordenados
                string displayText = "";

                foreach (var data in sortedData)
                {
                    string usuario = data.Child("user").Value.ToString();
                    string valor = data.Child("score").Value.ToString();
                    displayText += "Usuario: " + usuario + "    Score: " + valor + "\n";
                }

                // Asignar la cadena al componente TextMeshProUGUI
                textDisplay.text = displayText;
            }
        });
    }
}
