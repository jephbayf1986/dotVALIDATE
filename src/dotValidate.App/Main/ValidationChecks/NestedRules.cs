﻿using dotValidate.Main.Helpers;
using dotValidate.Main.Models;
using dotValidate.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dotValidate.Main.ValidationChecks
{
    internal class NestedRules<TSubEntity> : ValidationCheck<TSubEntity>
    {
        public NestedRules(TSubEntity value, IEnumerable<Expression<Func<TSubEntity, ValidationCheck>>> nestedRules)
            : base(value)
        {
            _nestedTestFuncs = nestedRules.CreateValidationTestFuncs();
        }

        private IEnumerable<ValidationTestContainer<TSubEntity>> _nestedTestFuncs;

        protected internal override string DefaultRuleBreakDescription 
            => _generatedRuleBreakDescription;

        private string _generatedRuleBreakDescription;

        protected internal override bool GetTestResult()
        {
            var result = _nestedTestFuncs.RunAllTestsFor(ValueProvided);
            
            _generatedRuleBreakDescription = result.NestedFailureSummary(PropertyName);

            return !result.HasFailures;
        }
    }
}