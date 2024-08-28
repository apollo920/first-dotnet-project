using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Cnpj : ValueObject
{
   
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
}
