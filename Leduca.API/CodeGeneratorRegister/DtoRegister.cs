using System.Reflection;
using Leduca.API.DbModels;
using Mapster;

namespace Leduca.API.CodeGeneratorRegister;


public class DtoRegister : ICodeGenerationRegister
{
    public void Register(CodeGenerationConfig config)
    {
        config.AdaptTo("[name]Dto")
            .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Leduca.API.DbModels")
            .ExcludeTypes(typeof(LeducaContext))
            .IgnoreNullValues(true);
    }
}