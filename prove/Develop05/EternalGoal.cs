using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        public override int Complete()
        {
            return GetPointsAmount();
        }
    }
}