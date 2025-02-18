﻿
namespace UrfuProject
{
    public class Quest
    {
        public string Title { get; }
        public string MainText { get; }
        public string SceneName { get; }
        public int Reward { get; }
        public QuestStatus Status { get; set; }
        public QuestLevel Level { get; }
        public ScienceType ScienceType { get; }
        public QuestType Type { get; }

        public Quest(string title, string mainText, int reward, QuestLevel level, ScienceType science, QuestType type)
        {
            Title = title;
            MainText = mainText;
            Level = level;
            Reward = reward;
            Status = QuestStatus.None;
            ScienceType = science;
            SceneName = Scenes.MainScene;
            Type = type;

            switch (science)
            {
                case ScienceType.Math:
                    if (level == QuestLevel.First)
                    {
                        SceneName = Scenes.MainScene;
                    }
                    break;
                case ScienceType.Physics:
                    if (level == QuestLevel.Second)
                        SceneName = Scenes.DockScene;
                    break;
            }
        }
    }
}