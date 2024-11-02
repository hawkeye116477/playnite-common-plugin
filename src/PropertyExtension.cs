namespace CommonPlugin
{
    public static class PropertyExtension
    {
        public static object GetPropertyValue(this object T, string PropName)
        {
            return T.GetType().GetProperty(PropName)?.GetValue(T, null);
        }
    }
}
