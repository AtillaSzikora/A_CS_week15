// Write an application that uses XML serialization to serialize and deserialize the last class you created as part of your job.

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializeClass {
	class SerializeClass {

		static void Main (string[] args) {
			Person jozsef = new Person("Jozsi", "Joo", "2000.10.10");

			FileStream fs = new FileStream("Person.Dat", FileMode.Create);
			IFormatter fmt = new SoapFormatter();
			fmt.Serialize(fs, jozsef); }
	}
}