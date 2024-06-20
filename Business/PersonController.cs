using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using PhumlaKamnandi.Data;
using System.Diagnostics;

namespace PhumlaKamnandi.Business
{
   public class PersonController
    {

        #region Data Members

        PersonDB personDB;
        Collection<Person> people;

        #endregion

        #region Properties

        public Collection<Person> AllPeople
        {
            get { return people;}
        }
        #endregion

        #region Constructor
        public PersonController()
        {
            personDB = new PersonDB();
             people=personDB.AllPeople;
        }

        #endregion

        #region Database Communication

        public void DataMaintenance(Person aPerson, DB.DBOperation operation)
        {
            Debug.WriteLine("Inside DataMaintenance");
            int index = 0;
            personDB.DataSetChange(aPerson, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    Debug.WriteLine("operation is Add");
                    people.Add(aPerson);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(aPerson);
                    people[index] = aPerson;
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aPerson);
                    people.RemoveAt(index);
                    break;

            }
        }

        public bool FinalizeChanges(Person person, DB.DBOperation operation)
        {
            Debug.WriteLine("Inside FinalizeChanges");
            return personDB.UpdateDataSource(person, operation);
        }
        #endregion

        #region Searching through a collection

        public Collection<Person> FindByRole(Collection<Person> people, Role.RoleType roleVal)
        {
            Collection<Person> matches = new Collection<Person>();
            foreach (Person person in people)
            {
                if (person.role.getRoleValue == roleVal)
                {
                    matches.Add(person);
                }
            }
            return matches;
        }

        public Person Find(string ID)
        {
            int index = 0;
            bool found = (people[index].ID.Equals(ID));
            int count = people.Count;
            while (!(found) && (index < people.Count - 1))
            {
                index = index + 1;
                found = (people[index].ID.Equals(ID));
            }
            return people[index];
        }

        public int FindIndex(Person aPerson)
        {
            int counter = 0;
            bool found = false;
            found = (aPerson.ID.Equals(people[counter].ID));   //using a Boolean Expression to initialise found
            while (!(found) & counter < people.Count - 1)
            {
                counter += 1;
                found = (aPerson.ID.Equals(people[counter].ID));
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
           
        }
        #endregion
    }
}
