using Firebase.Database;
using UnityEngine;
using TMPro;
using System.Collections;
using System;

public class DatabaseManager : MonoBehaviour
{
    public TMP_InputField Name;
    public TextMeshProUGUI Score;

    public TextMeshProUGUI UserText;
    public TextMeshProUGUI ScoreText;

    private string userID;

    private DatabaseReference databaseReference;

    void Start()
    {
        userID = SystemInfo.deviceUniqueIdentifier;
        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void CreateUser()
    {
        User newUser = new User(Name.text, int.Parse(Score.text));
        string json = JsonUtility.ToJson(newUser);

        databaseReference.Child("users").Child(userID).SetRawJsonValueAsync(json);
    }

    public IEnumerator GetName(Action<string> onCallback)
    {
        var userNameData = databaseReference.Child("user").Child(userID).Child("name").GetValueAsync();

        yield return new WaitUntil(predicate: () => userNameData.IsCompleted);

        if (userNameData != null)
        {
            DataSnapshot snapshot = userNameData.Result;

            onCallback.Invoke(snapshot.Value.ToString());
        }
    }

    public IEnumerator GetScore(Action<string> onCallback)
    {
        var userScoreData = databaseReference.Child("user").Child(userID).Child("score").GetValueAsync();

        yield return new WaitUntil(predicate: () => userScoreData.IsCompleted);

        if (userScoreData != null)
        {
            DataSnapshot snapshot = userScoreData.Result;

            onCallback.Invoke(snapshot.Value.ToString());
        }
    }

    public void GetUserInfo()
    {
        StartCoroutine(GetName((string name) =>
        {
            UserText.text = "user: " + name;
        }));

        StartCoroutine(GetScore((string score) =>
        {
            ScoreText.text = "score: " + score;
        }));
    }
}
