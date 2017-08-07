using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] requiredFields)
    {
        StringBuilder sb = new StringBuilder();
        Type hackedClass = Type.GetType(className);
        Object instance = Activator.CreateInstance(hackedClass, new object[] { });
        FieldInfo[] fields = hackedClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        sb.AppendLine($"Class under investigation: {hackedClass.FullName}");

        foreach (FieldInfo field in fields.Where(f => requiredFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type hackedClass = Type.GetType(className);
        FieldInfo[] fields = hackedClass.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
        MethodInfo[] publicMethods = hackedClass.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] privateMethods = hackedClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (FieldInfo field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }


        foreach (MethodInfo method in privateMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in publicMethods.Where(m=>m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type hackedClass = Type.GetType(className);
        MethodInfo[] privateMethods = hackedClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {hackedClass.BaseType.Name}");
        foreach (MethodInfo privateMethod in privateMethods)
        {
            sb.AppendLine($"{privateMethod.Name}");
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type hackedClass = Type.GetType(className);
        var getterMethods = hackedClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(x => x.Name.StartsWith("get"));
        var setterMethods = hackedClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(x => x.Name.StartsWith("set"));

        foreach (MethodInfo getter in getterMethods)
        {
            sb.AppendLine($"{getter.Name} will return {getter.ReturnType}");
        }

        foreach (MethodInfo setter in setterMethods)
        {
            sb.AppendLine($"{setter.Name} will set field of {setter.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }
}
