﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTextNode : StoryNode
{
    [SerializeField] private Letter firstLetter;
    public Letter FirstLetter { get { return firstLetter; } }
    [SerializeField] private string messageText;
    public virtual string MessageText { get { return messageText; } }

    public void InitForDialog(Letter letter, string message, Character character)
    {
        this.character = character;
        firstLetter = letter;
        messageText = message;
    }
}
