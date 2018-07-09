using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace SistemaBancario.Models
{
    class GoogleCalendarConfig
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public Boolean newEvent(string summary, DateTime start, DateTime end)
        {
            if(createEvent(summary, start, end))
            {
                return true;
            } else {
                return false;
            }

        }

        private UserCredential setCredentials()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                Console.WriteLine("Credential file saved to: " + credPath);
            }

            return credential;
        }

        private CalendarService createService()
        {
            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = setCredentials(),
                ApplicationName = ApplicationName,
            });

            return service;
        }

        private Boolean createEvent(string summary, DateTime start, DateTime end)
        {
            try
            {
                Event newEvent = new Event()
                {
                    Summary = summary,
                    Start = new EventDateTime()
                    {
                        DateTime = start,
                        TimeZone = "America/Los_Angeles",
                    },
                    End = new EventDateTime()
                    {
                        DateTime = end,
                        TimeZone = "America/Los_Angeles",
                    },
                    Reminders = new Event.RemindersData()
                    {
                        UseDefault = false,
                        Overrides = new EventReminder[] {
                        new EventReminder() { Method = "email", Minutes = 24 * 60 },
                    }
                    }
                };

                String calendarId = "primary";
                EventsResource.InsertRequest request = createService().Events.Insert(newEvent, calendarId);
                Event createdEvent = request.Execute();
                Console.WriteLine("Event created: {0}", createdEvent.HtmlLink);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
