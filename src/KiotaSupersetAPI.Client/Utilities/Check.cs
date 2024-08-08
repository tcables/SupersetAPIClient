using System;
using System.CodeDom.Compiler;
using System.CodeDom.Compiler;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Utilities;

[DebuggerStepThrough]
public static partial class Check
{
    public static T NotNull<T>(
        T value,
        string parameterName)
    {
        if (value == null)
        {
            throw new ArgumentNullException(parameterName);
        }

        return value;
    }

    public static T NotNull<T>(
        T value,
        string parameterName,
        string message)
    {
        if (value == null)
        {
            throw new ArgumentNullException(parameterName, message);
        }

        return value;
    }

    public static string NotNull(
        string value,
        string parameterName,
        int maxLength = int.MaxValue,
        int minLength = 0)
    {
        if (value == null)
        {
            throw new ArgumentException($"{parameterName} can not be null!", parameterName);
        }

        if (value.Length > maxLength)
        {
            throw new ArgumentException($"{parameterName} length must be equal to or lower than {maxLength}!", parameterName);
        }

        if (minLength > 0 && value.Length < minLength)
        {
            throw new ArgumentException($"{parameterName} length must be equal to or bigger than {minLength}!", parameterName);
        }

        return value;
    }

    public static string NotNullOrWhiteSpace(
        string value,
        string parameterName,
        int maxLength = int.MaxValue,
        int minLength = 0)
    {
        if (value.IsNullOrWhiteSpace())
        {
            throw new ArgumentException($"{parameterName} can not be null, empty or white space!", parameterName);
        }

        if (value.Length > maxLength)
        {
            throw new ArgumentException($"{parameterName} length must be equal to or lower than {maxLength}!", parameterName);
        }

        if (minLength > 0 && value.Length < minLength)
        {
            throw new ArgumentException($"{parameterName} length must be equal to or bigger than {minLength}!", parameterName);
        }

        return value;
    }

    public static string NotNullOrEmpty(
        string value,
        string parameterName,
        int maxLength = int.MaxValue,
        int minLength = 0)
    {
        if (value.IsNullOrEmpty())
        {
            throw new ArgumentException($"{parameterName} can not be null or empty!", parameterName);
        }

        if (value.Length > maxLength)
        {
            throw new ArgumentException($"{parameterName} length must be equal to or lower than {maxLength}!", parameterName);
        }

        if (minLength > 0 && value.Length < minLength)
        {
            throw new ArgumentException($"{parameterName} length must be equal to or bigger than {minLength}!", parameterName);
        }

        return value;
    }

    public static bool IsNullOrEmpty(
        this string str)
    {
        return string.IsNullOrEmpty(str);
    }

    public static bool IsNullOrWhiteSpace(
        this string str)
    {
        return string.IsNullOrWhiteSpace(str);
    }

    public static string Length(
        string value,
        string parameterName,
        int maxLength,
        int minLength = 0)
    {
        if (minLength > 0)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(parameterName + " can not be null or empty!", parameterName);
            }

            if (value.Length < minLength)
            {
                throw new ArgumentException($"{parameterName} length must be equal to or bigger than {minLength}!", parameterName);
            }
        }

        if (value != null && value.Length > maxLength)
        {
            throw new ArgumentException($"{parameterName} length must be equal to or lower than {maxLength}!", parameterName);
        }

        return value;
    }

    public static T NotDefaultOrNull<T>(
        T? value,
        string parameterName)
        where T : struct
    {
        if (value == null)
        {
            throw new ArgumentException($"{parameterName} is null!", parameterName);
        }

        if (value.Value.Equals(default(T)))
        {
            throw new ArgumentException($"{parameterName} has a default value!", parameterName);
        }

        return value.Value;
    }
}

public static partial class Check
{
    public static ICollection<T> NotNullOrEmpty<T>(
        ICollection<T> value,
        string parameterName)
    {
        if (value.IsNullOrEmpty())
        {
            throw new ArgumentException($"{parameterName} can not be null or empty!", parameterName);
        }

        return value;
    }

    public static bool IsNullOrEmpty<T>(
        this ICollection<T> source)
    {
        return source == null || source.Count <= 0;
    }
}

public static partial class Check
{
    public static Type AssignableTo<TBaseType>(
        Type type,
        string parameterName)
    {
        NotNull(type, parameterName);

        if (!type.IsAssignableTo<TBaseType>())
        {
            throw new ArgumentException($"{parameterName} (type of {type.AssemblyQualifiedName}) should be assignable to the {typeof(TBaseType).GetFullNameWithAssemblyName()}!");
        }

        return type;
    }

    public static bool IsAssignableTo<TTarget>(
        this Type type)
    {
        NotNull(type, nameof(type));

        return type.IsAssignableTo(typeof(TTarget));
    }

    public static bool IsAssignableTo(
        this Type type,
        Type targetType)
    {
        NotNull(type, nameof(type));
        NotNull(targetType, nameof(targetType));

        return targetType.IsAssignableFrom(type);
    }


    private static string GetFullNameWithAssemblyName(this Type type)
    {
        return $"{type.FullName}, {type.Assembly.GetName().Name}";
    }
}

public static partial class Check
{
    public static Int16 IsPositive(
        Int16 value,
        string parameterName)
    {
        if (value == 0)
        {
            throw new ArgumentException($"{parameterName} is equal to zero");
        }

        if (value < 0)
        {
            throw new ArgumentException($"{parameterName} is less than zero");
        }

        return value;
    }

    public static Int32 IsPositive(
        Int32 value,
        string parameterName)
    {
        if (value == 0)
        {
            throw new ArgumentException($"{parameterName} is equal to zero");
        }

        if (value < 0)
        {
            throw new ArgumentException($"{parameterName} is less than zero");
        }

        return value;
    }

    public static Int64 IsPositive(
        Int64 value,
        string parameterName)
    {
        if (value == 0)
        {
            throw new ArgumentException($"{parameterName} is equal to zero");
        }

        if (value < 0)
        {
            throw new ArgumentException($"{parameterName} is less than zero");
        }

        return value;
    }

    public static float IsPositive(
        float value,
        string parameterName)
    {
        if (value == 0)
        {
            throw new ArgumentException($"{parameterName} is equal to zero");
        }

        if (value < 0)
        {
            throw new ArgumentException($"{parameterName} is less than zero");
        }

        return value;
    }

    public static double IsPositive(
        double value,
        string parameterName)
    {
        if (value == 0)
        {
            throw new ArgumentException($"{parameterName} is equal to zero");
        }

        if (value < 0)
        {
            throw new ArgumentException($"{parameterName} is less than zero");
        }

        return value;
    }

    public static decimal IsPositive(
        decimal value,
        string parameterName)
    {
        if (value == 0)
        {
            throw new ArgumentException($"{parameterName} is equal to zero");
        }

        if (value < 0)
        {
            throw new ArgumentException($"{parameterName} is less than zero");
        }

        return value;
    }

    public static Int16 InRange(
        Int16 value,
        string parameterName,
        Int16 minimumValue,
        Int16 maximumValue = Int16.MaxValue)
    {
        if (value < minimumValue || value > maximumValue)
        {
            throw new ArgumentException($"{parameterName} is out of range '{minimumValue} to {maximumValue}'");
        }

        return value;
    }
    public static Int32 InRange(
        Int32 value,
        string parameterName,
        Int32 minimumValue,
        Int32 maximumValue = Int32.MaxValue)
    {
        if (value < minimumValue || value > maximumValue)
        {
            throw new ArgumentException($"{parameterName} is out of range '{minimumValue} to {maximumValue}'");
        }

        return value;
    }

    public static Int64 InRange(
        Int64 value,
        string parameterName,
        Int64 minimumValue,
        Int64 maximumValue = Int64.MaxValue)
    {
        if (value < minimumValue || value > maximumValue)
        {
            throw new ArgumentException($"{parameterName} is out of range '{minimumValue} to {maximumValue}'");
        }

        return value;
    }


    public static float InRange(
        float value,
        string parameterName,
        float minimumValue,
        float maximumValue = float.MaxValue)
    {
        if (value < minimumValue || value > maximumValue)
        {
            throw new ArgumentException($"{parameterName} is out of range '{minimumValue} to {maximumValue}'");
        }

        return value;
    }


    public static double InRange(
        double value,
        string parameterName,
        double minimumValue,
        double maximumValue = double.MaxValue)
    {
        if (value < minimumValue || value > maximumValue)
        {
            throw new ArgumentException($"{parameterName} is out of range '{minimumValue} to {maximumValue}'");
        }

        return value;
    }


    public static decimal InRange(
        decimal value,
        string parameterName,
        decimal minimumValue,
        decimal maximumValue = decimal.MaxValue)
    {
        if (value < minimumValue || value > maximumValue)
        {
            throw new ArgumentException($"{parameterName} is out of range '{minimumValue} to {maximumValue}'");
        }

        return value;
    }
}
