using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Enumerations;

namespace _07.MilitaryElite.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; }

        public MissionStateEnum MissionState { get; }

        public void CompleteMission();
    }
}
