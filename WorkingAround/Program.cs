using Business.Concrete;
using Entities.Concrete;

namespace WorkingAround;

internal class Program
{
	static void Main(string[] args)
	{

		Person person = new()
		{
			FirstName = "Rıdvan",
			LastName = "Kesken",
			NationalIdentity = 12345678901,
			DateOfBirthYear = 1993
		};

		PttManager pttManager = new(new PersonManager());

		pttManager.GiveMask(person);
	}
}
