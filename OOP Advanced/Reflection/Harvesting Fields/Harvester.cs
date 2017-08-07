namespace Harvesting_Fields
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Harvester
    {
        public string GetAllPrivateFields(Type harvestingClass)
        {
            StringBuilder sb = new StringBuilder();
            FieldInfo[] nonpublicFields =
                harvestingClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            foreach (FieldInfo field in nonpublicFields)
            {
                if (field.IsPrivate)
                {
                    sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                }
            }

            return sb.ToString().Trim();
        }

        public string GetAllProtectedFields(Type harvestingClass)
        {
            StringBuilder sb = new StringBuilder();
            FieldInfo[] nonpublicFields =
                harvestingClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            foreach (FieldInfo field in nonpublicFields)
            {
                if (field.IsFamily)
                {
                    sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
                }
            }

            return sb.ToString().Trim();
        }

        public string GetAllPublicFields(Type harvestingClass)
        {
            StringBuilder sb = new StringBuilder();
            FieldInfo[] publicFields =
                harvestingClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            foreach (FieldInfo field in publicFields)
            {
                sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
            }

            return sb.ToString().Trim();
        }

        public string GetAllFields(Type harvestingClass)
        {
            StringBuilder sb = new StringBuilder();
            FieldInfo[] fields =
                harvestingClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                if (field.IsFamily)
                {
                    sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
                }
                else
                {
                    sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
