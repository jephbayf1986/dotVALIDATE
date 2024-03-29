﻿using System;
using System.Collections.Generic;

namespace dotValidate.Main.ValidationChecks
{
    internal class EnumerableCountMinimum<T> : ValidationCheck<IEnumerable<T>>
    {
        public EnumerableCountMinimum(IEnumerable<T> value, int minCount)
            : base(value)
        {
            _minCount = minCount;
        }

        private readonly int _minCount;

        protected internal override string DefaultRuleBreakDescription => throw new NotImplementedException();

        protected internal override bool GetTestResult()
        {
            throw new NotImplementedException();
        }
    }
}
