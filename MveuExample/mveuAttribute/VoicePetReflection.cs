using System.Reflection;

namespace MveuExample.mveuAttribute
{
    /// <summary>
    /// работает с методами
    /// </summary>
    public class VoicePetReflection
    {

        public readonly Type customAttribute;

        public VoicePetReflection(Type attributeType)
        {
            this.customAttribute = attributeType;
        }
        public IEnumerable<MethodInfo> GetMethodsWithCustomAttribute(IEnumerable<MethodInfo> methods)
        {
            return methods.Where(x => Attribute.IsDefined(x, this.customAttribute));
        }

        public void InvokeAllMethodsWithCustomAttribute(IEnumerable<MethodInfo> methods, object instanceType)
        {
            GetMethodsWithCustomAttribute(methods).ToList().ForEach(x => x.Invoke(instanceType, new object[] { }));
        }
    }
}
