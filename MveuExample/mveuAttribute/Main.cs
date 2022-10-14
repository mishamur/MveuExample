using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MveuExample.mveuAttribute.Attributes;
using MveuExample.mveuAttribute.Models;


namespace MveuExample.mveuAttribute
{
    public static class Main
    {
        public static void Start()
        {
            //получить все классы сборки
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] typesInCurAssemblys = assembly.GetTypes();

            //отсеиваем классы
            Type customClassAttribute = typeof(PetAttribute);
            PetReflection petReflection = new PetReflection(customClassAttribute);

            var typesWithCustomAttribute = petReflection.
                GetTypesWithCustomAttribute(typesInCurAssemblys).ToList();

            typesWithCustomAttribute.ForEach(x =>
            {
                //инстанцировать
                object reflectInstance = petReflection.CreateInstancePet(x);
                //получить все методы
                var allMethods = reflectInstance.GetType().GetMethods();
                Type customMetodsAttribute = typeof(VoicePetAttribute);
                
                //вызвать все методы с пользовательским атрибутом
                VoicePetReflection voicePetReflection = new VoicePetReflection(customMetodsAttribute);
                voicePetReflection.InvokeAllMethodsWithCustomAttribute(allMethods, reflectInstance);
                
            });

        }
    }
}
