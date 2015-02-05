﻿using System.Linq;

namespace CelticEgyptianRatscrewKata.Rules
{
    public class SandwichSnapRule : IRule
    {
        public bool ContainsSnap(Stack stackInput)
        {
            var stack = stackInput.ToList();
            return stack.AnyCorrespondingCardsInTwoStacksWhere(stack.Skip(2), t => t.Item1.HasSameRank(t.Item2));
        }
    }
}