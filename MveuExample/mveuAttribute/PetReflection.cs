using System.Reflection;

namespace MveuExample.mveuAttribute
{

    /// <summary>
    /// Работает с классом
    /// </summary>
    public class PetReflection
    {
        public readonly Type attributeType;

        public PetReflection(Type attributeType)
        {
            this.attributeType = attributeType;
        }

        /// <summary>
        /// выделяем из всех типов только типы с указанным аттрибутом 
        /// </summary>
        /// <param name="types"></param>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public IEnumerable<Type> GetTypesWithCustomAttribute(IEnumerable<Type> types)
        {
            return types.Where(x => Attribute.IsDefined(x, this.attributeType));
        }

        public object CreateInstancePet(Type type)
        { 
            return Activator.CreateInstance(type, new object[] { new string("Pet") });
        }

    }
}
