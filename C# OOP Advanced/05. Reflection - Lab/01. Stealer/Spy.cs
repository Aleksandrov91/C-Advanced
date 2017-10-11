using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.NonPublic | BindingFlags.Public);

        StringBuilder sb = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        sb.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        FieldInfo[] classFiels = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] publicMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] privateMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        foreach (FieldInfo field in classFiels)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (MethodInfo method in privateMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in publicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);
        MethodInfo[] allPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in allPrivateMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);

        MethodInfo[] allMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        foreach (MethodInfo method in allMethods.Where(m => m.Name.Contains("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in allMethods.Where(m => m.Name.Contains("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }
}