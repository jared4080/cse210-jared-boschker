using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        public override int Complete()
        {
            return GetPointsAmount();
        }
    }
}