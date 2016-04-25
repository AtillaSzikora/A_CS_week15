using System;
using System.Runtime.Serialization;

namespace SerializeClass {

	[Serializable]
	internal class Person {

        public Person(string firstName, string lastName, string birthDate) {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = birthDate; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			throw new NotImplementedException(); }
	}
}
