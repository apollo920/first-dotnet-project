using MySolution.Commons.valueobjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution.Domain.contracts
{
    internal interface IPeopleRepository
    {
        Task<People> GetByName(string name);

        Task<People> GetByYear_Old(int year_old);

        Task<People> GetByCpf(Cpf cpf);

        Task<IEnumerable<People>> GetList();

        Task Add(People people);

        void Update(People people);

        void Remove(People people);
    }
}
