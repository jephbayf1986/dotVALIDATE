﻿using System;

namespace dotValidate.Exceptions
{
    /// <summary>
    /// <b>dotValidate Validation Argument Exception</b> <br />
    /// Thrown when an incompatible argument is passed into a validation rule
    /// </summary>
    public class ValidationArgumentException : Exception
    {
        private ValidationArgumentException(string propertyName, string message)
            : base($"The following argument exception occured inside a validation check on field '{propertyName}': {message}")
        {
        }

        internal static ValidationArgumentException IncompatibleNumericArguments(string propertyName, IComparable valueProvided, IComparable comparisonArgument, string comparisonName)
        {
            return new ValidationArgumentException(propertyName, $"Unable to perform a '{comparisonName}' comparison between the field value {valueProvided} and the argument {comparisonArgument}");
        }
    }
}