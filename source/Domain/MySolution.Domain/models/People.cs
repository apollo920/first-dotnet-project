using MySolution.Commons.valueobjects;
using NetDevPack.Domain;

namespace MySolution.Domain;

public class People : Entity, IAggregateRoot
{
    public People(string name, int year_old, Cpf cpf)
    {
        Name = name;
        Year_old = year_old;
        Cpf = cpf;
    }

    public string? Name { get; private set; }

    public int? Year_old { get; private set; }

    public Cpf? Cpf { get; private set; }
}
