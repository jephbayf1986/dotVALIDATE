﻿using dotValidate.Tests.TestHelpers;
using Shouldly;
using Xunit;

namespace dotValidate.Tests.IsolatedRuleTests.StringBased
{
    public class MustNotBe : StringTestClass
    {
        private const string TARGET = "FOOBAR";

        private class TestClassValidationRules : ValidationRules<TestClass>
        {
            public TestClassValidationRules()
            {
                DeclareRules(
                        x => x.TestNullable.MustNotBe(TARGET),
                        x => x.TestNonNullable.MustNotBe(TARGET, Enums.Case.Insensitve)
                    );
            }
        }

        [Fact]
        public void GivenAboveRules_WhenNoValuesAtTarget_PassTest()
        {
            // Arrange
            var request = GetTestClass();
            var validator = new TestClassValidationRules();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.HasFailures.ShouldBeFalse();
        }

        [Fact]
        public void GivenAboveRules_WhenNullableStringIsNull_PassTest()
        {
            // Arrange
            var request = GetTestClass();
            request.TestNullable = null;

            var validator = new TestClassValidationRules();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.HasFailures.ShouldBeFalse();
        }

        [Fact]
        public void GivenAboveRules_WhenAnyStringIsTarget_FailTestWithPropertyInMessage()
        {
            // Arrange
            var request = GetTestClass();
            request.TestNullable = TARGET;

            var validator = new TestClassValidationRules();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.ShouldSatisfyAllConditions(x => x.HasFailures.ShouldBeTrue(),
                                              x => x.FailureSummary().ShouldContain(nameof(request.TestNullable), Shouldly.Case.Insensitive),
                                              x => x.FailureSummary().ShouldContain(request.TestNullable, Shouldly.Case.Insensitive),
                                              x => x.FailureSummary().ShouldContain(TARGET, Shouldly.Case.Insensitive));
        }

        [Fact]
        public void GivenCaseComparisonNotDeclared_WhenStringIsTargetButWrongCase_PassTest()
        {
            // Arrange
            var request = GetTestClass();
            request.TestNullable = TARGET.ToLower();

            var validator = new TestClassValidationRules();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.HasFailures.ShouldBeFalse();
        }

        [Fact]
        public void GivenCaseIgnoreSpecified_WhenStringIsTargetButWrongCase_FailTestWithPropertyInMessage()
        {
            // Arrange
            var request = GetTestClass();
            request.TestNonNullable = TARGET.ToLower();

            var validator = new TestClassValidationRules();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.ShouldSatisfyAllConditions(x => x.HasFailures.ShouldBeTrue(),
                                              x => x.FailureSummary().ShouldContain(nameof(request.TestNonNullable), Shouldly.Case.Insensitive),
                                              x => x.FailureSummary().ShouldContain(request.TestNonNullable, Shouldly.Case.Insensitive),
                                              x => x.FailureSummary().ShouldContain(TARGET, Shouldly.Case.Insensitive),
                                              x => x.FailureSummary().ShouldContain("case-insensitive", Shouldly.Case.Insensitive));
        }
        
        private static TestClass GetTestClass()
        {
            return new TestClass()
            {
                TestNullable = RandomHelpers.RandomString(),
                TestNonNullable = RandomHelpers.RandomString()
            };
        }
    }
}