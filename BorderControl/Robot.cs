﻿namespace BorderControl
{
    public class Robot : ICitizen
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get; }
        public string Id { get; }
    }
}
