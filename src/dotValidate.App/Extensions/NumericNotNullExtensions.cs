﻿using dotValidate.Conditions;
using dotValidate.Models;
using System;

namespace dotValidate
{
    /// <summary>
    /// Property Extensions for building Validation Rules with dotValidate
    /// </summary>
    public static partial class PropertyExtensions
    {
        /// <summary>
        /// Must Equal...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="target">Target value to equal</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustEqual<T, TTarget>(this NotNullCondition<T?> conditional, TTarget target)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustEqual(target));
        }

        /// <summary>
        /// Must Not Equal...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="target">Target value to equal</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustNotEqual<T, TTarget>(this NotNullCondition<T?> conditional, TTarget target)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustNotEqual(target));
        }

        /// <summary>
        /// Must Be Zero
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeZero<T>(this NotNullCondition<T?> conditional)
            where T : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(MustBeZero);
        }

        /// <summary>
        /// Must Not Be Zero
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustNotBeZero<T>(this NotNullCondition<T?> conditional)
            where T : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(MustNotBeZero);
        }

        /// <summary>
        /// Must Be No More Than...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="maximum">Maximum allowed value</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeNoMoreThan<T, TTarget>(this NotNullCondition<T?> conditional, TTarget maximum)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustBeNoMoreThan(maximum));
        }

        /// <summary>
        /// Must Be No Less Than...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="minimum">Minimum allowed value</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeNoLessThan<T, TTarget>(this NotNullCondition<T?> conditional, TTarget minimum)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustBeNoLessThan(minimum));
        }

        /// <summary>
        /// Must Be Greater Than...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="target">Target value to be greater than</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeGreaterThan<T, TTarget>(this NotNullCondition<T?> conditional, TTarget target)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustBeGreaterThan(target));
        }

        /// <summary>
        /// Must Be Less Than...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="target">Target value to be less than</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeLessThan<T, TTarget>(this NotNullCondition<T?> conditional, TTarget target)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustBeLessThan(target));
        }

        /// <summary>
        /// Must Be Greater Than Or Equal To...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="minimum">Minimum allowed value</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeGreaterThanOrEqualTo<T, TTarget>(this NotNullCondition<T?> conditional, TTarget minimum)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustBeGreaterThanOrEqualTo(minimum));
        }

        /// <summary>
        /// Must Be Less Than Or Equal To...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TTarget">The type of value to compare to</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="maximum">Maximum allowed value</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeLessThanOrEqualTo<T, TTarget>(this NotNullCondition<T?> conditional, TTarget maximum)
            where T : struct, IComparable, IFormattable
            where TTarget : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustBeLessThanOrEqualTo(maximum));
        }

        /// <summary>
        /// Must Be In Range...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TRangeStart">The type of value to start target range</typeparam>
        /// <typeparam name="TRangeEnd">The type of value to end target range</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="rangeStart">Start of Target Range</param>
        /// <param name="rangeEnd">End of Target Range</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustBeInRange<T, TRangeStart, TRangeEnd>(this NotNullCondition<T?> conditional, TRangeStart rangeStart, TRangeEnd rangeEnd)
            where T : struct, IComparable, IFormattable
            where TRangeStart : struct, IComparable, IConvertible, IFormattable
            where TRangeEnd : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustBeInRange(rangeStart, rangeEnd));
        }

        /// <summary>
        /// Must Not Be In Range...
        /// </summary>
        /// <typeparam name="T">Type of property subject to validation rule</typeparam>
        /// <typeparam name="TRangeStart">The type of value to start target range</typeparam>
        /// <typeparam name="TRangeEnd">The type of value to end target range</typeparam>
        /// <param name="conditional">Not Null Condition - Returned from WhenNotNull()</param>
        /// <param name="rangeStart">Start of Target Range</param>
        /// <param name="rangeEnd">End of Target Range</param>
        /// <returns>Validation Check - <i>dotValidate</i> container for all input and output information for the validation rule</returns>
        public static ValidationCheck MustNotBeInRange<T, TRangeStart, TRangeEnd>(this NotNullCondition<T?> conditional, TRangeStart rangeStart, TRangeEnd rangeEnd)
            where T : struct, IComparable, IFormattable
            where TRangeStart : struct, IComparable, IConvertible, IFormattable
            where TRangeEnd : struct, IComparable, IConvertible, IFormattable
        {
            return conditional.CreateValidationCheck(x => x.MustNotBeInRange(rangeStart, rangeEnd));
        }
    }
}