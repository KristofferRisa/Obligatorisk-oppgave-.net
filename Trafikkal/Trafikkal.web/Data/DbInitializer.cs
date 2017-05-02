using System;
using System.Collections.Generic;
using System.Linq;
using Trafikkal.web.Models;

namespace Trafikkal.web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                //new IdentityRole()
                //{
                //    Name = "Admin",
                //    Id = 1
                //};

                var admin = new ApplicationUser()
                {
                    UserName = "admin@admin.no",
                    Email = "admin@admin.no",
                    PasswordHash = "AQAAAAEAACcQAAAAEIcglkt1OeAp0e0ojp7JyRJrxVUKmx8Kq5KByVgoObhfCSzi6aDZ6nv8IEMEZ5nt0A=="
                    //Roles = { new IdentityUserRole<string>(){"1", "1"}}

                };
                context.Users.Add(admin);
            }

            if (!context.Quiz.Any())
            {
                var quiz = new Quiz()
                {
                    Name = "Main",
                    MinScoreToPass = 70
                };

                context.Quiz.Add(quiz);
                context.SaveChanges();
            }

            // Look for any question.
            if (context.Question.Any())
            {
                return;   // DB has been seeded
            }

            var questions = new List<Question>()
            {
                new Question()
                {
                    Number = 1,
                    Text = "Du kjører i 20 km/t og bremser maksimalt. Det er litt glatt, og bremselengden blir 5 meter. Hva ville bremselengden blitt om farten hadde vært 80 km/t på samme føret?",
                    Alternative1 = "20 meter",
                    Alternative2 = "40",
                    Alternative3 = "60",
                    Alternative4 = "80",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 2,
                    Text = "Hva er riktig om mobiltelefonbruk i bil?",
                    Alternative1 = "Hverken passasjerer eller sjåfør har lov til å benytte mobiltelefon i bil",
                    Alternative2 = "Som sjåfør har du lov til å snakke i telefon så lenge mobilen er håndfri eller plassert i holder",
                    Alternative3 = "Som sjåfør har du ikke lov til å benytte mobiltelefon i bil",
                    Alternative4 = "Det er kun yrkessjåfører som har lov til å benytte mobiltelefon i bil",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = true,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 3,
                    Text = "Du møter en annen bil i mørket. Når skal du skifte til nærlys?",
                    Alternative1 = "Når avstanden er 200 - 300 meter",
                    Alternative2 = "2",
                    Alternative3 = "3",
                    Alternative4 = "4",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 4,
                    Text = "Oppgaven handler om alkohol og bilkjøring. Hvilken av påstandene er riktig?",
                    Alternative1 = "En bilfører med en alkoholkonsentrasjon i blodet på 0,3 promille kan ikke straffes.",
                    Alternative2 = "En bilfører er alltid påvirket av alkohol etter lovens bestemmelser dersom han har alkohol i blodet.",
                    Alternative3 = "Ved over 0,2 promille regnes du alltid som påvirket.",
                    Alternative4 = "Ved promillekjøring blir førerkortet inndratt i minst 2 år.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = true,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 5,
                    Text = "Hva menes med fartsblindhet?",
                    Alternative1 = "Føreren klarer ikke å vurdere hvilken hastighet møtende trafikk har.",
                    Alternative2 = "Føreren har problemer med å vurdere egen hastighet; fartsmåler er nødvendig som hjelpemiddel.",
                    Alternative3 = "Føreren klarer ikke å vurdere hvilken hastighet kryssende trafikk har",
                    Alternative4 = "Føreren klarer ikke å vurdere hvilken hastighet trafikken bak har",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 6,
                    Text = "Hvordan skal barn lavere enn 135 cm sikres i bilen?",
                    Alternative1 = "I tilpasset barnesikringsutstyr.",
                    Alternative2 = "I baksetet med bare bilbelte.",
                    Alternative3 = "På fanget til en voksen.",
                    Alternative4 = "I forsetet med bilbelte.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 7,
                    Text = "Hvilket av disse krav stilles til øvingskjøring i klasse B?",
                    Alternative1 = "Ledsager må ha fullført eget kurs.",
                    Alternative2 = "Det kan ikke være med passasjerer.",
                    Alternative3 = "Den som øvingskjører må ha med gyldig legitimasjon.",
                    Alternative4 = "Det er ikke tillatt å øvingskjøre med tilhenger.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = true,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 8,
                    Text = "Hva er riktig om krav til lys bak på bilen?",
                    Alternative1 = "Ryggelys skal være røde.",
                    Alternative2 = "Det er ingen krav til bestemt farge.",
                    Alternative3 = "Baklys skal være røde.",
                    Alternative4 = "Baklys skal være hvite.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative4Correct = false,
                    IsAlternative3Correct = true,
                    IsAlternative2Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 9,
                    Text = "Du skal svinge til venstre i et kryss. Hvilket møtende kjøretøy vil det være vanskeligst å vurdere avstanden til?",
                    Alternative1 = "Lastebil",
                    Alternative2 = "Varebil",
                    Alternative3 = "Motorsykkel",
                    Alternative4 = "Traktor",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative4Correct = false,
                    IsAlternative3Correct = true,
                    IsAlternative2Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 10,
                    Text = "Du skal kjøre rett fram i lyskrysset. Lyssignalet blinker gult. Hva sier reglene om vikeplikt?",
                    Alternative1 = "Jeg har vikeplikt for kryssende trafikk.",
                    Alternative2 = "Jeg har vikeplikt for trafikk fra høyre.",
                    Alternative3 = "Jeg har vikeplikt for trafikk fra venstre.",
                    Alternative4 = "Jeg har ikke vikeplikt.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative4Correct = true,
                    IsAlternative3Correct = false,
                    IsAlternative2Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                    Number = 11,
                    Text = "hva betyr dette skiltet?",
                    Img = "http://www.trafikkskilt.no/images/vikepliktsskilt/forkjorsvei.jpg",
                    Alternative1 = "forkjørsvei.",
                    Alternative2 = "Fare for sol i øynene.",
                    Alternative3 = "Det er god sikt langs veien.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question()
                {
                Number = 12,
                Text = "hvem har du vikeplikt for på en parkeringsplass?",
                Alternative1 = "Alle.",
                Alternative2 = "Biler fra høyre.",
                Alternative3 = "Motorsykler.",
                IsMultipleChoice = false,
                IsAlternative1Correct = true,
                IsAlternative2Correct = false,
                IsAlternative3Correct = false,
                Active = true,
                Created = DateTime.Now,
                QuizId = 1
                },
                new Question(){
                    Number = 13,
                    Text = "Om en bil har en hastighet på 80km/t, hvor mange meter i sekundet beveger den seg da?",
                    Alternative1 = "60 ms",
                    Alternative2 = "22,2 ms",
                    Alternative3 = "25 ms",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = true,
                    IsAlternative3Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question(){
                    Number = 14,
                    Text = "Du står i ro langs vegen i mørket for å vente på en passasjer. Hva er riktig bruk av lys?",
                    Alternative1 = "Parkeringslys",
                    Alternative2 = "Nærlys",
                    Alternative3 = "Tåkelys",
                    Alternative4 = "Kjørlys",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = true,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question(){
                    Number = 15,
                    Text = "Du får motorstopp på en trafikkert veg og må gå ut av bilen. Hva er riktig om bruk av refleksvest i slike situasjoner?",
                    Alternative1 = "Skal bare brukes når det er mørkt.",
                    Alternative2 = "Brukes bare hvis det er trafikk på vegen.",
                    Alternative3 = "Brukes dersom jeg føler meg utrygg.",
                    Alternative4 = "Skal alltid brukes.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question(){
                    Number = 16,
                    Text = "Hva slags skilt er dette?",
                    Img = "/images/binary-106960-180920.png",
                    Alternative1 = "Vegkryss",
                    Alternative2 = "Se opp vegkryss",
                    Alternative3 = "Farlig vegkryss med tog",
                    Alternative4 = "Farlig vegkryss",
                    Alternative5 = "Farlig vegkryss med normal vikeplikt",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = false,
                    IsAlternative4Correct = true,
                    IsAlternative5Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question(){
                    Number = 17,
                    Text = "Bil A skal kjøre ut av parkeringsplassen, hvem har han vikeplikt for?",
                    Alternative1 = "Kun for bil B.",
                    Alternative2 = "Kun for bil C.",
                    Alternative3 = "For bil B og C",
                    Alternative4 = "Ingen",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = true,
                    IsAlternative4Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question(){
                    Number = 18,
                    Text = "Hvilke av påstandene under er riktig når du ser dette skiltet?",
                    Img = "/images/binary-74671-46905.png",
                    Alternative1 = "Skiltet angir at kjørende skal stanse helt før kjøring inn på kryssende veg eller før kryssing av planovergang.",
                    Alternative2 = "at den kjørende har vikeplikt for kjørende trafikk i begge retninger på kryssende veg eller at den kjørende skal gi fri veg for sporvogn og jernbanetog på kryssende planovergang.",
                    Alternative3 = "Stansen skal skje foran og inntil stopplinje, eller dersom stopplinje mangler, så nær den kryssende veg som mulig.",
                    Alternative4 = "Stansen skal skje foran og inntil stopplinje, eller dersom stopplinje mangler, så trenger du ikke å stoppe.",
                    Alternative5 = "Du må bare stoppe dersom du ser biler",
                    IsMultipleChoice = true,
                    IsAlternative1Correct = true,
                    IsAlternative2Correct = true,
                    IsAlternative3Correct = true,
                    IsAlternative4Correct = false,
                    IsAlternative5Correct = false,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question(){
                    Number = 19,
                    Text = "Hva betyr dette skiltet?",
                    Img = "/images/binary-74678-46934.png",
                    Alternative1 = "Pass på møtende trafikk.",
                    Alternative2 = "Ikke lov å kjøreforbi.",
                    Alternative3 = "Møtende kjørende har vikeplikt.",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
                new Question(){
                    Number = 20,
                    Text = "Hva betyr dette bildet?",
                    Img = "/images/binary-102629-181982.png",
                    Alternative1 = "Rundkjøring",
                    Alternative2 = "Rundkjøring med vikeplikt",
                    Alternative3 = "Påbudt rundkjøring",
                    IsMultipleChoice = false,
                    IsAlternative1Correct = false,
                    IsAlternative2Correct = false,
                    IsAlternative3Correct = true,
                    Active = true,
                    Created = DateTime.Now,
                    QuizId = 1
                },
            };

            foreach (var question in questions)
            {
                context.Question.Add(question);
            }

            context.SaveChanges();
        }
    }
}