using FluentValidator;
using NotificationPattern.Entity;
using NotificationPattern.Result;

namespace NotificationPattern
{
    public class Verifier : Notifiable
    {
        public NotificationResultDTO Execute() 
        {
            //invalido
            //var person = new Person("Wallace Silva", "contato");

            //valido
            var person = new Person("Wallace", "contato@gmail.com");

            return Verify(person);       
        }

        private NotificationResultDTO Verify(Person person)
        {
            //Validates entity
            AddNotifications(person.Notifications);

            if (Invalid)
            {
                return new NotificationResultDTO( false, "Please validate following fields:", Notifications);
            }

            return new NotificationResultDTO(true, "Validation  sucess", null);
        }
    }
}
