﻿using UnityEngine;
using UnityEngine.UI;

namespace UrfuProject
{
    public class Scroll : MonoBehaviour
    {
        public GameObject[] QuestsPrefabs;
        public Text TitleText;
        public Text DescriptionText;

        private Quest Quest;

        public void SetQuest(Quest quest)
        {
            Quest = quest;
            TitleText.text = quest.Title;
            DescriptionText.text = quest.MainText;
        }
        public bool NeedNewQuest() => Quest == null;
    }
}