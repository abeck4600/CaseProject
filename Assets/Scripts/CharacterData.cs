using System.Collections.Generic;

public static class CharacterData
{
    public class Mission
    {
        public string task, done, question;
        public Mission(string task, string done, string question)
        { this.task = task; this.done = done; this.question = question; }
    }

    public static readonly Dictionary<string, Mission> Missions = new()
    {
        { "Liann",   new Mission("Can you build a comic studio where I can draw my next comic?",
                                 "My studio looks so colorful!",
                                 "What should my first comic be about?") },
        { "Aliya",   new Mission("Can you build a boat so we can explore the world?",
                                 "We're ready to sail!",
                                 "Where should we sail to first?") },
        { "Leo",     new Mission("Can you build a kitchen so I can cook dinner for my friends?",
                                 "My friends are going to love dinner!",
                                 "What should I cook for my friends?") },
        { "Autumn",  new Mission("Can you build a cozy home for my puppy Biscuit?",
                                 "Biscuit is going to love his new home",
                                 "What will Biscuit do first when he moves in?") },
        { "Nova",    new Mission("Can you build a fun stage for my next show?",
                                 "The show is going to be so much fun!",
                                 "What funny thing should happen on my show?") },
        { "Paisley", new Mission("Can you build a quiet garden where I can play my guitar?",
                                 "It's so peaceful here!",
                                 "What song should I play in the garden?") },
        { "Olly",    new Mission("Can you build a machine that helps clean up the park?",
                                 "The park is going to be so clean!",
                                 "What else could your machine do?") },
        { "Zac",     new Mission("Can you build a sports field so we can play together?",
                                 "Let's go play!",
                                 "What game should we play first?") },
    };
}